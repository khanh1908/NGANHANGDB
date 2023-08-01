using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG
{
    public partial class FormTaoTaiKhoan : Form
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            NGANHANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.DS0Login' table. You can move, or remove it, as needed.
            this.DS0LoginTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DS0LoginTableAdapter.Fill(this.NGANHANGDataSet.DS0Login);
            
            txtRole.Text = Program.mGroup;
        }

        private void cbxNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDangNhap.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được để trống !", "", MessageBoxButtons.OK);
                    txtTenDangNhap.Focus();
                    return;
                }
                if (txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được để trống !", "", MessageBoxButtons.OK);
                    txtMatKhau.Focus();
                    return;
                }

                string queryTaoTaiKhoan = "EXEC SP_TaoTaiKhoan '" + txtTenDangNhap.Text.Trim() + "', '" 
                                                                    + txtMatKhau.Text.Trim() + "', '"
                                                                    + txtUser.Text.Trim() + "', '"
                                                                    + txtRole.Text.Trim() + "'";
                Program.myReader = Program.execSqlDataReader(queryTaoTaiKhoan);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                int check = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (check == 1)
                {
                    MessageBox.Show("Tài khoản đăng nhập đã tồn tại !", "", MessageBoxButtons.OK);
                    txtTenDangNhap.Focus();
                    return;
                }
                if (check == 2)
                {
                    MessageBox.Show("User đã tồn tại !", "", MessageBoxButtons.OK);
                    cbxNV.Focus();
                    return;
                }
                if (check == 0)
                {
                    MessageBox.Show("Tạo tài khoản mới thành công", "", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo tài khoản. Vui lòng thử lại !\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
