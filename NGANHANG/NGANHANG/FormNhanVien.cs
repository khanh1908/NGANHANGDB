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
    public partial class FormNhanVien : Form
    {
        int vitri = 0;
        string flag = "";

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {            
            NGANHANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.GD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GD_GOIRUTTableAdapter.Fill(this.NGANHANGDataSet.GD_GOIRUT);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.GD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GD_CHUYENTIENTableAdapter.Fill(this.NGANHANGDataSet.GD_CHUYENTIEN);

            cbxChiNhanh.DataSource = Program.bds_dspm;
            cbxChiNhanh.DisplayMember = "TENCN";
            cbxChiNhanh.ValueMember = "TENSERVER";
            cbxChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CHINHANH")
            {
                btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDel.Enabled = btnItemMove.Enabled = true;
                pnlCN.Enabled = false;
            }

            if (NhanVienBindingSource.Count == 0)
                btnItemDel.Enabled = false;
        }

        private void trangThaiXoaCheckedComboBoxEdit_EditValueChanged(object sender, EventArgs e)
        {

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
                // TODO: This line of code loads data into the 'nGANHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
                this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
                // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
                this.GD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GD_GOIRUTTableAdapter.Fill(this.NGANHANGDataSet.GD_GOIRUT);
                // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_GOIRUT' table. You can move, or remove it, as needed.
                this.GD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GD_CHUYENTIENTableAdapter.Fill(this.NGANHANGDataSet.GD_CHUYENTIEN);
            }
        }

        private void btnItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = NhanVienBindingSource.Position;
            pnlDetail.Enabled = btnItemSave.Enabled = btnItemUndo.Enabled = true;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDel.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = cbTTX.Enabled = gctNV.Enabled = btnItemMove.Enabled = false;
            NhanVienBindingSource.AddNew();
            txtMaCN.Text = ((DataRowView)NhanVienBindingSource[0])["MACN"].ToString();
            cbTTX.Checked = false;
            txtMaNV.Focus();
            flag = "add";
        }

        private void btnItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhanVienBindingSource.CancelEdit();
            if (btnItemAdd.Enabled == false)
                NhanVienBindingSource.Position = vitri;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDel.Enabled = btnItemReload.Enabled  = btnItemExit.Enabled = gctNV.Enabled = cbTTX.Enabled = btnItemMove.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = pnlChuyenCN.Enabled = false;
        }

        private void btnItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = NhanVienBindingSource.Position;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDel.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctNV.Enabled = btnItemMove.Enabled = false;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = true;
            flag = "edit";
        }

        private void btnItemDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = "";

            if (GD_GOIRUTBindingSource.Count > 0)
            {
                MessageBox.Show("Nhân viên bạn muốn xóa đã thực hiện giao dịch gửi rút, nên không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (GD_CHUYENTIENBindingSource.Count > 0)
            {
                MessageBox.Show("Nhân viên bạn muốn xóa đã thực hiện giao dịch chuyển tiền, nên không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên có mã " + txtMaNV.Text, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = ((DataRowView)NhanVienBindingSource[NhanVienBindingSource.Position])["MANV"].ToString();
                    NhanVienBindingSource.RemoveCurrent();
                    this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NhanVienTableAdapter.Update(this.NGANHANGDataSet.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
                    NhanVienBindingSource.Position = NhanVienBindingSource.Find("MANV", manv);
                    return;
                }
            }
        }

        private void btnItemReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống !", "", MessageBoxButtons.OK);
                txtMaNV.Focus();
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

            if (cbxPhai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính !", "", MessageBoxButtons.OK);
                cbxPhai.Focus();
                return;
            }

            if (flag == "add")
            {
                string queryCheckMANV = "EXEC SP_CheckMANV '" + txtMaNV.Text + "'";
                Program.myReader = Program.execSqlDataReader(queryCheckMANV);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                int check = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (check == 1)
                {
                    MessageBox.Show("Mã nhân viên này đang tồn tại ở phân mảnh hiện tại !", "", MessageBoxButtons.OK);
                    txtMaNV.Focus();
                    return;
                }
                else if (check == 2)
                {
                    MessageBox.Show("Mã nhân viên này đang tồn tại ở phân mảnh khác !", "", MessageBoxButtons.OK);
                    txtMaNV.Focus();
                    return;
                }

                try
                {
                    NhanVienBindingSource.EndEdit();
                    NhanVienBindingSource.ResetCurrentItem();
                    this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NhanVienTableAdapter.Update(this.NGANHANGDataSet.NhanVien);
                }
                catch (Exception ex)
                {
                    NhanVienBindingSource.RemoveCurrent();
                    MessageBox.Show("Lỗi thêm nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            if (flag == "edit")
            {
                try
                {
                    NhanVienBindingSource.EndEdit();
                    NhanVienBindingSource.ResetCurrentItem();
                    this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NhanVienTableAdapter.Update(this.NGANHANGDataSet.NhanVien);
                }
                catch (Exception ex)
                {
                    NhanVienBindingSource.RemoveCurrent();
                    MessageBox.Show("Lỗi chỉnh sửa nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDel.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctNV.Enabled = btnItemMove.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = false;
            pnlDetail.Enabled = false;
        }

        private void btnItemMove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = NhanVienBindingSource.Position;
            string queryGetCNChuyen = "EXEC SP_GetCNChuyen '" + txtMaCN.Text.Trim() + "'";
            DataTable dt = Program.execSqlDataTable(queryGetCNChuyen);
            pnlChuyenCN.Enabled = btnItemUndo.Enabled = true;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDel.Enabled = btnItemSave.Enabled = btnItemReload.Enabled = gctNV.Enabled = btnItemMove.Enabled = false;
            cbxMoveCN.DataSource = dt;
            cbxMoveCN.DisplayMember = "TENCN";
            cbxMoveCN.ValueMember = "MACN";
            cbxMoveCN.SelectedIndex = 0;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string manv = "";
            if (MessageBox.Show("Bạn muốn chuyển nhân viên có mã " + txtMaNV.Text.Trim()
                                + " từ " + txtMaCN.Text.Trim()
                                + " sang " + cbxMoveCN.SelectedValue.ToString().Trim(), "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = ((DataRowView)NhanVienBindingSource[NhanVienBindingSource.Position])["MANV"].ToString();
                    string queryChuyenCN = "EXEC SP_ChuyenCN '" + txtMaNV.Text.Trim()
                                                                + "', '" + cbxMoveCN.SelectedValue.ToString().Trim() + "'";
                    Program.myReader = Program.execSqlDataReader(queryChuyenCN);
                    if (Program.myReader == null)
                        return;
                    Program.myReader.Read();
                    int check = Program.myReader.GetInt32(0);
                    Program.myReader.Close();
                    if (check == 1)
                    {
                        MessageBox.Show("Chuyển nhân viên thành công", "", MessageBoxButtons.OK);
                        this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
                        NhanVienBindingSource.Position = NhanVienBindingSource.Find("MANV", manv);
                    }
                    else
                    {
                        MessageBox.Show("Chuyển nhân viên thất bại", "", MessageBoxButtons.OK);
                        this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
                        NhanVienBindingSource.Position = NhanVienBindingSource.Find("MANV", manv);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chuyển nhân viên. Hãy thực hiện lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
                    NhanVienBindingSource.Position = NhanVienBindingSource.Find("MANV", manv);
                    return;
                }
            }

            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDel.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctNV.Enabled = btnItemMove.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = false;
            pnlDetail.Enabled = false;
        }
    }
}
