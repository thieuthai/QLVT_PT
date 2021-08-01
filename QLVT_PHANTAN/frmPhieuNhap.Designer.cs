namespace QLVT_PHANTAN
{
    partial class frmPhieuNhap
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAPNLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_phuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qLVTDataSet = new QLVT_PHANTAN.QLVTDataSet();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT_PHANTAN.QLVTDataSetTableAdapters.TableAdapterManager();
            this.cTPNTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.CTPNTableAdapter();
            this.phieuNhapGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbPN = new System.Windows.Forms.GroupBox();
            this.nhanvien1ComboBox = new System.Windows.Forms.ComboBox();
            this.nhanvien1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kho1ComboBox = new System.Windows.Forms.ComboBox();
            this.kho1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHang1ComboBox = new System.Windows.Forms.ComboBox();
            this.datHang1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbx_makho = new DevExpress.XtraEditors.TextEdit();
            this.tbx_manv = new DevExpress.XtraEditors.SpinEdit();
            this.tbx_masoddh = new DevExpress.XtraEditors.TextEdit();
            this.tbx_ngay = new DevExpress.XtraEditors.DateEdit();
            this.tbx_mapn = new DevExpress.XtraEditors.TextEdit();
            this.grbCTPN = new System.Windows.Forms.GroupBox();
            this.cmb_mavt = new System.Windows.Forms.ComboBox();
            this.sP_LayMaVT_CTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbx_dg_ct = new DevExpress.XtraEditors.SpinEdit();
            this.tbx_sl_ct = new DevExpress.XtraEditors.SpinEdit();
            this.tbx_mavt_ct = new DevExpress.XtraEditors.TextEdit();
            this.tbx_mapn_ct = new DevExpress.XtraEditors.TextEdit();
            this.datHang1TableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.DatHang1TableAdapter();
            this.kho1TableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.Kho1TableAdapter();
            this.nhanvien1TableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.Nhanvien1TableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.sp_DanhsachChinhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_DanhsachChinhanhTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter();
            this.ThemCTPN = new System.Windows.Forms.Button();
            this.XoaCTPN = new System.Windows.Forms.Button();
            this.GhiCTPN = new System.Windows.Forms.Button();
            this.UndoCTPN = new System.Windows.Forms.Button();
            this.sP_LayMaVT_CTDDHTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.SP_LayMaVT_CTDDHTableAdapter();
            this.sP_LayDonGia_CTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LayDonGia_CTDDHTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.SP_LayDonGia_CTDDHTableAdapter();
            this.sP_LaySoLuong_CTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LaySoLuong_CTDDHTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.SP_LaySoLuong_CTDDHTableAdapter();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.btn_refresh = new DevExpress.XtraBars.BarButtonItem();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAPNLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNDataGridView)).BeginInit();
            this.grbPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kho1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHang1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_makho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_manv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_masoddh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_mapn.Properties)).BeginInit();
            this.grbCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LayMaVT_CTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_dg_ct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_sl_ct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_mavt_ct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_mapn_ct.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LayDonGia_CTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LaySoLuong_CTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(8, 37);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(41, 13);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "MAPN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(8, 79);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(40, 13);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(6, 118);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(63, 13);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(6, 158);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(41, 13);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(6, 199);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(49, 13);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // mAPNLabel1
            // 
            mAPNLabel1.AutoSize = true;
            mAPNLabel1.Location = new System.Drawing.Point(19, 50);
            mAPNLabel1.Name = "mAPNLabel1";
            mAPNLabel1.Size = new System.Drawing.Size(41, 13);
            mAPNLabel1.TabIndex = 0;
            mAPNLabel1.Text = "MAPN:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(19, 92);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(19, 131);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(19, 172);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(52, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_them,
            this.btn_xoa,
            this.btn_ghi,
            this.btn_phuchoi,
            this.btn_thoat,
            this.btn_refresh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_ghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_phuchoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_thoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_refresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_them
            // 
            this.btn_them.Caption = "Thêm";
            this.btn_them.Id = 0;
            this.btn_them.ImageOptions.ImageUri.Uri = "Add";
            this.btn_them.Name = "btn_them";
            this.btn_them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_them_ItemClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Caption = "Xóa";
            this.btn_xoa.Id = 1;
            this.btn_xoa.ImageOptions.ImageUri.Uri = "DeleteDataSource";
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_xoa_ItemClick);
            // 
            // btn_ghi
            // 
            this.btn_ghi.Caption = "Ghi";
            this.btn_ghi.Id = 2;
            this.btn_ghi.ImageOptions.ImageUri.Uri = "Save";
            this.btn_ghi.Name = "btn_ghi";
            this.btn_ghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ghi_ItemClick);
            // 
            // btn_phuchoi
            // 
            this.btn_phuchoi.Caption = "Phục hồi";
            this.btn_phuchoi.Id = 3;
            this.btn_phuchoi.ImageOptions.ImageUri.Uri = "Reset";
            this.btn_phuchoi.Name = "btn_phuchoi";
            this.btn_phuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_phuchoi_ItemClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Caption = "Thoát";
            this.btn_thoat.Id = 4;
            this.btn_thoat.ImageOptions.ImageUri.Uri = "Cancel";
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_thoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1170, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 526);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1170, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 502);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1170, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 502);
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.EnforceConstraints = false;
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.qLVTDataSet;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanh1TableAdapter = null;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHang1TableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.Kho1TableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.Nhanvien1TableAdapter = null;
            this.tableAdapterManager.NhanvienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PHANTAN.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vattu1TableAdapter = null;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapGridControl
            // 
            this.phieuNhapGridControl.DataSource = this.phieuNhapBindingSource;
            this.phieuNhapGridControl.Location = new System.Drawing.Point(13, 30);
            this.phieuNhapGridControl.MainView = this.gridView1;
            this.phieuNhapGridControl.MenuManager = this.barManager1;
            this.phieuNhapGridControl.Name = "phieuNhapGridControl";
            this.phieuNhapGridControl.Size = new System.Drawing.Size(826, 220);
            this.phieuNhapGridControl.TabIndex = 5;
            this.phieuNhapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.phieuNhapGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // cTPNBindingSource
            // 
            this.cTPNBindingSource.DataMember = "FK_CTPN_PhieuNhap";
            this.cTPNBindingSource.DataSource = this.phieuNhapBindingSource;
            // 
            // cTPNDataGridView
            // 
            this.cTPNDataGridView.AutoGenerateColumns = false;
            this.cTPNDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cTPNDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cTPNDataGridView.DataSource = this.cTPNBindingSource;
            this.cTPNDataGridView.Location = new System.Drawing.Point(342, 286);
            this.cTPNDataGridView.Name = "cTPNDataGridView";
            this.cTPNDataGridView.Size = new System.Drawing.Size(365, 220);
            this.cTPNDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPN";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAPN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn3.HeaderText = "SOLUONG";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "DONGIA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // grbPN
            // 
            this.grbPN.Controls.Add(this.nhanvien1ComboBox);
            this.grbPN.Controls.Add(this.kho1ComboBox);
            this.grbPN.Controls.Add(this.datHang1ComboBox);
            this.grbPN.Controls.Add(mAKHOLabel);
            this.grbPN.Controls.Add(this.tbx_makho);
            this.grbPN.Controls.Add(mANVLabel);
            this.grbPN.Controls.Add(this.tbx_manv);
            this.grbPN.Controls.Add(masoDDHLabel);
            this.grbPN.Controls.Add(this.tbx_masoddh);
            this.grbPN.Controls.Add(nGAYLabel);
            this.grbPN.Controls.Add(this.tbx_ngay);
            this.grbPN.Controls.Add(mAPNLabel);
            this.grbPN.Controls.Add(this.tbx_mapn);
            this.grbPN.Location = new System.Drawing.Point(13, 278);
            this.grbPN.Name = "grbPN";
            this.grbPN.Size = new System.Drawing.Size(323, 227);
            this.grbPN.TabIndex = 6;
            this.grbPN.TabStop = false;
            this.grbPN.Text = "Phiếu Nhập";
            // 
            // nhanvien1ComboBox
            // 
            this.nhanvien1ComboBox.DataSource = this.nhanvien1BindingSource;
            this.nhanvien1ComboBox.DisplayMember = "HOTEN";
            this.nhanvien1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nhanvien1ComboBox.FormattingEnabled = true;
            this.nhanvien1ComboBox.Location = new System.Drawing.Point(78, 150);
            this.nhanvien1ComboBox.Name = "nhanvien1ComboBox";
            this.nhanvien1ComboBox.Size = new System.Drawing.Size(179, 21);
            this.nhanvien1ComboBox.TabIndex = 12;
            this.nhanvien1ComboBox.ValueMember = "MANV";
            this.nhanvien1ComboBox.SelectedIndexChanged += new System.EventHandler(this.nhanvien1ComboBox_SelectedIndexChanged);
            // 
            // nhanvien1BindingSource
            // 
            this.nhanvien1BindingSource.DataMember = "Nhanvien1";
            this.nhanvien1BindingSource.DataSource = this.qLVTDataSet;
            // 
            // kho1ComboBox
            // 
            this.kho1ComboBox.DataSource = this.kho1BindingSource;
            this.kho1ComboBox.DisplayMember = "TENKHO";
            this.kho1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kho1ComboBox.FormattingEnabled = true;
            this.kho1ComboBox.Location = new System.Drawing.Point(78, 192);
            this.kho1ComboBox.Name = "kho1ComboBox";
            this.kho1ComboBox.Size = new System.Drawing.Size(179, 21);
            this.kho1ComboBox.TabIndex = 11;
            this.kho1ComboBox.ValueMember = "MAKHO";
            this.kho1ComboBox.SelectedIndexChanged += new System.EventHandler(this.kho1ComboBox_SelectedIndexChanged);
            // 
            // kho1BindingSource
            // 
            this.kho1BindingSource.DataMember = "Kho1";
            this.kho1BindingSource.DataSource = this.qLVTDataSet;
            // 
            // datHang1ComboBox
            // 
            this.datHang1ComboBox.DataSource = this.datHang1BindingSource;
            this.datHang1ComboBox.DisplayMember = "MasoDDH";
            this.datHang1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datHang1ComboBox.FormattingEnabled = true;
            this.datHang1ComboBox.Location = new System.Drawing.Point(78, 110);
            this.datHang1ComboBox.Name = "datHang1ComboBox";
            this.datHang1ComboBox.Size = new System.Drawing.Size(179, 21);
            this.datHang1ComboBox.TabIndex = 10;
            this.datHang1ComboBox.ValueMember = "MasoDDH";
            this.datHang1ComboBox.SelectedIndexChanged += new System.EventHandler(this.datHang1ComboBox_SelectedIndexChanged);
            // 
            // datHang1BindingSource
            // 
            this.datHang1BindingSource.DataMember = "DatHang1";
            this.datHang1BindingSource.DataSource = this.qLVTDataSet;
            // 
            // tbx_makho
            // 
            this.tbx_makho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MAKHO", true));
            this.tbx_makho.Location = new System.Drawing.Point(78, 192);
            this.tbx_makho.MenuManager = this.barManager1;
            this.tbx_makho.Name = "tbx_makho";
            this.tbx_makho.Size = new System.Drawing.Size(100, 20);
            this.tbx_makho.TabIndex = 9;
            this.tbx_makho.TextChanged += new System.EventHandler(this.tbx_makho_TextChanged);
            // 
            // tbx_manv
            // 
            this.tbx_manv.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MANV", true));
            this.tbx_manv.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbx_manv.Location = new System.Drawing.Point(78, 151);
            this.tbx_manv.MenuManager = this.barManager1;
            this.tbx_manv.Name = "tbx_manv";
            this.tbx_manv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbx_manv.Size = new System.Drawing.Size(100, 20);
            this.tbx_manv.TabIndex = 7;
            this.tbx_manv.TextChanged += new System.EventHandler(this.tbx_manv_TextChanged);
            // 
            // tbx_masoddh
            // 
            this.tbx_masoddh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MasoDDH", true));
            this.tbx_masoddh.Location = new System.Drawing.Point(78, 111);
            this.tbx_masoddh.MenuManager = this.barManager1;
            this.tbx_masoddh.Name = "tbx_masoddh";
            this.tbx_masoddh.Size = new System.Drawing.Size(100, 20);
            this.tbx_masoddh.TabIndex = 5;
            this.tbx_masoddh.TextChanged += new System.EventHandler(this.tbx_masoddh_TextChanged);
            // 
            // tbx_ngay
            // 
            this.tbx_ngay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "NGAY", true));
            this.tbx_ngay.EditValue = null;
            this.tbx_ngay.Location = new System.Drawing.Point(78, 72);
            this.tbx_ngay.MenuManager = this.barManager1;
            this.tbx_ngay.Name = "tbx_ngay";
            this.tbx_ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbx_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbx_ngay.Size = new System.Drawing.Size(179, 20);
            this.tbx_ngay.TabIndex = 3;
            // 
            // tbx_mapn
            // 
            this.tbx_mapn.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MAPN", true));
            this.tbx_mapn.Location = new System.Drawing.Point(78, 30);
            this.tbx_mapn.MenuManager = this.barManager1;
            this.tbx_mapn.Name = "tbx_mapn";
            this.tbx_mapn.Properties.MaxLength = 8;
            this.tbx_mapn.Size = new System.Drawing.Size(179, 20);
            this.tbx_mapn.TabIndex = 1;
            // 
            // grbCTPN
            // 
            this.grbCTPN.Controls.Add(this.textEdit2);
            this.grbCTPN.Controls.Add(this.textEdit1);
            this.grbCTPN.Controls.Add(this.cmb_mavt);
            this.grbCTPN.Controls.Add(dONGIALabel);
            this.grbCTPN.Controls.Add(this.tbx_dg_ct);
            this.grbCTPN.Controls.Add(sOLUONGLabel);
            this.grbCTPN.Controls.Add(this.tbx_sl_ct);
            this.grbCTPN.Controls.Add(mAVTLabel);
            this.grbCTPN.Controls.Add(this.tbx_mavt_ct);
            this.grbCTPN.Controls.Add(mAPNLabel1);
            this.grbCTPN.Controls.Add(this.tbx_mapn_ct);
            this.grbCTPN.Location = new System.Drawing.Point(713, 278);
            this.grbCTPN.Name = "grbCTPN";
            this.grbCTPN.Size = new System.Drawing.Size(356, 228);
            this.grbCTPN.TabIndex = 7;
            this.grbCTPN.TabStop = false;
            this.grbCTPN.Text = "Chi tiết Phiếu Nhập";
            // 
            // cmb_mavt
            // 
            this.cmb_mavt.DataSource = this.sP_LayMaVT_CTDDHBindingSource;
            this.cmb_mavt.DisplayMember = "TENVT";
            this.cmb_mavt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mavt.FormattingEnabled = true;
            this.cmb_mavt.Location = new System.Drawing.Point(90, 84);
            this.cmb_mavt.Name = "cmb_mavt";
            this.cmb_mavt.Size = new System.Drawing.Size(151, 21);
            this.cmb_mavt.TabIndex = 8;
            this.cmb_mavt.ValueMember = "MAVT";
            this.cmb_mavt.SelectedIndexChanged += new System.EventHandler(this.cmb_mavt_SelectedIndexChanged);
            // 
            // sP_LayMaVT_CTDDHBindingSource
            // 
            this.sP_LayMaVT_CTDDHBindingSource.DataMember = "SP_LayMaVT_CTDDH";
            this.sP_LayMaVT_CTDDHBindingSource.DataSource = this.qLVTDataSet;
            // 
            // tbx_dg_ct
            // 
            this.tbx_dg_ct.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "DONGIA", true));
            this.tbx_dg_ct.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbx_dg_ct.Location = new System.Drawing.Point(90, 169);
            this.tbx_dg_ct.MenuManager = this.barManager1;
            this.tbx_dg_ct.Name = "tbx_dg_ct";
            this.tbx_dg_ct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbx_dg_ct.Size = new System.Drawing.Size(151, 20);
            this.tbx_dg_ct.TabIndex = 7;
            this.tbx_dg_ct.TextChanged += new System.EventHandler(this.tbx_dg_ct_TextChanged);
            // 
            // tbx_sl_ct
            // 
            this.tbx_sl_ct.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "SOLUONG", true));
            this.tbx_sl_ct.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbx_sl_ct.Location = new System.Drawing.Point(90, 124);
            this.tbx_sl_ct.MenuManager = this.barManager1;
            this.tbx_sl_ct.Name = "tbx_sl_ct";
            this.tbx_sl_ct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbx_sl_ct.Size = new System.Drawing.Size(100, 20);
            this.tbx_sl_ct.TabIndex = 5;
            this.tbx_sl_ct.TextChanged += new System.EventHandler(this.tbx_sl_ct_TextChanged);
            // 
            // tbx_mavt_ct
            // 
            this.tbx_mavt_ct.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "MAVT", true));
            this.tbx_mavt_ct.Location = new System.Drawing.Point(247, 85);
            this.tbx_mavt_ct.MenuManager = this.barManager1;
            this.tbx_mavt_ct.Name = "tbx_mavt_ct";
            this.tbx_mavt_ct.Properties.ReadOnly = true;
            this.tbx_mavt_ct.Size = new System.Drawing.Size(100, 20);
            this.tbx_mavt_ct.TabIndex = 3;
            this.tbx_mavt_ct.TextChanged += new System.EventHandler(this.tbx_mavt_ct_TextChanged);
            // 
            // tbx_mapn_ct
            // 
            this.tbx_mapn_ct.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "MAPN", true));
            this.tbx_mapn_ct.Enabled = false;
            this.tbx_mapn_ct.Location = new System.Drawing.Point(90, 43);
            this.tbx_mapn_ct.MenuManager = this.barManager1;
            this.tbx_mapn_ct.Name = "tbx_mapn_ct";
            this.tbx_mapn_ct.Size = new System.Drawing.Size(100, 20);
            this.tbx_mapn_ct.TabIndex = 1;
            // 
            // datHang1TableAdapter
            // 
            this.datHang1TableAdapter.ClearBeforeFill = true;
            // 
            // kho1TableAdapter
            // 
            this.kho1TableAdapter.ClearBeforeFill = true;
            // 
            // nhanvien1TableAdapter
            // 
            this.nhanvien1TableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbChiNhanh);
            this.groupBox2.Location = new System.Drawing.Point(860, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 206);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Nhánh";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DataSource = this.sp_DanhsachChinhanhBindingSource;
            this.cmbChiNhanh.DisplayMember = "description";
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(24, 83);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(241, 21);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.ValueMember = "subscriber_server";
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // sp_DanhsachChinhanhBindingSource
            // 
            this.sp_DanhsachChinhanhBindingSource.DataMember = "sp_DanhsachChinhanh";
            this.sp_DanhsachChinhanhBindingSource.DataSource = this.qLVTDataSet;
            // 
            // sp_DanhsachChinhanhTableAdapter
            // 
            this.sp_DanhsachChinhanhTableAdapter.ClearBeforeFill = true;
            // 
            // ThemCTPN
            // 
            this.ThemCTPN.Location = new System.Drawing.Point(1075, 318);
            this.ThemCTPN.Name = "ThemCTPN";
            this.ThemCTPN.Size = new System.Drawing.Size(75, 23);
            this.ThemCTPN.TabIndex = 13;
            this.ThemCTPN.Text = "Thêm CTPN";
            this.ThemCTPN.UseVisualStyleBackColor = true;
            this.ThemCTPN.Click += new System.EventHandler(this.ThemCTPN_Click);
            // 
            // XoaCTPN
            // 
            this.XoaCTPN.Location = new System.Drawing.Point(1075, 365);
            this.XoaCTPN.Name = "XoaCTPN";
            this.XoaCTPN.Size = new System.Drawing.Size(75, 23);
            this.XoaCTPN.TabIndex = 14;
            this.XoaCTPN.Text = "Xóa CTPN";
            this.XoaCTPN.UseVisualStyleBackColor = true;
            this.XoaCTPN.Click += new System.EventHandler(this.XoaCTPN_Click);
            // 
            // GhiCTPN
            // 
            this.GhiCTPN.Location = new System.Drawing.Point(1075, 405);
            this.GhiCTPN.Name = "GhiCTPN";
            this.GhiCTPN.Size = new System.Drawing.Size(75, 23);
            this.GhiCTPN.TabIndex = 15;
            this.GhiCTPN.Text = "Ghi CTPN";
            this.GhiCTPN.UseVisualStyleBackColor = true;
            this.GhiCTPN.Click += new System.EventHandler(this.GhiCTPN_Click);
            // 
            // UndoCTPN
            // 
            this.UndoCTPN.Location = new System.Drawing.Point(1075, 446);
            this.UndoCTPN.Name = "UndoCTPN";
            this.UndoCTPN.Size = new System.Drawing.Size(75, 23);
            this.UndoCTPN.TabIndex = 16;
            this.UndoCTPN.Text = "Phục hồi";
            this.UndoCTPN.UseVisualStyleBackColor = true;
            this.UndoCTPN.Click += new System.EventHandler(this.UndoCTPN_Click);
            // 
            // sP_LayMaVT_CTDDHTableAdapter
            // 
            this.sP_LayMaVT_CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // sP_LayDonGia_CTDDHBindingSource
            // 
            this.sP_LayDonGia_CTDDHBindingSource.DataMember = "SP_LayDonGia_CTDDH";
            this.sP_LayDonGia_CTDDHBindingSource.DataSource = this.qLVTDataSet;
            // 
            // sP_LayDonGia_CTDDHTableAdapter
            // 
            this.sP_LayDonGia_CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // sP_LaySoLuong_CTDDHBindingSource
            // 
            this.sP_LaySoLuong_CTDDHBindingSource.DataMember = "SP_LaySoLuong_CTDDH";
            this.sP_LaySoLuong_CTDDHBindingSource.DataSource = this.qLVTDataSet;
            // 
            // sP_LaySoLuong_CTDDHTableAdapter
            // 
            this.sP_LaySoLuong_CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_LayDonGia_CTDDHBindingSource, "DONGIA", true));
            this.textEdit1.Location = new System.Drawing.Point(90, 169);
            this.textEdit1.MenuManager = this.barManager1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(151, 20);
            this.textEdit1.TabIndex = 9;
            this.textEdit1.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_LaySoLuong_CTDDHBindingSource, "SOLUONG", true));
            this.textEdit2.Location = new System.Drawing.Point(90, 124);
            this.textEdit2.MenuManager = this.barManager1;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(151, 20);
            this.textEdit2.TabIndex = 10;
            this.textEdit2.TextChanged += new System.EventHandler(this.textEdit2_TextChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Caption = "Refresh";
            this.btn_refresh.Id = 5;
            this.btn_refresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 526);
            this.Controls.Add(this.UndoCTPN);
            this.Controls.Add(this.GhiCTPN);
            this.Controls.Add(this.XoaCTPN);
            this.Controls.Add(this.ThemCTPN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbCTPN);
            this.Controls.Add(this.grbPN);
            this.Controls.Add(this.cTPNDataGridView);
            this.Controls.Add(this.phieuNhapGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNDataGridView)).EndInit();
            this.grbPN.ResumeLayout(false);
            this.grbPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kho1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHang1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_makho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_manv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_masoddh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_mapn.Properties)).EndInit();
            this.grbCTPN.ResumeLayout(false);
            this.grbCTPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LayMaVT_CTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_dg_ct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_sl_ct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_mavt_ct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_mapn_ct.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LayDonGia_CTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LaySoLuong_CTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarButtonItem btn_ghi;
        private DevExpress.XtraBars.BarButtonItem btn_phuchoi;
        private DevExpress.XtraBars.BarButtonItem btn_thoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private QLVTDataSet qLVTDataSet;
        private QLVTDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl phieuNhapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVTDataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource cTPNBindingSource;
        private System.Windows.Forms.GroupBox grbCTPN;
        private System.Windows.Forms.GroupBox grbPN;
        private DevExpress.XtraEditors.TextEdit tbx_makho;
        private DevExpress.XtraEditors.SpinEdit tbx_manv;
        private DevExpress.XtraEditors.TextEdit tbx_masoddh;
        private DevExpress.XtraEditors.DateEdit tbx_ngay;
        private DevExpress.XtraEditors.TextEdit tbx_mapn;
        private System.Windows.Forms.DataGridView cTPNDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource datHang1BindingSource;
        private QLVTDataSetTableAdapters.DatHang1TableAdapter datHang1TableAdapter;
        private System.Windows.Forms.ComboBox datHang1ComboBox;
        private System.Windows.Forms.BindingSource kho1BindingSource;
        private QLVTDataSetTableAdapters.Kho1TableAdapter kho1TableAdapter;
        private System.Windows.Forms.ComboBox kho1ComboBox;
        private System.Windows.Forms.BindingSource nhanvien1BindingSource;
        private QLVTDataSetTableAdapters.Nhanvien1TableAdapter nhanvien1TableAdapter;
        private System.Windows.Forms.ComboBox nhanvien1ComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource sp_DanhsachChinhanhBindingSource;
        private QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter sp_DanhsachChinhanhTableAdapter;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraEditors.SpinEdit tbx_dg_ct;
        private DevExpress.XtraEditors.SpinEdit tbx_sl_ct;
        private DevExpress.XtraEditors.TextEdit tbx_mavt_ct;
        private DevExpress.XtraEditors.TextEdit tbx_mapn_ct;
        private System.Windows.Forms.Button UndoCTPN;
        private System.Windows.Forms.Button GhiCTPN;
        private System.Windows.Forms.Button XoaCTPN;
        private System.Windows.Forms.Button ThemCTPN;
        private System.Windows.Forms.BindingSource sP_LayMaVT_CTDDHBindingSource;
        private QLVTDataSetTableAdapters.SP_LayMaVT_CTDDHTableAdapter sP_LayMaVT_CTDDHTableAdapter;
        private System.Windows.Forms.ComboBox cmb_mavt;
        private System.Windows.Forms.BindingSource sP_LayDonGia_CTDDHBindingSource;
        private QLVTDataSetTableAdapters.SP_LayDonGia_CTDDHTableAdapter sP_LayDonGia_CTDDHTableAdapter;
        private System.Windows.Forms.BindingSource sP_LaySoLuong_CTDDHBindingSource;
        private QLVTDataSetTableAdapters.SP_LaySoLuong_CTDDHTableAdapter sP_LaySoLuong_CTDDHTableAdapter;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraBars.BarButtonItem btn_refresh;
    }
}