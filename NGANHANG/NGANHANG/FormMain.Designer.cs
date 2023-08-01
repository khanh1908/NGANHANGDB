namespace NGANHANG
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnQLNV = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnQLKH = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnQLTK = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnGuiRut = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnGD = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTK = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnKH = new DevExpress.XtraBars.BarButtonItem();
            this.rbpHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpNV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpKH = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpTK = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssttMANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssttHOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssttNHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(89);
            // 
            // 
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.bbtnDangNhap,
            this.bbtnTaoTaiKhoan,
            this.barButtonItem1,
            this.bbtnQLNV,
            this.bbtnQLKH,
            this.bbtnQLTK,
            this.bbtnGuiRut,
            this.bbtnChuyenTien,
            this.bbtnGD,
            this.bbtnTK,
            this.bbtnKH});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 1006;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpHome,
            this.rbpNV,
            this.rbpKH,
            this.rbpTK});
            this.ribbon.Size = new System.Drawing.Size(1361, 200);
            // 
            // bbtnDangNhap
            // 
            this.bbtnDangNhap.Caption = "Đăng nhập";
            this.bbtnDangNhap.Id = 1;
            this.bbtnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnDangNhap.ImageOptions.Image")));
            this.bbtnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnDangNhap.ImageOptions.LargeImage")));
            this.bbtnDangNhap.Name = "bbtnDangNhap";
            this.bbtnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDangNhap_ItemClick);
            // 
            // bbtnTaoTaiKhoan
            // 
            this.bbtnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.bbtnTaoTaiKhoan.Enabled = false;
            this.bbtnTaoTaiKhoan.Id = 2;
            this.bbtnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnTaoTaiKhoan.ImageOptions.Image")));
            this.bbtnTaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnTaoTaiKhoan.ImageOptions.LargeImage")));
            this.bbtnTaoTaiKhoan.Name = "bbtnTaoTaiKhoan";
            this.bbtnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnTaoTaiKhoan_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thoát";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bbtnQLNV
            // 
            this.bbtnQLNV.Caption = "Quản lý nhân viên";
            this.bbtnQLNV.Id = 7;
            this.bbtnQLNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnQLNV.ImageOptions.Image")));
            this.bbtnQLNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnQLNV.ImageOptions.LargeImage")));
            this.bbtnQLNV.Name = "bbtnQLNV";
            this.bbtnQLNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnQLNV_ItemClick);
            // 
            // bbtnQLKH
            // 
            this.bbtnQLKH.Caption = "Quản lý khách hàng";
            this.bbtnQLKH.Id = 8;
            this.bbtnQLKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnQLKH.ImageOptions.Image")));
            this.bbtnQLKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnQLKH.ImageOptions.LargeImage")));
            this.bbtnQLKH.Name = "bbtnQLKH";
            this.bbtnQLKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnQLKH_ItemClick);
            // 
            // bbtnQLTK
            // 
            this.bbtnQLTK.Caption = "Quản lý tài khoản";
            this.bbtnQLTK.Id = 9;
            this.bbtnQLTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnQLTK.ImageOptions.Image")));
            this.bbtnQLTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnQLTK.ImageOptions.LargeImage")));
            this.bbtnQLTK.Name = "bbtnQLTK";
            this.bbtnQLTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnMoTK_ItemClick);
            // 
            // bbtnGuiRut
            // 
            this.bbtnGuiRut.Caption = "Thực hiện gửi rút";
            this.bbtnGuiRut.Id = 10;
            this.bbtnGuiRut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnGuiRut.ImageOptions.Image")));
            this.bbtnGuiRut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnGuiRut.ImageOptions.LargeImage")));
            this.bbtnGuiRut.Name = "bbtnGuiRut";
            this.bbtnGuiRut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnGuiRut_ItemClick);
            // 
            // bbtnChuyenTien
            // 
            this.bbtnChuyenTien.Caption = "Thực hiện chuyển tiền";
            this.bbtnChuyenTien.Id = 11;
            this.bbtnChuyenTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnChuyenTien.ImageOptions.Image")));
            this.bbtnChuyenTien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnChuyenTien.ImageOptions.LargeImage")));
            this.bbtnChuyenTien.Name = "bbtnChuyenTien";
            this.bbtnChuyenTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnChuyenTien_ItemClick);
            // 
            // bbtnGD
            // 
            this.bbtnGD.Caption = "Sao kê giao dịch";
            this.bbtnGD.Id = 12;
            this.bbtnGD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnGD.ImageOptions.Image")));
            this.bbtnGD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnGD.ImageOptions.LargeImage")));
            this.bbtnGD.Name = "bbtnGD";
            this.bbtnGD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnGD_ItemClick);
            // 
            // bbtnTK
            // 
            this.bbtnTK.Caption = "Liệt kê tài khoản";
            this.bbtnTK.Id = 13;
            this.bbtnTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnTK.ImageOptions.Image")));
            this.bbtnTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnTK.ImageOptions.LargeImage")));
            this.bbtnTK.Name = "bbtnTK";
            this.bbtnTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnTK_ItemClick);
            // 
            // bbtnKH
            // 
            this.bbtnKH.Caption = "Liệt kê khách hàng";
            this.bbtnKH.Id = 14;
            this.bbtnKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnKH.ImageOptions.Image")));
            this.bbtnKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnKH.ImageOptions.LargeImage")));
            this.bbtnKH.Name = "bbtnKH";
            this.bbtnKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnKH_ItemClick);
            // 
            // rbpHome
            // 
            this.rbpHome.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpHome.Appearance.Options.UseFont = true;
            this.rbpHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbpHome.Name = "rbpHome";
            this.rbpHome.Text = "Trang chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbpNV
            // 
            this.rbpNV.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpNV.Appearance.Options.UseFont = true;
            this.rbpNV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbpNV.Name = "rbpNV";
            this.rbpNV.Text = "Nhân viên";
            this.rbpNV.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rbpKH
            // 
            this.rbpKH.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpKH.Appearance.Options.UseFont = true;
            this.rbpKH.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpKH.Name = "rbpKH";
            this.rbpKH.Text = "Khách hàng";
            this.rbpKH.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // rbpTK
            // 
            this.rbpTK.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpTK.Appearance.Options.UseFont = true;
            this.rbpTK.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbpTK.Name = "rbpTK";
            this.rbpTK.Text = "Thống kê";
            this.rbpTK.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssttMANV,
            this.ssttHOTEN,
            this.ssttNHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 811);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1361, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssttMANV
            // 
            this.ssttMANV.Name = "ssttMANV";
            this.ssttMANV.Size = new System.Drawing.Size(52, 20);
            this.ssttMANV.Text = "MANV";
            // 
            // ssttHOTEN
            // 
            this.ssttHOTEN.Name = "ssttHOTEN";
            this.ssttHOTEN.Size = new System.Drawing.Size(57, 20);
            this.ssttHOTEN.Text = "HOTEN";
            // 
            // ssttNHOM
            // 
            this.ssttNHOM.Name = "ssttNHOM";
            this.ssttNHOM.Size = new System.Drawing.Size(55, 20);
            this.ssttNHOM.Text = "NHOM";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 837);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbtnDangNhap;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        public System.Windows.Forms.ToolStripStatusLabel ssttMANV;
        public System.Windows.Forms.ToolStripStatusLabel ssttHOTEN;
        public System.Windows.Forms.ToolStripStatusLabel ssttNHOM;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public DevExpress.XtraBars.BarButtonItem bbtnTaoTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbpNV;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbpKH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbpTK;
        private DevExpress.XtraBars.BarButtonItem bbtnQLNV;
        private DevExpress.XtraBars.BarButtonItem bbtnQLKH;
        private DevExpress.XtraBars.BarButtonItem bbtnQLTK;
        private DevExpress.XtraBars.BarButtonItem bbtnGuiRut;
        private DevExpress.XtraBars.BarButtonItem bbtnChuyenTien;
        private DevExpress.XtraBars.BarButtonItem bbtnGD;
        private DevExpress.XtraBars.BarButtonItem bbtnTK;
        private DevExpress.XtraBars.BarButtonItem bbtnKH;
    }
}