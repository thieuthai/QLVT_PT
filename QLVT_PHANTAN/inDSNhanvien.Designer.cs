namespace QLVT_PHANTAN
{
    partial class inDSNhanvien
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qLVTDataSet = new QLVT_PHANTAN.QLVTDataSet();
            this.sp_DanhsachChinhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_DanhsachChinhanhTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter();
            this.tableAdapterManager = new QLVT_PHANTAN.QLVTDataSetTableAdapters.TableAdapterManager();
            this.cbxChiNhanh = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxChiNhanh);
            this.groupBox2.Location = new System.Drawing.Point(287, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Nhánh";
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
            // cbxChiNhanh
            // 
            this.cbxChiNhanh.DataSource = this.sp_DanhsachChinhanhBindingSource;
            this.cbxChiNhanh.DisplayMember = "description";
            this.cbxChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChiNhanh.FormattingEnabled = true;
            this.cbxChiNhanh.Location = new System.Drawing.Point(32, 30);
            this.cbxChiNhanh.Name = "cbxChiNhanh";
            this.cbxChiNhanh.Size = new System.Drawing.Size(238, 21);
            this.cbxChiNhanh.TabIndex = 0;
            this.cbxChiNhanh.ValueMember = "subscriber_server";
            this.cbxChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbxChiNhanh_SelectedIndexChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 156);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(950, 313);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // inDSNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 469);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "inDSNhanvien";
            this.Text = "inDSNhanvien";
            this.Load += new System.EventHandler(this.inDSNhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource sp_DanhsachChinhanhBindingSource;
        private QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter sp_DanhsachChinhanhTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbxChiNhanh;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}