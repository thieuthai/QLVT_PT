using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLVT_PHANTAN
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
            //this.sp_DanhsachChinhanhTableAdapter1.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
            // this.sp_DanhsachChinhanhTableAdapter1.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
            // this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);

            rp_tuychon.Visible = false; rp_form.Visible = false; rp_role.Visible = false; rp_baocao.Visible = false;
            sp_DanhsachChinhanhComboBox.SelectedIndex = 1; sp_DanhsachChinhanhComboBox.SelectedIndex = 0;

           
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (tbx_tendn.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tài tên khoản", "Lỗi", MessageBoxButtons.OK);
                tbx_tendn.Focus();
                return;
            }

            if (tbx_matkhau.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống mật khẩu", "Lỗi", MessageBoxButtons.OK);
                tbx_matkhau.Focus();
                return;
            }

            SqlDataReader myReader;
            Program.mlogin = tbx_tendn.Text.Trim();
            Program.password = tbx_matkhau.Text.Trim();

            if (Program.KetNoi() == 0)
            {
                return;
            }
            //  MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OK);
            Program.mChinhanh = sp_DanhsachChinhanhComboBox.SelectedIndex;
            Program.bds_dspm = sp_DanhsachChinhanhBindingSource; // giu lai bds cu~
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;


            String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();


            Program.mUser = myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.mUser))
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn vui lòng kiểm tra lại.\n ", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            //  toolStripStatusLabel1.Text = "User:   " + myReader.GetString(0) + "     Họ và tên:" + myReader.GetString(1) + "           Nhóm" + myReader.GetString(2);
            lb_mUser.Text = "Mã nhân viên: " + Program.mUser;
            lb_mHoten.Text = "Tên nhân viên: " + Program.mHoten;
            lb_mGroup.Text = "Quyền: " + Program.mGroup;
            MessageBox.Show("Đăng nhập thành công ! ", "", MessageBoxButtons.OK);

            grb_dn.Visible = false; rp_tuychon.Visible = true;
 
            if (lb_mGroup.Text.Contains("NhanVien"))
            {
                rp_role.Visible = false;
                rp_baocao.Visible = false; // Chuyen qua false khi test xong code in
                rp_form.Visible = true;
            }else
            {
                rp_baocao.Visible = true;
                rp_role.Visible = true;
                rp_form.Visible = true;
            }

          //  myReader.Close();
          //  Program.conn.Close();

        }



        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void barbtn_vattu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVattu));
            if (frm != null) frm.Activate();
            else
            {
                frmVattu f = new frmVattu();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void barbtn_dangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bar_rpt_vattu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(inDSVattu));
            if (frm != null) frm.Activate();
            else
            {
                inDSVattu f = new inDSVattu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void sp_DanhsachChinhanhComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sp_DanhsachChinhanhComboBox.SelectedIndex == -1)
            {
                return;
            }
            Program.servername = sp_DanhsachChinhanhComboBox.SelectedValue.ToString();
        }

        private void barbtn_nhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barbtn_kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKho));
            if (frm != null) frm.Activate();
            else
            {
                frmKho f = new frmKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barbtn_ddh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDDH));
            if (frm != null) frm.Activate();
            else
            {
                frmDDH f = new frmDDH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barbtn_phieunhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuNhap f = new frmPhieuNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barbtn_phieuxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuXuat f = new frmPhieuXuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bar_themtk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barbtn_inddh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(inDDH_PN_Null));
            if (frm != null) frm.Activate();
            else
            {
                inDDH_PN_Null f = new inDDH_PN_Null();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barbtn_inNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(inDSNhanvien));
            if (frm != null) frm.Activate();
            else
            {
                inDSNhanvien f = new inDSNhanvien();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
