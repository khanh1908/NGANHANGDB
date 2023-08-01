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
    public partial class FormKhachHang : Form
    {
        int vitri = 0;
        string macn = "";
        string flag = "";
        string cmndcu = "";

        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.KhachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.NGANHANGDataSet);

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            NGANHANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.KhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KhachHangTableAdapter.Fill(this.NGANHANGDataSet.KhachHang);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.TaiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TaiKhoanTableAdapter.Fill(this.NGANHANGDataSet.TaiKhoan);

            cbxChiNhanh.DataSource = Program.bds_dspm;
            cbxChiNhanh.DisplayMember = "TENCN";
            cbxChiNhanh.ValueMember = "TENSERVER";
            cbxChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CHINHANH")
            {
                btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDel.Enabled = true;
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
            else
            {
                NGANHANGDataSet.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'nGANHANGDataSet.KhachHang' table. You can move, or remove it, as needed.
                this.KhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KhachHangTableAdapter.Fill(this.NGANHANGDataSet.KhachHang);
                // TODO: This line of code loads data into the 'nGANHANGDataSet.TaiKhoan' table. You can move, or remove it, as needed.
                this.TaiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.TaiKhoanTableAdapter.Fill(this.NGANHANGDataSet.TaiKhoan);
                macn = ((DataRowView)KhachHangBindingSource[0])["MACN"].ToString();
            }
        }

        private void btnItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = KhachHangBindingSource.Position;
            pnlDetail.Enabled = btnItemSave.Enabled = btnItemUndo.Enabled = true;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDel.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = false;
            KhachHangBindingSource.AddNew();
            txtMaCN.Text = ((DataRowView)KhachHangBindingSource[0])["MACN"].ToString();
            txtCMND.Focus();
            flag = "add";
        }

        private void btnItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = KhachHangBindingSource.Position;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDel.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = false;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = true;
            flag = "edit";
            cmndcu = txtCMND.Text;
        }

        private void btnItemDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cmnd = "";

            if (TaiKhoanBindingSource.Count > 0)
            {
                MessageBox.Show("Khách hàng này đã có tài khoản, nên không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    cmnd = ((DataRowView)KhachHangBindingSource[KhachHangBindingSource.Position])["CMND"].ToString();
                    KhachHangBindingSource.RemoveCurrent();
                    this.KhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KhachHangTableAdapter.Update(this.NGANHANGDataSet.KhachHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khách hàng. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.KhachHangTableAdapter.Fill(this.NGANHANGDataSet.KhachHang);
                    KhachHangBindingSource.Position = KhachHangBindingSource.Find("CMND", cmnd);
                    return;
                }
            }
            if (KhachHangBindingSource.Count == 0)
                btnItemDel.Enabled = false;
        }

        private void btnItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhachHangBindingSource.CancelEdit();
            if (btnItemAdd.Enabled == false)
                KhachHangBindingSource.Position = vitri;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDel.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = false;
        }

        private void btnItemReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.KhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KhachHangTableAdapter.Fill(this.NGANHANGDataSet.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Chứng minh nhân dân không được để trống !", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }

            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống !", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }

            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống !", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }

            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không đúng định dạng.\nHãy chắc chắn sdt có 10 chữ số và bắt đầu với 0 !", "", MessageBoxButtons.OK);
                txtSDT.Focus();
                return;
            }

            if (flag == "add")
            {
                string queryCheckCMND = "EXEC SP_CheckCMND '" + txtCMND.Text + "'";
                Program.myReader = Program.execSqlDataReader(queryCheckCMND);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                int check = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (check == 1)
                {
                    MessageBox.Show("Khách hàng này đang tồn tại ở phân mảnh hiện tại !", "", MessageBoxButtons.OK);
                    txtCMND.Focus();
                    return;
                }
                else if (check == 2)
                {
                    MessageBox.Show("Khách hàng này đang tồn tại ở phân mảnh khác !", "", MessageBoxButtons.OK);
                    txtCMND.Focus();
                    return;
                }

                try
                {
                    KhachHangBindingSource.EndEdit();
                    KhachHangBindingSource.ResetCurrentItem();
                    //string queryInsert = "EXEC InsertKhachHang '"
                    //                + txtCMND.Text + "', N'"
                    //                + txtHo.Text + "', N'"
                    //                + txtTen.Text + "', N'"
                    //                + txtDiaChi.Text + "', N'"
                    //                + cbxPhai.SelectedText.ToString() + "', '"
                    //                + deNgayCap.Text + "', '"
                    //                + txtSDT.Text + "', '"
                    //                + txtMaCN.Text + "'";
                    //Program.execSqlNonQuery(queryInsert);
                    this.KhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KhachHangTableAdapter.Update(this.NGANHANGDataSet.KhachHang);
                }
                catch (Exception ex)
                {
                    KhachHangBindingSource.RemoveCurrent();
                    MessageBox.Show("Lỗi thêm khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            if (flag == "edit")
            {
                try
                {
                    KhachHangBindingSource.EndEdit();
                    KhachHangBindingSource.ResetCurrentItem();
                    //string queryUpdate = "EXEC UpdateKhachHang '"
                    //                + cmndcu + "', '"
                    //                + txtCMND.Text + "', N'"
                    //                + txtHo.Text + "', N'"
                    //                + txtTen.Text + "', N'"
                    //                + txtDiaChi.Text + "', N'"
                    //                + cbxPhai.SelectedText.ToString() + "', '"
                    //                + deNgayCap.Text + "', '"
                    //                + txtSDT.Text + "'";
                    //Program.execSqlNonQuery(queryUpdate);
                    this.KhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KhachHangTableAdapter.Update(this.NGANHANGDataSet.KhachHang);
                }
                catch (Exception ex)
                {
                    KhachHangBindingSource.RemoveCurrent();
                    MessageBox.Show("Lỗi chỉnh sửa khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDel.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = false;
            pnlDetail.Enabled = false;
        }

        private void btnItemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
