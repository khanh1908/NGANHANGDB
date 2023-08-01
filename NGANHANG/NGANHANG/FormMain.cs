using DevExpress.XtraBars;
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
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public Form checkExist(Type ftype)
        {
            foreach(Form f in MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void bbtnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormLogin));
            if (form != null)
                form.Activate();
            else
            {
                FormLogin formLogin = new FormLogin();
                formLogin.MdiParent = this;
                formLogin.Show();
            }
        }

        private void bbtnQLNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormNhanVien));
            if (form != null)
                form.Activate();
            else
            {
                FormNhanVien formNV = new FormNhanVien();
                formNV.MdiParent = this;
                formNV.Show();
            }
        }

        private void bbtnQLKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormKhachHang));
            if (form != null)
                form.Activate();
            else
            {
                FormKhachHang formKH = new FormKhachHang();
                formKH.MdiParent = this;
                formKH.Show();
            }
        }

        private void bbtnMoTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormMoTK));
            if (form != null)
                form.Activate();
            else
            {
                FormMoTK formMoTK = new FormMoTK();
                formMoTK.MdiParent = this;
                formMoTK.Show();
            }
        }

        private void bbtnGuiRut_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormGuiRut));
            if (form != null)
                form.Activate();
            else
            {
                FormGuiRut formGuiRut = new FormGuiRut();
                formGuiRut.MdiParent = this;
                formGuiRut.Show();
            }
        }

        private void bbtnChuyenTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormChuyenTien));
            if (form != null)
                form.Activate();
            else
            {
                FormChuyenTien formChuyenTien = new FormChuyenTien();
                formChuyenTien.MdiParent = this;
                formChuyenTien.Show();
            }
        }

        private void bbtnKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormTKKH));
            if (form != null)
                form.Activate();
            else
            {
                FormTKKH formTKKH = new FormTKKH();
                formTKKH.MdiParent = this;
                formTKKH.Show();
            }
        }

        private void bbtnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormTaoTaiKhoan));
            if (form != null)
                form.Activate();
            else
            {
                FormTaoTaiKhoan formTaoTaiKhoan = new FormTaoTaiKhoan();
                formTaoTaiKhoan.MdiParent = this;
                formTaoTaiKhoan.Show();
            }
        }

        private void bbtnTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormTKTK));
            if (form != null)
                form.Activate();
            else
            {
                FormTKTK formTKTK = new FormTKTK();
                formTKTK.MdiParent = this;
                formTKTK.Show();
            }
        }

        private void bbtnGD_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormSaokeGD));
            if (form != null)
                form.Activate();
            else
            {
                FormSaokeGD formSaoKeGD = new FormSaokeGD();
                formSaoKeGD.MdiParent = this;
                formSaoKeGD.Show();
            }
        }
    }
}