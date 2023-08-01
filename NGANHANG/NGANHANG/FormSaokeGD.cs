using DevExpress.XtraReports.UI;
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
    public partial class FormSaokeGD : Form
    {
        public FormSaokeGD()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.TaiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.NGANHANGDataSet);

        }

        private void FormSaokeGD_Load(object sender, EventArgs e)
        {
            NGANHANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.TaiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TaiKhoanTableAdapter.Fill(this.NGANHANGDataSet.TaiKhoan);

            cbxChiNhanh.DataSource = Program.bds_dspm;
            cbxChiNhanh.DisplayMember = "TENCN";
            cbxChiNhanh.ValueMember = "TENSERVER";
            cbxChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CHINHANH")
            {
                pnlCN.Enabled = false;
            }
        }

        private void cbxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbxChiNhanh.SelectedValue.ToString();

            if (cbxChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới !", "", MessageBoxButtons.OK);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (deFrom.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn thời gian bắt đầu !", "", MessageBoxButtons.OK);
                deFrom.Focus();
                return;
            }
            if (deTo.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn thời gian kết thúc !", "", MessageBoxButtons.OK);
                deTo.Focus();
                return;
            }
            string from = ((DateTime)deFrom.EditValue).ToString("yyyyMMdd");
            string to = ((DateTime)deTo.EditValue).AddDays(1).ToString("yyyyMMdd");
            XR_SaoKeGD rp = new XR_SaoKeGD(from, to, cbxSoTK.SelectedValue.ToString().Trim());
            rp.lblTieuDe.Text = "SAO KÊ GIAO DỊCH CỦA TÀI KHOẢN " + cbxSoTK.SelectedValue.ToString().Trim() + " TỪ " + deFrom.Text.ToString().Trim() + " ĐẾN " + deTo.Text.ToString().Trim();            
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }
    }
}
