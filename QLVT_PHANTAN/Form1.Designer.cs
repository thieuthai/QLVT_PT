namespace QLVT_PHANTAN
{
    partial class Form1
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
            this.rb_all = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtn_dangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_nhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_vattu = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_ddh = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_phieunhap = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_phieuxuat = new DevExpress.XtraBars.BarButtonItem();
            this.bar_rpt_vattu = new DevExpress.XtraBars.BarButtonItem();
            this.bar_themtk = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_kho = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_inddh = new DevExpress.XtraBars.BarButtonItem();
            this.rp_tuychon = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rp_form = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rp_baocao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rp_role = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grb_dn = new System.Windows.Forms.GroupBox();
            this.sp_DanhsachChinhanhComboBox = new System.Windows.Forms.ComboBox();
            this.sp_DanhsachChinhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet = new QLVT_PHANTAN.QLVTDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_matkhau = new System.Windows.Forms.TextBox();
            this.tbx_tendn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new QLVT_PHANTAN.QLVTDataSetTableAdapters.TableAdapterManager();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lb_mUser = new System.Windows.Forms.ToolStripLabel();
            this.lb_mHoten = new System.Windows.Forms.ToolStripLabel();
            this.lb_mGroup = new System.Windows.Forms.ToolStripLabel();
            this.sp_DanhsachChinhanhTableAdapter1 = new QLVT_PHANTAN.QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barbtn_inNV = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.rb_all)).BeginInit();
            this.grb_dn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_all
            // 
            this.rb_all.ExpandCollapseItem.Id = 0;
            this.rb_all.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rb_all.ExpandCollapseItem,
            this.barbtn_dangxuat,
            this.barbtn_nhanvien,
            this.barbtn_vattu,
            this.barbtn_ddh,
            this.barbtn_phieunhap,
            this.barbtn_phieuxuat,
            this.bar_rpt_vattu,
            this.bar_themtk,
            this.barbtn_kho,
            this.barbtn_inddh,
            this.barbtn_inNV});
            this.rb_all.Location = new System.Drawing.Point(0, 0);
            this.rb_all.MaxItemId = 13;
            this.rb_all.Name = "rb_all";
            this.rb_all.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rp_tuychon,
            this.rp_form,
            this.rp_baocao,
            this.rp_role});
            this.rb_all.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.rb_all.Size = new System.Drawing.Size(1182, 143);
            // 
            // barbtn_dangxuat
            // 
            this.barbtn_dangxuat.Caption = "Đăng Xuất";
            this.barbtn_dangxuat.Id = 1;
            this.barbtn_dangxuat.ImageOptions.ImageUri.Uri = "Undo";
            this.barbtn_dangxuat.Name = "barbtn_dangxuat";
            this.barbtn_dangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_dangxuat_ItemClick);
            // 
            // barbtn_nhanvien
            // 
            this.barbtn_nhanvien.Caption = "Nhân viên";
            this.barbtn_nhanvien.Id = 2;
            this.barbtn_nhanvien.ImageOptions.ImageUri.Uri = "InFrontOfText";
            this.barbtn_nhanvien.Name = "barbtn_nhanvien";
            this.barbtn_nhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_nhanvien_ItemClick);
            // 
            // barbtn_vattu
            // 
            this.barbtn_vattu.Caption = "Vật tư";
            this.barbtn_vattu.Id = 3;
            this.barbtn_vattu.ImageOptions.ImageUri.Uri = "ClearFormatting";
            this.barbtn_vattu.Name = "barbtn_vattu";
            this.barbtn_vattu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_vattu_ItemClick);
            // 
            // barbtn_ddh
            // 
            this.barbtn_ddh.Caption = "Đơn đặt hàng";
            this.barbtn_ddh.Id = 4;
            this.barbtn_ddh.ImageOptions.ImageUri.Uri = "ListBullets";
            this.barbtn_ddh.Name = "barbtn_ddh";
            this.barbtn_ddh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_ddh_ItemClick);
            // 
            // barbtn_phieunhap
            // 
            this.barbtn_phieunhap.Caption = "Phiếu Nhập";
            this.barbtn_phieunhap.Id = 5;
            this.barbtn_phieunhap.ImageOptions.ImageUri.Uri = "IndentIncrease";
            this.barbtn_phieunhap.Name = "barbtn_phieunhap";
            this.barbtn_phieunhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_phieunhap_ItemClick);
            // 
            // barbtn_phieuxuat
            // 
            this.barbtn_phieuxuat.Caption = "Phiếu Xuất";
            this.barbtn_phieuxuat.Id = 6;
            this.barbtn_phieuxuat.ImageOptions.ImageUri.Uri = "IndentDecrease";
            this.barbtn_phieuxuat.Name = "barbtn_phieuxuat";
            this.barbtn_phieuxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_phieuxuat_ItemClick);
            // 
            // bar_rpt_vattu
            // 
            this.bar_rpt_vattu.Caption = "Báo cáo vật tư";
            this.bar_rpt_vattu.Id = 7;
            this.bar_rpt_vattu.ImageOptions.ImageUri.Uri = "EditDataSource";
            this.bar_rpt_vattu.Name = "bar_rpt_vattu";
            this.bar_rpt_vattu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_rpt_vattu_ItemClick);
            // 
            // bar_themtk
            // 
            this.bar_themtk.Caption = "Thêm Tài Khoản";
            this.bar_themtk.Id = 8;
            this.bar_themtk.ImageOptions.ImageUri.Uri = "Pie";
            this.bar_themtk.Name = "bar_themtk";
            this.bar_themtk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_themtk_ItemClick);
            // 
            // barbtn_kho
            // 
            this.barbtn_kho.Caption = "Kho";
            this.barbtn_kho.Id = 10;
            this.barbtn_kho.ImageOptions.ImageUri.Uri = "Zoom2";
            this.barbtn_kho.Name = "barbtn_kho";
            this.barbtn_kho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_kho_ItemClick);
            // 
            // barbtn_inddh
            // 
            this.barbtn_inddh.Caption = "Đơn Đặt Hàng Chưa Có Phiếu Xuất";
            this.barbtn_inddh.Id = 11;
            this.barbtn_inddh.ImageOptions.ImageUri.Uri = "CustomizeGrid";
            this.barbtn_inddh.Name = "barbtn_inddh";
            this.barbtn_inddh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_inddh_ItemClick);
            // 
            // rp_tuychon
            // 
            this.rp_tuychon.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rp_tuychon.Name = "rp_tuychon";
            this.rp_tuychon.Text = "Tùy chọn";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtn_dangxuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // rp_form
            // 
            this.rp_form.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup10});
            this.rp_form.Name = "rp_form";
            this.rp_form.Text = "Form";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtn_nhanvien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtn_vattu);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barbtn_ddh);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barbtn_phieunhap);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barbtn_phieuxuat);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.barbtn_kho);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "ribbonPageGroup10";
            // 
            // rp_baocao
            // 
            this.rp_baocao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup9,
            this.ribbonPageGroup11});
            this.rp_baocao.Name = "rp_baocao";
            this.rp_baocao.Text = "Báo cáo";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.bar_rpt_vattu);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "ribbonPageGroup7";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barbtn_inddh);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "ribbonPageGroup9";
            // 
            // rp_role
            // 
            this.rp_role.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.rp_role.Name = "rp_role";
            this.rp_role.Text = "Quyền";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.bar_themtk);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "ribbonPageGroup8";
            // 
            // grb_dn
            // 
            this.grb_dn.Controls.Add(this.sp_DanhsachChinhanhComboBox);
            this.grb_dn.Controls.Add(this.label4);
            this.grb_dn.Controls.Add(this.btn_thoat);
            this.grb_dn.Controls.Add(this.btn_dangnhap);
            this.grb_dn.Controls.Add(this.label3);
            this.grb_dn.Controls.Add(this.tbx_matkhau);
            this.grb_dn.Controls.Add(this.tbx_tendn);
            this.grb_dn.Controls.Add(this.label2);
            this.grb_dn.Controls.Add(this.label1);
            this.grb_dn.Location = new System.Drawing.Point(297, 170);
            this.grb_dn.Name = "grb_dn";
            this.grb_dn.Size = new System.Drawing.Size(760, 303);
            this.grb_dn.TabIndex = 1;
            this.grb_dn.TabStop = false;
            this.grb_dn.Text = "Đăng nhập tài khoản";
            // 
            // sp_DanhsachChinhanhComboBox
            // 
            this.sp_DanhsachChinhanhComboBox.DataSource = this.sp_DanhsachChinhanhBindingSource;
            this.sp_DanhsachChinhanhComboBox.DisplayMember = "description";
            this.sp_DanhsachChinhanhComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sp_DanhsachChinhanhComboBox.FormattingEnabled = true;
            this.sp_DanhsachChinhanhComboBox.Location = new System.Drawing.Point(183, 97);
            this.sp_DanhsachChinhanhComboBox.Name = "sp_DanhsachChinhanhComboBox";
            this.sp_DanhsachChinhanhComboBox.Size = new System.Drawing.Size(224, 21);
            this.sp_DanhsachChinhanhComboBox.TabIndex = 8;
            this.sp_DanhsachChinhanhComboBox.ValueMember = "subscriber_server";
            this.sp_DanhsachChinhanhComboBox.SelectedIndexChanged += new System.EventHandler(this.sp_DanhsachChinhanhComboBox_SelectedIndexChanged);
            // 
            // sp_DanhsachChinhanhBindingSource
            // 
            this.sp_DanhsachChinhanhBindingSource.DataMember = "sp_DanhsachChinhanh";
            this.sp_DanhsachChinhanhBindingSource.DataSource = this.qLVTDataSet;
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Server : ";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(377, 244);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(101, 36);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(82, 244);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(101, 36);
            this.btn_dangnhap.TabIndex = 5;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu : ";
            // 
            // tbx_matkhau
            // 
            this.tbx_matkhau.Location = new System.Drawing.Point(183, 187);
            this.tbx_matkhau.Name = "tbx_matkhau";
            this.tbx_matkhau.Size = new System.Drawing.Size(224, 21);
            this.tbx_matkhau.TabIndex = 3;
            this.tbx_matkhau.UseSystemPasswordChar = true;
            // 
            // tbx_tendn
            // 
            this.tbx_tendn.Location = new System.Drawing.Point(183, 143);
            this.tbx_tendn.Name = "tbx_tendn";
            this.tbx_tendn.Size = new System.Drawing.Size(224, 21);
            this.tbx_tendn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(190, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập Tài Khoản";
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
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_mUser,
            this.lb_mHoten,
            this.lb_mGroup});
            this.toolStrip1.Location = new System.Drawing.Point(0, 480);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1182, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lb_mUser
            // 
            this.lb_mUser.Name = "lb_mUser";
            this.lb_mUser.Size = new System.Drawing.Size(82, 22);
            this.lb_mUser.Text = "Mã nhân viên ";
            // 
            // lb_mHoten
            // 
            this.lb_mHoten.Name = "lb_mHoten";
            this.lb_mHoten.Size = new System.Drawing.Size(46, 22);
            this.lb_mHoten.Text = "Họ tên ";
            // 
            // lb_mGroup
            // 
            this.lb_mGroup.Name = "lb_mGroup";
            this.lb_mGroup.Size = new System.Drawing.Size(42, 22);
            this.lb_mGroup.Text = "Quyền";
            // 
            // sp_DanhsachChinhanhTableAdapter1
            // 
            this.sp_DanhsachChinhanhTableAdapter1.ClearBeforeFill = true;
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.barbtn_inNV);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "ribbonPageGroup11";
            // 
            // barbtn_inNV
            // 
            this.barbtn_inNV.Caption = "Báo cáo nhân viên";
            this.barbtn_inNV.Id = 12;
            this.barbtn_inNV.ImageOptions.ImageUri.Uri = "Show";
            this.barbtn_inNV.Name = "barbtn_inNV";
            this.barbtn_inNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_inNV_ItemClick);
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 505);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grb_dn);
            this.Controls.Add(this.rb_all);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.rb_all;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rb_all)).EndInit();
            this.grb_dn.ResumeLayout(false);
            this.grb_dn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhsachChinhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rb_all;
        private DevExpress.XtraBars.Ribbon.RibbonPage rp_tuychon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barbtn_dangxuat;
        private DevExpress.XtraBars.BarButtonItem barbtn_nhanvien;
        private DevExpress.XtraBars.Ribbon.RibbonPage rp_form;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barbtn_vattu;
        private DevExpress.XtraBars.BarButtonItem barbtn_ddh;
        private DevExpress.XtraBars.BarButtonItem barbtn_phieunhap;
        private DevExpress.XtraBars.BarButtonItem barbtn_phieuxuat;
        private DevExpress.XtraBars.BarButtonItem bar_rpt_vattu;
        private DevExpress.XtraBars.BarButtonItem bar_themtk;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage rp_baocao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage rp_role;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private System.Windows.Forms.GroupBox grb_dn;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_matkhau;
        private System.Windows.Forms.TextBox tbx_tendn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private QLVTDataSet qLVTDataSet;
        private QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter sp_DanhsachChinhanhTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lb_mUser;
        private System.Windows.Forms.ToolStripLabel lb_mHoten;
        private System.Windows.Forms.ToolStripLabel lb_mGroup;
        private System.Windows.Forms.BindingSource sp_DanhsachChinhanhBindingSource;
        private QLVTDataSetTableAdapters.sp_DanhsachChinhanhTableAdapter sp_DanhsachChinhanhTableAdapter1;
        private System.Windows.Forms.ComboBox sp_DanhsachChinhanhComboBox;
        private DevExpress.XtraBars.BarButtonItem barbtn_kho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem barbtn_inddh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem barbtn_inNV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
    }
}

