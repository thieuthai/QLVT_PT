using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_PHANTAN
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nhanvienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanvienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }
        int vitri = 0;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.ChiNhanh1' table. You can move, or remove it, as needed.
       //     this.chiNhanh1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiNhanh1TableAdapter.Fill(this.qLVTDataSet.ChiNhanh1);
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
            this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
            // TODO: This line of code loads data into the 'qLVTDataSet.Nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanvienTableAdapter.Fill(this.qLVTDataSet.Nhanvien);
            // TODO: This line of code loads data into the 'qLVTDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
            // TODO: This line of code loads data into the 'qLVTDataSet.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);
            // TODO: This line of code loads data into the 'qLVTDataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVTDataSet.DatHang);

         //   chiNhanh1ComboBox.SelectedIndex = 1; chiNhanh1ComboBox.SelectedIndex = 0;
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
         //   label1.Text = Program.mChinhanh.ToString();

            if (Program.mGroup == "CongTy")
            {
                btn_them.Enabled = false; btn_xoa.Enabled = false; btn_ghi.Enabled = false; btn_phuchoi.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = false;
            }

            tbx_manv.Enabled = false;

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedIndex == -1)
            {
                return;
            }
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            else
            {
                // TODO: This line of code loads data into the 'qLVTDataSet.ChiNhanh1' table. You can move, or remove it, as needed.
              //  this.chiNhanh1TableAdapter.Connection.ConnectionString = Program.connstr;
            //    this.chiNhanh1TableAdapter.Fill(this.qLVTDataSet.ChiNhanh1);
                // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
                this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
                // TODO: This line of code loads data into the 'qLVTDataSet.Nhanvien' table. You can move, or remove it, as needed.
                this.nhanvienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanvienTableAdapter.Fill(this.qLVTDataSet.Nhanvien);
                // TODO: This line of code loads data into the 'qLVTDataSet.PhieuNhap' table. You can move, or remove it, as needed.
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
                // TODO: This line of code loads data into the 'qLVTDataSet.PhieuXuat' table. You can move, or remove it, as needed.
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);
                // TODO: This line of code loads data into the 'qLVTDataSet.DatHang' table. You can move, or remove it, as needed.
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.qLVTDataSet.DatHang);
            }
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_them.Enabled = false;
            nhanvienBindingSource.AddNew();
            tbx_luong.Text = "5000000";
         //   chiNhanh1ComboBox.SelectedIndex = 1; chiNhanh1ComboBox.SelectedIndex = 0;
          //  chiNhanh1ComboBox.Enabled = false;
           if(cmbChiNhanh.SelectedIndex == 0)
            {
                tbx_macn.Text = "CN01";
            }
           else
            {
                tbx_macn.Text = "CN02";
            }
            
        }

        private void btn_ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbx_ten.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được thiếu");
                tbx_ten.Focus();
                return;
            }
            if (tbx_ho.Text == "")
            {
                MessageBox.Show("Họ nhân viên không được thiếu");
                tbx_ho.Focus();
                return;
            }
            if (tbx_dc.Text == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu");
                tbx_dc.Focus();
                return;
            }
            if (tbx_luong.Text == "")
            {
                MessageBox.Show("Lương không được thiếu");
                tbx_luong.Focus();
                return;
            }

            if (Double.Parse(tbx_luong.Text) < 4000000)
            {
                MessageBox.Show("Lương không được bé hơn 4000000.");
                tbx_luong.Focus();
                return;
            }
            //ràng buộc năm sinh trên 18
            int yearNow = int.Parse(DateTime.Now.Year.ToString());
            int yearBoth = int.Parse(dtp_ngaysinh.Value.Year.ToString());
            int yearOld = yearNow - yearBoth;
            if (yearOld < 18)
            {
                MessageBox.Show("Tuổi nhân viên phải lớn hơn hoặc bằng 18.");
                dtp_ngaysinh.Focus();
                return;
            }


            if (btn_them.Enabled == false)
            {
                string sql = "if exists (select MANV from Nhanvien where MANV = '" + tbx_manv.Text.Trim() + "') select MANV from Nhanvien where MANV = '" + tbx_manv.Text.Trim() + "' else select MANV from LINK1.QLVT.DBO.Nhanvien where MANV = '" + tbx_manv.Text.Trim() + "'";
                SqlDataReader reader;
                reader = Program.ExecSqlDataReader(sql);
                if (reader.HasRows)
                {
                    MessageBox.Show("Mã nhân viên này đã tồn tại ở Chi nhánh này hoặc Chi nhánh khác", "Lỗi", MessageBoxButtons.OK);
                    reader.Close();
                    return;
                }
            

                try
                {
                    nhanvienBindingSource.EndEdit();
                    nhanvienBindingSource.ResetCurrentItem();
                    if (qLVTDataSet.HasChanges())
                    {
                        this.nhanvienTableAdapter.Update(this.qLVTDataSet.Nhanvien);
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {

                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Mã nhân viên bị trùng, vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi nhân viên. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    }
                    return;
                }
                btn_them.Enabled = true;
                // chiNhanh1ComboBox.Enabled = true;
               
            }
            else
            {
                try
                {
                    nhanvienBindingSource.EndEdit();
                    nhanvienBindingSource.ResetCurrentItem();
                    if (qLVTDataSet.HasChanges())
                    {
                        this.nhanvienTableAdapter.Update(this.qLVTDataSet.Nhanvien);
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK);
                    return;
                    //    If(Err.Description.Contains("PRIMARY KEY")) Then
                    //    MsgBox("Mã vật tư bị trùng.")
                    //Else
                    //    MsgBox("Lỗi Ghi vật tư. Bạn kiểm tra lại thông tin trứơc khi ghi" & vbCrLf &
                    //        Err.Description & vbCrLf & Err.Source)
                    //End If
                    //Exit Sub

                }
            }
        }

        private void btn_phuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            nhanvienBindingSource.CancelEdit();
            nhanvienBindingSource.Position = vitri;
            btn_them.Enabled = true;
            frmNhanVien_Load(sender, e);
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (datHangBindingSource.Count > 0 || phieuNhapBindingSource.Count > 0 || phieuXuatBindingSource.Count > 0)
            {
                MessageBox.Show("Nhân viên này đã có ở đơn hàng, không được xóa!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

            DialogResult xacNhan = MessageBox.Show("Bạn có chắc muốn xóa??", "Xác Nhận", MessageBoxButtons.YesNo);
            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    nhanvienBindingSource.RemoveCurrent();
                    this.nhanvienTableAdapter.Update(this.qLVTDataSet.Nhanvien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa Không Thành Công" + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btn_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
