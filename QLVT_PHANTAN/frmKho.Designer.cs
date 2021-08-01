namespace QLVT_PHANTAN
{
    partial class frmKho
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
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mACNLabel;
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.sp_DanhsachChinhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet = new QLVT_PHANTAN.QLVTDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.chiNhanh1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QLVT_PHANTAN.QLVTDataSetTableAdapters.TableAdapterManager();
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.phieuXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.PhieuXuatTableAdapter();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.DatHangTableAdapter();
            this.grbKho = new System.Windows.Forms.GroupBox();
            this.tbx_macn = new DevExpress.XtraEditors.TextEdit();
            this.tbx_diachi = new DevExpress.XtraEditors.TextEdit();
            this.tbx_tenkho = new DevExpress.XtraEditors.TextEdit();
            this.tbx_makho = new DevExpress.XtraEditors.TextEdit();
            this.chiNhanh1TableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.ChiNhanh1TableAdapter();
            this.sp_DanhsachChinhanhTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter();
            mAKHOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanh1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            this.grbKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_macn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_tenkho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_makho.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(152, 32);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(49, 13);
            mAKHOLabel.TabIndex = 0;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(152, 73);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(55, 13);
            tENKHOLabel.TabIndex = 2;
            tENKHOLabel.Text = "TENKHO:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(526, 32);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(46, 13);
            dIACHILabel.TabIndex = 4;
            dIACHILabel.Text = "DIACHI:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(526, 69);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(41, 13);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "MACN:";
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_them),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ghi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_phuchoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_thoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_them
            // 
            this.btn_them.Caption = "Thêm";
            this.btn_them.Id = 0;
            this.btn_them.Name = "btn_them";
            this.btn_them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_them_ItemClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Caption = "Xóa";
            this.btn_xoa.Id = 1;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_xoa_ItemClick);
            // 
            // btn_ghi
            // 
            this.btn_ghi.Caption = "Ghi";
            this.btn_ghi.Id = 2;
            this.btn_ghi.Name = "btn_ghi";
            this.btn_ghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ghi_ItemClick);
            // 
            // btn_phuchoi
            // 
            this.btn_phuchoi.Caption = "Phục hồi";
            this.btn_phuchoi.Id = 3;
            this.btn_phuchoi.Name = "btn_phuchoi";
            this.btn_phuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_phuchoi_ItemClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Caption = "Thoát";
            this.btn_thoat.Id = 4;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_thoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1219, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 406);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1219, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 384);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1219, 22);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 384);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbChiNhanh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(851, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DataSource = this.sp_DanhsachChinhanhBindingSource;
            this.cmbChiNhanh.DisplayMember = "description";
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(54, 92);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(192, 21);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.ValueMember = "subscriber_server";
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // sp_DanhsachChinhanhBindingSource
            // 
            this.sp_DanhsachChinhanhBindingSource.DataMember = "sp_DanhsachChinhanh";
            this.sp_DanhsachChinhanhBindingSource.DataSource = this.qLVTDataSet;
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.EnforceConstraints = false;
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // chiNhanh1BindingSource
            // 
            this.chiNhanh1BindingSource.DataMember = "ChiNhanh1";
            this.chiNhanh1BindingSource.DataSource = this.qLVTDataSet;
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.qLVTDataSet;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanh1TableAdapter = null;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHang1TableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.Kho1TableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.Nhanvien1TableAdapter = null;
            this.tableAdapterManager.NhanvienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PHANTAN.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vattu1TableAdapter = null;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // khoGridControl
            // 
            this.khoGridControl.DataSource = this.khoBindingSource;
            this.khoGridControl.Location = new System.Drawing.Point(35, 40);
            this.khoGridControl.MainView = this.gridView1;
            this.khoGridControl.MenuManager = this.barManager1;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(789, 212);
            this.khoGridControl.TabIndex = 6;
            this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.khoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // phieuXuatBindingSource
            // 
            this.phieuXuatBindingSource.DataMember = "FK_PhieuXuat_Kho";
            this.phieuXuatBindingSource.DataSource = this.khoBindingSource;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "FK_DatHang_Kho";
            this.datHangBindingSource.DataSource = this.khoBindingSource;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // grbKho
            // 
            this.grbKho.Controls.Add(mACNLabel);
            this.grbKho.Controls.Add(this.tbx_macn);
            this.grbKho.Controls.Add(dIACHILabel);
            this.grbKho.Controls.Add(this.tbx_diachi);
            this.grbKho.Controls.Add(tENKHOLabel);
            this.grbKho.Controls.Add(this.tbx_tenkho);
            this.grbKho.Controls.Add(mAKHOLabel);
            this.grbKho.Controls.Add(this.tbx_makho);
            this.grbKho.Location = new System.Drawing.Point(35, 284);
            this.grbKho.Name = "grbKho";
            this.grbKho.Size = new System.Drawing.Size(1114, 110);
            this.grbKho.TabIndex = 11;
            this.grbKho.TabStop = false;
            this.grbKho.Text = "Kho";
            // 
            // tbx_macn
            // 
            this.tbx_macn.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "MACN", true));
            this.tbx_macn.Enabled = false;
            this.tbx_macn.Location = new System.Drawing.Point(596, 62);
            this.tbx_macn.MenuManager = this.barManager1;
            this.tbx_macn.Name = "tbx_macn";
            this.tbx_macn.Size = new System.Drawing.Size(151, 20);
            this.tbx_macn.TabIndex = 7;
            // 
            // tbx_diachi
            // 
            this.tbx_diachi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "DIACHI", true));
            this.tbx_diachi.Location = new System.Drawing.Point(596, 25);
            this.tbx_diachi.MenuManager = this.barManager1;
            this.tbx_diachi.Name = "tbx_diachi";
            this.tbx_diachi.Size = new System.Drawing.Size(151, 20);
            this.tbx_diachi.TabIndex = 5;
            // 
            // tbx_tenkho
            // 
            this.tbx_tenkho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "TENKHO", true));
            this.tbx_tenkho.Location = new System.Drawing.Point(223, 66);
            this.tbx_tenkho.MenuManager = this.barManager1;
            this.tbx_tenkho.Name = "tbx_tenkho";
            this.tbx_tenkho.Properties.MaxLength = 30;
            this.tbx_tenkho.Size = new System.Drawing.Size(148, 20);
            this.tbx_tenkho.TabIndex = 3;
            // 
            // tbx_makho
            // 
            this.tbx_makho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "MAKHO", true));
            this.tbx_makho.Location = new System.Drawing.Point(223, 25);
            this.tbx_makho.MenuManager = this.barManager1;
            this.tbx_makho.Name = "tbx_makho";
            this.tbx_makho.Properties.MaxLength = 4;
            this.tbx_makho.Size = new System.Drawing.Size(148, 20);
            this.tbx_makho.TabIndex = 1;
            // 
            // chiNhanh1TableAdapter
            // 
            this.chiNhanh1TableAdapter.ClearBeforeFill = true;
            // 
            // sp_DanhsachChinhanhTableAdapter
            // 
            this.sp_DanhsachChinhanhTableAdapter.ClearBeforeFill = true;
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 406);
            this.Controls.Add(this.grbKho);
            this.Controls.Add(this.khoGridControl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKho";
            this.Text = "frmKho";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanh1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            this.grbKho.ResumeLayout(false);
            this.grbKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_macn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_tenkho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_makho.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private QLVTDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource phieuXuatBindingSource;
        private QLVTDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private QLVTDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.GroupBox grbKho;
        private DevExpress.XtraEditors.TextEdit tbx_macn;
        private DevExpress.XtraEditors.TextEdit tbx_diachi;
        private DevExpress.XtraEditors.TextEdit tbx_tenkho;
        private DevExpress.XtraEditors.TextEdit tbx_makho;
        private System.Windows.Forms.BindingSource chiNhanh1BindingSource;
        private QLVTDataSetTableAdapters.ChiNhanh1TableAdapter chiNhanh1TableAdapter;
        private System.Windows.Forms.BindingSource sp_DanhsachChinhanhBindingSource;
        private QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter sp_DanhsachChinhanhTableAdapter;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
    }
}