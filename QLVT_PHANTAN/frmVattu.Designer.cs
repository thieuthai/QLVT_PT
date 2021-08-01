namespace QLVT_PHANTAN
{
    partial class frmVattu
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
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
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT_PHANTAN.QLVTDataSetTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.CTDDHTableAdapter();
            this.cTPNTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.CTPNTableAdapter();
            this.cTPXTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.CTPXTableAdapter();
            this.gcVattu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_slt = new DevExpress.XtraEditors.SpinEdit();
            this.tbx_dvt = new DevExpress.XtraEditors.TextEdit();
            this.tbx_tenvt = new DevExpress.XtraEditors.TextEdit();
            this.tbx_mavt = new DevExpress.XtraEditors.TextEdit();
            this.cTPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.sp_DanhsachChinhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.sp_DanhsachChinhanhTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_slt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_dvt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_tenvt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_mavt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(113, 39);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "MAVT:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(575, 35);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(46, 13);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "TENVT:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(113, 89);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(32, 13);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "DVT:";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(535, 85);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(86, 13);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "SOLUONGTON:";
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
            this.btn_thoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_thoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.barDockControlTop.Size = new System.Drawing.Size(1157, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 400);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1157, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 376);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1157, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 376);
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.EnforceConstraints = false;
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.qLVTDataSet;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanh1TableAdapter = null;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanvienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PHANTAN.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // gcVattu
            // 
            this.gcVattu.DataSource = this.vattuBindingSource;
            this.gcVattu.Location = new System.Drawing.Point(38, 32);
            this.gcVattu.MainView = this.gridView1;
            this.gcVattu.MenuManager = this.barManager1;
            this.gcVattu.Name = "gcVattu";
            this.gcVattu.Size = new System.Drawing.Size(810, 220);
            this.gcVattu.TabIndex = 5;
            this.gcVattu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcVattu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(sOLUONGTONLabel);
            this.groupBox1.Controls.Add(this.tbx_slt);
            this.groupBox1.Controls.Add(dVTLabel);
            this.groupBox1.Controls.Add(this.tbx_dvt);
            this.groupBox1.Controls.Add(tENVTLabel);
            this.groupBox1.Controls.Add(this.tbx_tenvt);
            this.groupBox1.Controls.Add(mAVTLabel);
            this.groupBox1.Controls.Add(this.tbx_mavt);
            this.groupBox1.Location = new System.Drawing.Point(38, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1099, 133);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbx_slt
            // 
            this.tbx_slt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "SOLUONGTON", true));
            this.tbx_slt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbx_slt.Location = new System.Drawing.Point(652, 78);
            this.tbx_slt.MenuManager = this.barManager1;
            this.tbx_slt.Name = "tbx_slt";
            this.tbx_slt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbx_slt.Size = new System.Drawing.Size(152, 20);
            this.tbx_slt.TabIndex = 7;
            // 
            // tbx_dvt
            // 
            this.tbx_dvt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "DVT", true));
            this.tbx_dvt.Location = new System.Drawing.Point(173, 82);
            this.tbx_dvt.MenuManager = this.barManager1;
            this.tbx_dvt.Name = "tbx_dvt";
            this.tbx_dvt.Size = new System.Drawing.Size(149, 20);
            this.tbx_dvt.TabIndex = 5;
            // 
            // tbx_tenvt
            // 
            this.tbx_tenvt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "TENVT", true));
            this.tbx_tenvt.Location = new System.Drawing.Point(652, 28);
            this.tbx_tenvt.MenuManager = this.barManager1;
            this.tbx_tenvt.Name = "tbx_tenvt";
            this.tbx_tenvt.Size = new System.Drawing.Size(152, 20);
            this.tbx_tenvt.TabIndex = 3;
            // 
            // tbx_mavt
            // 
            this.tbx_mavt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "MAVT", true));
            this.tbx_mavt.Location = new System.Drawing.Point(173, 32);
            this.tbx_mavt.MenuManager = this.barManager1;
            this.tbx_mavt.Name = "tbx_mavt";
            this.tbx_mavt.Properties.MaxLength = 4;
            this.tbx_mavt.Size = new System.Drawing.Size(149, 20);
            this.tbx_mavt.TabIndex = 1;
            // 
            // cTPXBindingSource
            // 
            this.cTPXBindingSource.DataMember = "FK_CTPX_Vattu";
            this.cTPXBindingSource.DataSource = this.vattuBindingSource;
            // 
            // cTPNBindingSource
            // 
            this.cTPNBindingSource.DataMember = "FK_CTPN_Vattu";
            this.cTPNBindingSource.DataSource = this.vattuBindingSource;
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "FK_CTDDH_Vattu";
            this.cTDDHBindingSource.DataSource = this.vattuBindingSource;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbChiNhanh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(888, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 164);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DataSource = this.sp_DanhsachChinhanhBindingSource;
            this.cmbChiNhanh.DisplayMember = "description";
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(36, 84);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(165, 21);
            this.cmbChiNhanh.TabIndex = 2;
            this.cmbChiNhanh.ValueMember = "subscriber_server";
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // sp_DanhsachChinhanhBindingSource
            // 
            this.sp_DanhsachChinhanhBindingSource.DataMember = "sp_DanhsachChinhanh";
            this.sp_DanhsachChinhanhBindingSource.DataSource = this.qLVTDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh";
            // 
            // sp_DanhsachChinhanhTableAdapter
            // 
            this.sp_DanhsachChinhanhTableAdapter.ClearBeforeFill = true;
            // 
            // frmVattu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcVattu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmVattu";
            this.Text = "frmVattu";
            this.Load += new System.EventHandler(this.frmVattu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_slt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_dvt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_tenvt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_mavt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarButtonItem btn_ghi;
        private DevExpress.XtraBars.BarButtonItem btn_phuchoi;
        private DevExpress.XtraBars.BarButtonItem btn_thoat;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private QLVTDataSet qLVTDataSet;
        private QLVTDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcVattu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SpinEdit tbx_slt;
        private DevExpress.XtraEditors.TextEdit tbx_dvt;
        private DevExpress.XtraEditors.TextEdit tbx_tenvt;
        private DevExpress.XtraEditors.TextEdit tbx_mavt;
        private QLVTDataSetTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource cTPXBindingSource;
        private QLVTDataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource cTPNBindingSource;
        private QLVTDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sp_DanhsachChinhanhBindingSource;
        private QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter sp_DanhsachChinhanhTableAdapter;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
    }
}