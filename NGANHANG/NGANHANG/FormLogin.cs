using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG
{
    public partial class FormLogin : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void getListServer(string query)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
                conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cbxChiNhanh.DataSource = Program.bds_dspm;
            cbxChiNhanh.DisplayMember = "TENCN";
            cbxChiNhanh.ValueMember = "TENSERVER";
        }

        private int connectCSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu gốc.\nBạn xem lại tên Server và tên CSDL.\n" + e.Message);
                return 0;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (connectCSDLGOC() == 0)
                return;
            getListServer("SELECT * FROM V_DS_PHANMANH");
            conn_publisher.Close();
            cbxChiNhanh.SelectedIndex = 0;
        }

        private void cbxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbxChiNhanh.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ tên đăng nhập và mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = txtTenDangNhap.Text;
            Program.password = txtMatKhau.Text;
            if (Program.KetNoi() == 0)
                return;
            Program.mChinhanh = cbxChiNhanh.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            string query = "EXEC SP_DangNhap '" + Program.mlogin + "'";
            Program.myReader = Program.execSqlDataReader(query);
            if (Program.myReader == null)
                return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login của bạn không có quyền xem dữ liệu.\nHãy đăng nhập lại.\n", "", MessageBoxButtons.OK);
                return;
            }

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmMain.ssttMANV.Text = "MANV: " + Program.username;
            Program.frmMain.ssttHOTEN.Text = "HOTEN: " + Program.mHoten;
            Program.frmMain.ssttNHOM.Text = "NHOM: " + Program.mGroup;
            Program.frmMain.bbtnTaoTaiKhoan.Enabled = true;
            Program.frmMain.rbpNV.Visible = Program.frmMain.rbpKH.Visible = Program.frmMain.rbpTK.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
