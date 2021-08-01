namespace QLVT_PHANTAN
{
    partial class inDDH_PN_Null
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_inphieu = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qLVTDataSet = new QLVT_PHANTAN.QLVTDataSet();
            this.sp_DanhsachChinhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_DanhsachChinhanhTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter();
            this.tableAdapterManager = new QLVT_PHANTAN.QLVTDataSetTableAdapters.TableAdapterManager();
            this.sp_DanhsachChinhanhComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_inphieu);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "In Đơn Đặt Hàng Chưa Có Phiếu Nhập";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(475, 95);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(110, 35);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // btn_inphieu
            // 
            this.btn_inphieu.Location = new System.Drawing.Point(296, 95);
            this.btn_inphieu.Name = "btn_inphieu";
            this.btn_inphieu.Size = new System.Drawing.Size(114, 35);
            this.btn_inphieu.TabIndex = 0;
            this.btn_inphieu.Text = "In Phiếu";
            this.btn_inphieu.UseVisualStyleBackColor = true;
            this.btn_inphieu.Click += new System.EventHandler(this.btn_inphieu_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 149);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(953, 318);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sp_DanhsachChinhanhComboBox);
            this.groupBox2.Location = new System.Drawing.Point(254, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi nhánh";
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanh1TableAdapter = null;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHang1TableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.Kho1TableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.Nhanvien1TableAdapter = null;
            this.tableAdapterManager.NhanvienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PHANTAN.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vattu1TableAdapter = null;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // sp_DanhsachChinhanhComboBox
            // 
            this.sp_DanhsachChinhanhComboBox.DataSource = this.sp_DanhsachChinhanhBindingSource;
            this.sp_DanhsachChinhanhComboBox.DisplayMember = "description";
            this.sp_DanhsachChinhanhComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sp_DanhsachChinhanhComboBox.FormattingEnabled = true;
            this.sp_DanhsachChinhanhComboBox.Location = new System.Drawing.Point(80, 29);
            this.sp_DanhsachChinhanhComboBox.Name = "sp_DanhsachChinhanhComboBox";
            this.sp_DanhsachChinhanhComboBox.Size = new System.Drawing.Size(232, 21);
            this.sp_DanhsachChinhanhComboBox.TabIndex = 0;
            this.sp_DanhsachChinhanhComboBox.ValueMember = "subscriber_server";
            this.sp_DanhsachChinhanhComboBox.SelectedIndexChanged += new System.EventHandler(this.sp_DanhsachChinhanhComboBox_SelectedIndexChanged);
            // 
            // inDDH_PN_Null
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 467);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "inDDH_PN_Null";
            this.Text = "inDDH_PN_Null";
            this.Load += new System.EventHandler(this.inDDH_PN_Null_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_inphieu;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource sp_DanhsachChinhanhBindingSource;
        private QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter sp_DanhsachChinhanhTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox sp_DanhsachChinhanhComboBox;
    }
}