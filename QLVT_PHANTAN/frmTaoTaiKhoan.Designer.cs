namespace QLVT_PHANTAN
{
    partial class frmTaoTaiKhoan
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
            this.grb_taotk = new System.Windows.Forms.GroupBox();
            this.tbx_manv = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grb_role = new System.Windows.Forms.GroupBox();
            this.radioNV = new System.Windows.Forms.RadioButton();
            this.radioCN = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_mk = new System.Windows.Forms.TextBox();
            this.tbx_tendn = new System.Windows.Forms.TextBox();
            this.nhanvien1ComboBox = new System.Windows.Forms.ComboBox();
            this.nhanvien1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet = new QLVT_PHANTAN.QLVTDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.sp_DanhsachChinhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.sp_DanhsachChinhanhTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter();
            this.tableAdapterManager = new QLVT_PHANTAN.QLVTDataSetTableAdapters.TableAdapterManager();
            this.nhanvien1TableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.Nhanvien1TableAdapter();
            this.sp_TaoTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_TaoTaiKhoanTableAdapter = new QLVT_PHANTAN.QLVTDataSetTableAdapters.sp_TaoTaiKhoanTableAdapter();
            this.grb_taotk.SuspendLayout();
            this.grb_role.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_TaoTaiKhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_taotk
            // 
            this.grb_taotk.Controls.Add(this.tbx_manv);
            this.grb_taotk.Controls.Add(this.btn_thoat);
            this.grb_taotk.Controls.Add(this.button1);
            this.grb_taotk.Controls.Add(this.grb_role);
            this.grb_taotk.Controls.Add(this.label4);
            this.grb_taotk.Controls.Add(this.tbx_mk);
            this.grb_taotk.Controls.Add(this.tbx_tendn);
            this.grb_taotk.Controls.Add(this.nhanvien1ComboBox);
            this.grb_taotk.Controls.Add(this.label3);
            this.grb_taotk.Controls.Add(this.label2);
            this.grb_taotk.Controls.Add(this.groupBox2);
            this.grb_taotk.Location = new System.Drawing.Point(47, 79);
            this.grb_taotk.Name = "grb_taotk";
            this.grb_taotk.Size = new System.Drawing.Size(863, 376);
            this.grb_taotk.TabIndex = 0;
            this.grb_taotk.TabStop = false;
            this.grb_taotk.Text = "Tạo tài khoản";
            // 
            // tbx_manv
            // 
            this.tbx_manv.Location = new System.Drawing.Point(594, 127);
            this.tbx_manv.Name = "tbx_manv";
            this.tbx_manv.ReadOnly = true;
            this.tbx_manv.Size = new System.Drawing.Size(100, 20);
            this.tbx_manv.TabIndex = 11;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(547, 310);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(111, 37);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tạo Tài Khoản";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grb_role
            // 
            this.grb_role.Controls.Add(this.radioNV);
            this.grb_role.Controls.Add(this.radioCN);
            this.grb_role.Location = new System.Drawing.Point(276, 254);
            this.grb_role.Name = "grb_role";
            this.grb_role.Size = new System.Drawing.Size(300, 50);
            this.grb_role.TabIndex = 7;
            this.grb_role.TabStop = false;
            // 
            // radioNV
            // 
            this.radioNV.AutoSize = true;
            this.radioNV.Location = new System.Drawing.Point(195, 16);
            this.radioNV.Name = "radioNV";
            this.radioNV.Size = new System.Drawing.Size(72, 17);
            this.radioNV.TabIndex = 1;
            this.radioNV.TabStop = true;
            this.radioNV.Text = "NhanVien";
            this.radioNV.UseVisualStyleBackColor = true;
            // 
            // radioCN
            // 
            this.radioCN.AutoSize = true;
            this.radioCN.Location = new System.Drawing.Point(26, 16);
            this.radioCN.Name = "radioCN";
            this.radioCN.Size = new System.Drawing.Size(72, 17);
            this.radioCN.TabIndex = 0;
            this.radioCN.TabStop = true;
            this.radioCN.Text = "ChiNhanh";
            this.radioCN.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu : ";
            // 
            // tbx_mk
            // 
            this.tbx_mk.Location = new System.Drawing.Point(276, 216);
            this.tbx_mk.Name = "tbx_mk";
            this.tbx_mk.Size = new System.Drawing.Size(300, 20);
            this.tbx_mk.TabIndex = 5;
            this.tbx_mk.UseSystemPasswordChar = true;
            // 
            // tbx_tendn
            // 
            this.tbx_tendn.Location = new System.Drawing.Point(276, 172);
            this.tbx_tendn.Name = "tbx_tendn";
            this.tbx_tendn.Size = new System.Drawing.Size(300, 20);
            this.tbx_tendn.TabIndex = 4;
            // 
            // nhanvien1ComboBox
            // 
            this.nhanvien1ComboBox.DataSource = this.nhanvien1BindingSource;
            this.nhanvien1ComboBox.DisplayMember = "HOTEN";
            this.nhanvien1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nhanvien1ComboBox.FormattingEnabled = true;
            this.nhanvien1ComboBox.Location = new System.Drawing.Point(276, 127);
            this.nhanvien1ComboBox.Name = "nhanvien1ComboBox";
            this.nhanvien1ComboBox.Size = new System.Drawing.Size(300, 21);
            this.nhanvien1ComboBox.TabIndex = 3;
            this.nhanvien1ComboBox.ValueMember = "MANV";
            this.nhanvien1ComboBox.SelectedIndexChanged += new System.EventHandler(this.nhanvien1ComboBox_SelectedIndexChanged);
            // 
            // nhanvien1BindingSource
            // 
            this.nhanvien1BindingSource.DataMember = "Nhanvien1";
            this.nhanvien1BindingSource.DataSource = this.qLVTDataSet;
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đăng nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbChiNhanh);
            this.groupBox2.Location = new System.Drawing.Point(228, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 73);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Nhánh";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DataSource = this.sp_DanhsachChinhanhBindingSource;
            this.cmbChiNhanh.DisplayMember = "description";
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(48, 30);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(300, 21);
            this.cmbChiNhanh.TabIndex = 0;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(384, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tạo Tài Khoản";
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
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHang1TableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.Kho1TableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.Nhanvien1TableAdapter = this.nhanvien1TableAdapter;
            this.tableAdapterManager.NhanvienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PHANTAN.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vattu1TableAdapter = null;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // nhanvien1TableAdapter
            // 
            this.nhanvien1TableAdapter.ClearBeforeFill = true;
            // 
            // sp_TaoTaiKhoanBindingSource
            // 
            this.sp_TaoTaiKhoanBindingSource.DataMember = "sp_TaoTaiKhoan";
            this.sp_TaoTaiKhoanBindingSource.DataSource = this.qLVTDataSet;
            // 
            // sp_TaoTaiKhoanTableAdapter
            // 
            this.sp_TaoTaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grb_taotk);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            this.grb_taotk.ResumeLayout(false);
            this.grb_taotk.PerformLayout();
            this.grb_role.ResumeLayout(false);
            this.grb_role.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_TaoTaiKhoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_taotk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource sp_DanhsachChinhanhBindingSource;
        private QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter sp_DanhsachChinhanhTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private QLVTDataSetTableAdapters.Nhanvien1TableAdapter nhanvien1TableAdapter;
        private System.Windows.Forms.BindingSource nhanvien1BindingSource;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grb_role;
        private System.Windows.Forms.RadioButton radioNV;
        private System.Windows.Forms.RadioButton radioCN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_mk;
        private System.Windows.Forms.TextBox tbx_tendn;
        private System.Windows.Forms.ComboBox nhanvien1ComboBox;
        private System.Windows.Forms.TextBox tbx_manv;
        private System.Windows.Forms.BindingSource sp_TaoTaiKhoanBindingSource;
        private QLVTDataSetTableAdapters.sp_TaoTaiKhoanTableAdapter sp_TaoTaiKhoanTableAdapter;
    }
}