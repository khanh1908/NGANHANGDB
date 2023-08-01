namespace NGANHANG
{
    partial class FormGuiRut
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
            System.Windows.Forms.Label lOAIGDLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuiRut));
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
            this.GD_GOIRUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GD_GOIRUTTableAdapter = new NGANHANG.NGANHANGDataSetTableAdapters.GD_GOIRUTTableAdapter();
            this.tableAdapterManager = new NGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager();
            this.pnlCN = new DevExpress.XtraEditors.PanelControl();
            this.cbxChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gD_GOIRUTGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlDetail = new DevExpress.XtraEditors.PanelControl();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.TaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.cbxLoaiGD = new System.Windows.Forms.ComboBox();
            this.cbxSoTK = new System.Windows.Forms.ComboBox();
            this.TaiKhoanTableAdapter = new NGANHANG.NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter();
            lOAIGDLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GD_GOIRUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCN)).BeginInit();
            this.pnlCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lOAIGDLabel
            // 
            lOAIGDLabel.AutoSize = true;
            lOAIGDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lOAIGDLabel.Location = new System.Drawing.Point(926, 36);
            lOAIGDLabel.Name = "lOAIGDLabel";
            lOAIGDLabel.Size = new System.Drawing.Size(73, 21);
            lOAIGDLabel.TabIndex = 2;
            lOAIGDLabel.Text = "LOAIGD:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTIENLabel.Location = new System.Drawing.Point(58, 111);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(70, 21);
            sOTIENLabel.TabIndex = 4;
            sOTIENLabel.Text = "SOTIEN:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(521, 111);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(64, 21);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(521, 36);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(64, 21);
            cMNDLabel.TabIndex = 8;
            cMNDLabel.Text = "CMND:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(58, 36);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(53, 21);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "SOTK:";
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
            this.btnItemAdd.Caption = "Thực hiện giao dịch";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1500, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 701);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1500, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 656);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1500, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 656);
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
            // GD_GOIRUTBindingSource
            // 
            this.GD_GOIRUTBindingSource.DataMember = "GD_GOIRUT";
            this.GD_GOIRUTBindingSource.DataSource = this.NGANHANGDataSet;
            // 
            // GD_GOIRUTTableAdapter
            // 
            this.GD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.GD_GOIRUTTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pnlCN
            // 
            this.pnlCN.Controls.Add(this.cbxChiNhanh);
            this.pnlCN.Controls.Add(this.label1);
            this.pnlCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCN.Location = new System.Drawing.Point(0, 45);
            this.pnlCN.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCN.Name = "pnlCN";
            this.pnlCN.Size = new System.Drawing.Size(1500, 70);
            this.pnlCN.TabIndex = 6;
            // 
            // cbxChiNhanh
            // 
            this.cbxChiNhanh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChiNhanh.FormattingEnabled = true;
            this.cbxChiNhanh.Location = new System.Drawing.Point(292, 15);
            this.cbxChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cbxChiNhanh.Name = "cbxChiNhanh";
            this.cbxChiNhanh.Size = new System.Drawing.Size(460, 29);
            this.cbxChiNhanh.TabIndex = 1;
            this.cbxChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbxChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // gD_GOIRUTGridControl
            // 
            this.gD_GOIRUTGridControl.DataSource = this.GD_GOIRUTBindingSource;
            this.gD_GOIRUTGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gD_GOIRUTGridControl.Location = new System.Drawing.Point(0, 115);
            this.gD_GOIRUTGridControl.MainView = this.gridView1;
            this.gD_GOIRUTGridControl.MenuManager = this.barManager1;
            this.gD_GOIRUTGridControl.Name = "gD_GOIRUTGridControl";
            this.gD_GOIRUTGridControl.Size = new System.Drawing.Size(1500, 220);
            this.gD_GOIRUTGridControl.TabIndex = 6;
            this.gD_GOIRUTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK,
            this.colLOAIGD,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colMANV});
            this.gridView1.GridControl = this.gD_GOIRUTGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGD
            // 
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.MinWidth = 25;
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            this.colMAGD.Width = 94;
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 1;
            this.colSOTK.Width = 94;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.MinWidth = 25;
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 2;
            this.colLOAIGD.Width = 94;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNGAYGD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 25;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 3;
            this.colNGAYGD.Width = 94;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.DisplayFormat.FormatString = "n0";
            this.colSOTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 25;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 4;
            this.colSOTIEN.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            this.colMANV.Width = 94;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(cMNDLabel);
            this.pnlDetail.Controls.Add(this.txtCMND);
            this.pnlDetail.Controls.Add(mANVLabel);
            this.pnlDetail.Controls.Add(this.txtMaNV);
            this.pnlDetail.Controls.Add(sOTIENLabel);
            this.pnlDetail.Controls.Add(this.txtSoTien);
            this.pnlDetail.Controls.Add(lOAIGDLabel);
            this.pnlDetail.Controls.Add(this.cbxLoaiGD);
            this.pnlDetail.Controls.Add(sOTKLabel);
            this.pnlDetail.Controls.Add(this.cbxSoTK);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Enabled = false;
            this.pnlDetail.Location = new System.Drawing.Point(0, 335);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1500, 366);
            this.pnlDetail.TabIndex = 7;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.TaiKhoanBindingSource, "CMND", true));
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(666, 33);
            this.txtCMND.MenuManager = this.barManager1;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Properties.Appearance.Options.UseFont = true;
            this.txtCMND.Size = new System.Drawing.Size(157, 28);
            this.txtCMND.TabIndex = 9;
            // 
            // TaiKhoanBindingSource
            // 
            this.TaiKhoanBindingSource.DataMember = "TaiKhoan";
            this.TaiKhoanBindingSource.DataSource = this.NGANHANGDataSet;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.TaiKhoanBindingSource, "SOTK", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(666, 108);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(201, 28);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtSoTien
            // 
            this.txtSoTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.GD_GOIRUTBindingSource, "SOTIEN", true));
            this.txtSoTien.Location = new System.Drawing.Point(170, 108);
            this.txtSoTien.MenuManager = this.barManager1;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Properties.Appearance.Options.UseFont = true;
            this.txtSoTien.Properties.DisplayFormat.FormatString = "n0";
            this.txtSoTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTien.Properties.EditFormat.FormatString = "n0";
            this.txtSoTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTien.Size = new System.Drawing.Size(203, 28);
            this.txtSoTien.TabIndex = 5;
            // 
            // cbxLoaiGD
            // 
            this.cbxLoaiGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoaiGD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoaiGD.FormattingEnabled = true;
            this.cbxLoaiGD.Items.AddRange(new object[] {
            "GT",
            "RT"});
            this.cbxLoaiGD.Location = new System.Drawing.Point(1071, 33);
            this.cbxLoaiGD.Name = "cbxLoaiGD";
            this.cbxLoaiGD.Size = new System.Drawing.Size(121, 29);
            this.cbxLoaiGD.TabIndex = 3;
            // 
            // cbxSoTK
            // 
            this.cbxSoTK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSoTK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSoTK.DataSource = this.TaiKhoanBindingSource;
            this.cbxSoTK.DisplayMember = "SOTK";
            this.cbxSoTK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSoTK.FormattingEnabled = true;
            this.cbxSoTK.Location = new System.Drawing.Point(170, 33);
            this.cbxSoTK.Name = "cbxSoTK";
            this.cbxSoTK.Size = new System.Drawing.Size(203, 29);
            this.cbxSoTK.TabIndex = 1;
            this.cbxSoTK.ValueMember = "SOTK";
            // 
            // TaiKhoanTableAdapter
            // 
            this.TaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // FormGuiRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 721);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.gD_GOIRUTGridControl);
            this.Controls.Add(this.pnlCN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGuiRut";
            this.Text = "FormGuiRut";
            this.Load += new System.EventHandler(this.FormGuiRut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GD_GOIRUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCN)).EndInit();
            this.pnlCN.ResumeLayout(false);
            this.pnlCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource GD_GOIRUTBindingSource;
        private NGANHANGDataSet NGANHANGDataSet;
        private NGANHANGDataSetTableAdapters.GD_GOIRUTTableAdapter GD_GOIRUTTableAdapter;
        private NGANHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl pnlCN;
        private System.Windows.Forms.ComboBox cbxChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl pnlDetail;
        private DevExpress.XtraGrid.GridControl gD_GOIRUTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.ComboBox cbxLoaiGD;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.BindingSource TaiKhoanBindingSource;
        private NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter TaiKhoanTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private System.Windows.Forms.ComboBox cbxSoTK;
    }
}