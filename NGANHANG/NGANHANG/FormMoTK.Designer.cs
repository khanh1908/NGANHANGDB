namespace NGANHANG
{
    partial class FormMoTK
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
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoTK));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemDel = new DevExpress.XtraBars.BarButtonItem();
            this.NGANHANGDataSet = new NGANHANG.NGANHANGDataSet();
            this.TaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaiKhoanTableAdapter = new NGANHANG.NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager();
            this.infoKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoKhachHangTableAdapter = new NGANHANG.NGANHANGDataSetTableAdapters.InfoKhachHangTableAdapter();
            this.pnlCN = new DevExpress.XtraEditors.PanelControl();
            this.cbxChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TaiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlDetail = new DevExpress.XtraEditors.PanelControl();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.cbxCMND = new System.Windows.Forms.ComboBox();
            this.txtMaCN = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            mACNLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCN)).BeginInit();
            this.pnlCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(29, 76);
            mACNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(63, 21);
            mACNLabel.TabIndex = 19;
            mACNLabel.Text = "MACN:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(356, 24);
            hOLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(38, 21);
            hOLabel.TabIndex = 29;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(621, 24);
            tENLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(45, 21);
            tENLabel.TabIndex = 30;
            tENLabel.Text = "TEN:";
            tENLabel.Click += new System.EventHandler(this.tENLabel_Click);
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODTLabel.Location = new System.Drawing.Point(875, 24);
            sODTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(55, 21);
            sODTLabel.TabIndex = 31;
            sODTLabel.Text = "SODT:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(29, 24);
            cMNDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(64, 21);
            cMNDLabel.TabIndex = 28;
            cMNDLabel.Text = "CMND:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnItemAdd,
            this.btnItemEdit,
            this.btnItemDel,
            this.btnItemSave,
            this.btnItemReload,
            this.btnItemUndo,
            this.btnItemExit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnItemSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnItemReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnItemUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnItemExit)});
            this.bar1.Text = "Tools";
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Caption = "Mở tài khoản mới";
            this.btnItemAdd.Enabled = false;
            this.btnItemAdd.Id = 0;
            this.btnItemAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemAdd.ImageOptions.Image")));
            this.btnItemAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemAdd.ImageOptions.LargeImage")));
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemAdd_ItemClick);
            // 
            // btnItemSave
            // 
            this.btnItemSave.Caption = "Ghi";
            this.btnItemSave.Enabled = false;
            this.btnItemSave.Id = 3;
            this.btnItemSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemSave.ImageOptions.Image")));
            this.btnItemSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemSave.ImageOptions.LargeImage")));
            this.btnItemSave.Name = "btnItemSave";
            this.btnItemSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnItemSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemSave_ItemClick);
            // 
            // btnItemReload
            // 
            this.btnItemReload.Caption = "Reload";
            this.btnItemReload.Id = 4;
            this.btnItemReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemReload.ImageOptions.Image")));
            this.btnItemReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemReload.ImageOptions.LargeImage")));
            this.btnItemReload.Name = "btnItemReload";
            this.btnItemReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnItemReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemReload_ItemClick);
            // 
            // btnItemUndo
            // 
            this.btnItemUndo.Caption = "Undo";
            this.btnItemUndo.Enabled = false;
            this.btnItemUndo.Id = 5;
            this.btnItemUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemUndo.ImageOptions.Image")));
            this.btnItemUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemUndo.ImageOptions.LargeImage")));
            this.btnItemUndo.Name = "btnItemUndo";
            this.btnItemUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnItemUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemUndo_ItemClick);
            // 
            // btnItemExit
            // 
            this.btnItemExit.Caption = "Thoát";
            this.btnItemExit.Id = 6;
            this.btnItemExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemExit.ImageOptions.Image")));
            this.btnItemExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemExit.ImageOptions.LargeImage")));
            this.btnItemExit.Name = "btnItemExit";
            this.btnItemExit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnItemExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemExit_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1140, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 582);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1140, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 537);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1140, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 537);
            // 
            // btnItemEdit
            // 
            this.btnItemEdit.Caption = "Sửa";
            this.btnItemEdit.Enabled = false;
            this.btnItemEdit.Id = 1;
            this.btnItemEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemEdit.ImageOptions.Image")));
            this.btnItemEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemEdit.ImageOptions.LargeImage")));
            this.btnItemEdit.Name = "btnItemEdit";
            this.btnItemEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnItemDel
            // 
            this.btnItemDel.Caption = "Xóa";
            this.btnItemDel.Enabled = false;
            this.btnItemDel.Id = 2;
            this.btnItemDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemDel.ImageOptions.Image")));
            this.btnItemDel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemDel.ImageOptions.LargeImage")));
            this.btnItemDel.Name = "btnItemDel";
            this.btnItemDel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // NGANHANGDataSet
            // 
            this.NGANHANGDataSet.DataSetName = "NGANHANGDataSet";
            this.NGANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TaiKhoanBindingSource
            // 
            this.TaiKhoanBindingSource.DataMember = "TaiKhoan";
            this.TaiKhoanBindingSource.DataSource = this.NGANHANGDataSet;
            // 
            // TaiKhoanTableAdapter
            // 
            this.TaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.TaiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // infoKhachHangBindingSource
            // 
            this.infoKhachHangBindingSource.DataMember = "InfoKhachHang";
            this.infoKhachHangBindingSource.DataSource = this.NGANHANGDataSet;
            // 
            // infoKhachHangTableAdapter
            // 
            this.infoKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // pnlCN
            // 
            this.pnlCN.Controls.Add(this.cbxChiNhanh);
            this.pnlCN.Controls.Add(this.label1);
            this.pnlCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCN.Location = new System.Drawing.Point(0, 45);
            this.pnlCN.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCN.Name = "pnlCN";
            this.pnlCN.Size = new System.Drawing.Size(1140, 57);
            this.pnlCN.TabIndex = 13;
            // 
            // cbxChiNhanh
            // 
            this.cbxChiNhanh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChiNhanh.FormattingEnabled = true;
            this.cbxChiNhanh.Location = new System.Drawing.Point(219, 12);
            this.cbxChiNhanh.Name = "cbxChiNhanh";
            this.cbxChiNhanh.Size = new System.Drawing.Size(346, 29);
            this.cbxChiNhanh.TabIndex = 1;
            this.cbxChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbxChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // TaiKhoanGridControl
            // 
            this.TaiKhoanGridControl.DataSource = this.TaiKhoanBindingSource;
            this.TaiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaiKhoanGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.TaiKhoanGridControl.Location = new System.Drawing.Point(0, 102);
            this.TaiKhoanGridControl.MainView = this.gridView1;
            this.TaiKhoanGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.TaiKhoanGridControl.MenuManager = this.barManager1;
            this.TaiKhoanGridControl.Name = "TaiKhoanGridControl";
            this.TaiKhoanGridControl.Size = new System.Drawing.Size(1140, 179);
            this.TaiKhoanGridControl.TabIndex = 13;
            this.TaiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.TaiKhoanGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 19;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 70;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 19;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 70;
            // 
            // colSODU
            // 
            this.colSODU.DisplayFormat.FormatString = "n0";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 19;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 70;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 19;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 70;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNGAYMOTK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 19;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 70;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(sODTLabel);
            this.pnlDetail.Controls.Add(this.txtSDT);
            this.pnlDetail.Controls.Add(tENLabel);
            this.pnlDetail.Controls.Add(this.txtTen);
            this.pnlDetail.Controls.Add(hOLabel);
            this.pnlDetail.Controls.Add(this.txtHo);
            this.pnlDetail.Controls.Add(cMNDLabel);
            this.pnlDetail.Controls.Add(this.cbxCMND);
            this.pnlDetail.Controls.Add(mACNLabel);
            this.pnlDetail.Controls.Add(this.txtMaCN);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Enabled = false;
            this.pnlDetail.Location = new System.Drawing.Point(0, 281);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1140, 301);
            this.pnlDetail.TabIndex = 14;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.infoKhachHangBindingSource, "SODT", true));
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(963, 22);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(108, 28);
            this.txtSDT.TabIndex = 32;
            this.txtSDT.EditValueChanged += new System.EventHandler(this.sODTTextEdit_EditValueChanged);
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.infoKhachHangBindingSource, "TEN", true));
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(690, 22);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(94, 28);
            this.txtTen.TabIndex = 31;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.infoKhachHangBindingSource, "HO", true));
            this.txtHo.Enabled = false;
            this.txtHo.Location = new System.Drawing.Point(416, 22);
            this.txtHo.Margin = new System.Windows.Forms.Padding(2);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Properties.Appearance.Options.UseFont = true;
            this.txtHo.Size = new System.Drawing.Size(175, 28);
            this.txtHo.TabIndex = 30;
            // 
            // cbxCMND
            // 
            this.cbxCMND.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCMND.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCMND.DataSource = this.infoKhachHangBindingSource;
            this.cbxCMND.DisplayMember = "CMND";
            this.cbxCMND.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCMND.FormattingEnabled = true;
            this.cbxCMND.Location = new System.Drawing.Point(117, 22);
            this.cbxCMND.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCMND.Name = "cbxCMND";
            this.cbxCMND.Size = new System.Drawing.Size(156, 29);
            this.cbxCMND.TabIndex = 29;
            this.cbxCMND.ValueMember = "CMND";
            // 
            // txtMaCN
            // 
            this.txtMaCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.TaiKhoanBindingSource, "MACN", true));
            this.txtMaCN.Enabled = false;
            this.txtMaCN.Location = new System.Drawing.Point(117, 73);
            this.txtMaCN.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaCN.MenuManager = this.barManager1;
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCN.Properties.Appearance.Options.UseFont = true;
            this.txtMaCN.Size = new System.Drawing.Size(154, 28);
            this.txtMaCN.TabIndex = 20;
            // 
            // FormMoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 602);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.TaiKhoanGridControl);
            this.Controls.Add(this.pnlCN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMoTK";
            this.Text = "FormMoTK";
            this.Load += new System.EventHandler(this.FormMoTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCN)).EndInit();
            this.pnlCN.ResumeLayout(false);
            this.pnlCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnItemAdd;
        private DevExpress.XtraBars.BarButtonItem btnItemEdit;
        private DevExpress.XtraBars.BarButtonItem btnItemDel;
        private DevExpress.XtraBars.BarButtonItem btnItemSave;
        private DevExpress.XtraBars.BarButtonItem btnItemReload;
        private DevExpress.XtraBars.BarButtonItem btnItemUndo;
        private DevExpress.XtraBars.BarButtonItem btnItemExit;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource TaiKhoanBindingSource;
        private NGANHANGDataSet NGANHANGDataSet;
        private NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter TaiKhoanTableAdapter;
        private NGANHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource infoKhachHangBindingSource;
        private NGANHANGDataSetTableAdapters.InfoKhachHangTableAdapter infoKhachHangTableAdapter;
        private DevExpress.XtraEditors.PanelControl pnlCN;
        private System.Windows.Forms.ComboBox cbxChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl TaiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl pnlDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DevExpress.XtraEditors.TextEdit txtMaCN;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private System.Windows.Forms.ComboBox cbxCMND;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}