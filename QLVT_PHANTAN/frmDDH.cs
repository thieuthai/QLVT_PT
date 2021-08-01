using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_PHANTAN
{
    public partial class frmDDH : Form
    {
        public frmDDH()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        int vitri = 0;
        private void frmDDH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
            // TODO: This line of code loads data into the 'qLVTDataSet.Vattu1' table. You can move, or remove it, as needed.
            this.vattu1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattu1TableAdapter.Fill(this.qLVTDataSet.Vattu1);
            // TODO: This line of code loads data into the 'qLVTDataSet.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);
            // TODO: This line of code loads data into the 'qLVTDataSet.Nhanvien1' table. You can move, or remove it, as needed.
            this.nhanvien1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanvien1TableAdapter.Fill(this.qLVTDataSet.Nhanvien1);
            // TODO: This line of code loads data into the 'qLVTDataSet.Kho1' table. You can move, or remove it, as needed.
            this.kho1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.kho1TableAdapter.Fill(this.qLVTDataSet.Kho1);
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
            this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
            // TODO: This line of code loads data into the 'qLVTDataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVTDataSet.DatHang);


            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CongTy")
            {
                btn_them.Enabled = false; btn_xoa.Enabled = false; btn_ghi.Enabled = false; btn_phuchoi.Enabled = false;
                ThemCTDDH.Enabled = false; suaCTDDH.Enabled = false; XoaCTDDH.Enabled = false; GhiCTDDH.Enabled = false; UndoCTDDH.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = false;
            }

         //   kho1ComboBox.SelectedIndex = 1; kho1ComboBox.SelectedIndex = 0;
          //  nhanvien1ComboBox.SelectedIndex = 1; nhanvien1ComboBox.SelectedIndex = 0;
         //   vattu1ComboBox.SelectedIndex = 1; vattu1ComboBox.SelectedIndex = 0;
            tbx_masoddh.Enabled = false; tbx_masoDDH_ct.Enabled = false;
            ThemCTDDH.Enabled = true; suaCTDDH.Enabled = true; GhiCTDDH.Enabled = false; XoaCTDDH.Enabled = true;
            UndoCTDDH.Enabled = false; grb_ctddh.Enabled = false;

          
            
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_them.Enabled = false;
            datHangBindingSource.AddNew();
            kho1ComboBox.SelectedIndex = 1; kho1ComboBox.SelectedIndex = 0;
            nhanvien1ComboBox.SelectedIndex = 1; nhanvien1ComboBox.SelectedIndex = 0;
            tbx_ngay.Text = DateTime.Now.ToShortDateString();
            tbx_masoddh.Enabled = true;
            grb_ctddh.Enabled = false;
        }

        private void btn_ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbx_masoddh.Text == "")
            {
                MessageBox.Show("Tên kho không được thiếu");
                tbx_masoddh.Focus();
                return;
            }
            if (tbx_manv.Text == "")
            {
                MessageBox.Show("Tên kho không được thiếu");
                tbx_manv.Focus();
                return;
            }
            if (tbx_ngay.Text == "")
            {
                MessageBox.Show("Tên kho không được thiếu");
                tbx_ngay.Focus();
                return;
            }
            if (tbx_nhacc.Text == "")
            {
                MessageBox.Show("Tên kho không được thiếu");
                tbx_nhacc.Focus();
                return;
            }
            if (tbx_makho.Text == "")
            {
                MessageBox.Show("Tên kho không được thiếu");
                tbx_makho.Focus();
                return;
            }
            if (btn_them.Enabled == false)
            {
                string sql = "if exists (select MasoDDH from DatHang where MasoDDH = '" + tbx_masoddh.Text.Trim() + "') select MasoDDH from DatHang where MasoDDH = '" + tbx_masoddh.Text.Trim() + "' else select MasoDDH from LINK1.QLVT.DBO.DatHang where MasoDDH = '" + tbx_masoddh.Text.Trim() + "'";
                SqlDataReader reader;
                reader = Program.ExecSqlDataReader(sql);
                if (reader.HasRows)
                {
                    MessageBox.Show("Mã đơn đặt hàng này đã tồn tại ở Chi nhánh này hoặc Chi nhánh khác", "Lỗi", MessageBoxButtons.OK);
                    reader.Close();
                    return;
                }
                reader.Close();

                try
                {
                    datHangBindingSource.EndEdit();
                    datHangBindingSource.ResetCurrentItem();
                    if (qLVTDataSet.HasChanges())
                    {
                        this.datHangTableAdapter.Update(this.qLVTDataSet.DatHang);
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Mã đơn đặt hàng bị trùng, vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK);
                    }

                    else
                    {
                        MessageBox.Show("Lỗi ghi đơn đặt hàng. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    }
                    return;
                }
                btn_them.Enabled = true; tbx_masoddh.Enabled = false; grb_ctddh.Enabled = true;
            }
            else
            {
                try
                {
                    datHangBindingSource.EndEdit();
                    datHangBindingSource.ResetCurrentItem();
                    if (qLVTDataSet.HasChanges())
                    {
                        this.datHangTableAdapter.Update(this.qLVTDataSet.DatHang);
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi đơn đặt hàng. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    return;
                }
                btn_them.Enabled = true; tbx_masoddh.Enabled = false; grb_ctddh.Enabled = true;
            }
        }

        private void sp_DanhsachChinhanhComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
                // TODO: This line of code loads data into the 'qLVTDataSet.Vattu1' table. You can move, or remove it, as needed.
                this.vattu1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattu1TableAdapter.Fill(this.qLVTDataSet.Vattu1);
                // TODO: This line of code loads data into the 'qLVTDataSet.CTDDH' table. You can move, or remove it, as needed.
                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);
                // TODO: This line of code loads data into the 'qLVTDataSet.Nhanvien1' table. You can move, or remove it, as needed.
                this.nhanvien1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanvien1TableAdapter.Fill(this.qLVTDataSet.Nhanvien1);
                // TODO: This line of code loads data into the 'qLVTDataSet.Kho1' table. You can move, or remove it, as needed.
                this.kho1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.kho1TableAdapter.Fill(this.qLVTDataSet.Kho1);
                // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
                this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
                // TODO: This line of code loads data into the 'qLVTDataSet.DatHang' table. You can move, or remove it, as needed.
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.qLVTDataSet.DatHang);
            }
        }

        private void mAKHOTextEdit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                kho1BindingSource.Position = kho1BindingSource.Find("MAKHO", tbx_makho.Text);
            }
            catch
            {

            }
        }

        private void kho1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kho1ComboBox.SelectedIndex == -1) return;

            tbx_makho.Text = kho1ComboBox.SelectedValue.ToString();
        }

        private void nhanvien1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhanvien1ComboBox.SelectedIndex == -1) return;

            tbx_manv.Text = nhanvien1ComboBox.SelectedValue.ToString();
        }

        private void tbx_manv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                nhanvien1BindingSource.Position = nhanvien1BindingSource.Find("MANV", tbx_manv.Text);
            }
            catch
            {

            }
        }

        private void tbx_mavt_ct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vattu1BindingSource.Position = vattu1BindingSource.Find("MAVT", tbx_mavt_ct.Text);
            }
            catch
            {

            }
        }

        private void vattu1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vattu1ComboBox.SelectedIndex == -1) return;

            tbx_mavt_ct.Text = vattu1ComboBox.SelectedValue.ToString();
        }

        private void ThemCTDDH_Click(object sender, EventArgs e)
        {
            ThemCTDDH.Enabled = false;
            cTDDHBindingSource.AddNew();
            vattu1ComboBox.SelectedIndex = 1; vattu1ComboBox.SelectedIndex = 0;
            tbx_masoDDH_ct.Text = tbx_masoddh.Text;
            tbx_sl_ct.Text = "1";
            tbx_dg_ct.Text = "1";
            tbx_masoDDH_ct.Focus();
            grb_ddh.Enabled = false;
            ThemCTDDH.Enabled = false; suaCTDDH.Enabled = true; GhiCTDDH.Enabled = true; XoaCTDDH.Enabled = false;
            UndoCTDDH.Enabled = true; grb_ctddh.Enabled = true;
        }

        private void GhiCTDDH_Click(object sender, EventArgs e)
        {
            if (tbx_masoDDH_ct.Text == "")
            {
                MessageBox.Show("Mã số đơn đặt hàng không được thiếu");
                tbx_masoDDH_ct.Focus();
                return;
            }

            if (tbx_sl_ct.Text == "")
            {
                MessageBox.Show("Số lượng không được thiếu");
                tbx_sl_ct.Focus();
                return;
            }

            if (tbx_dg_ct.Text == "")
            {
                MessageBox.Show("Đơn giá không được thiếu");
                tbx_dg_ct.Focus();
                return;
            }

            if (Double.Parse(tbx_sl_ct.Text) < 1)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.");
                tbx_sl_ct.Focus();
                return;
            }
            if (Double.Parse(tbx_dg_ct.Text) < 1)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0.");
                tbx_dg_ct.Focus();
                return;
            }



            if (ThemCTDDH.Enabled == false)
            {
                try
                {
                    cTDDHBindingSource.EndEdit();
                    cTDDHBindingSource.ResetCurrentItem();
                    if (qLVTDataSet.HasChanges())
                    {
                        this.cTDDHTableAdapter.Update(this.qLVTDataSet.CTDDH);
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {

                    if (ex.Message.Contains("PK_CTDDH"))
                    {
                        MessageBox.Show("Đơn đặt hàng này đã có vật tư này, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK);
                    }
                    else if (ex.Message.Contains("FK_CTDDH_Vattu"))
                    {
                        MessageBox.Show("Vật tư không tồn tại, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi chi tiết đặt hàng. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    }
                    return;
                }
                ThemCTDDH.Enabled = true; suaCTDDH.Enabled = true; GhiCTDDH.Enabled = false; XoaCTDDH.Enabled = true;
                UndoCTDDH.Enabled = false; grb_ctddh.Enabled = false;
            }
            else if(suaCTDDH.Enabled == false)
            {


                try
                {
                    cTDDHBindingSource.EndEdit();
                    cTDDHBindingSource.ResetCurrentItem();
                    if (qLVTDataSet.HasChanges())
                    {
                        this.cTDDHTableAdapter.Update(this.qLVTDataSet.CTDDH);
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("PK_CTDDH"))
                    {
                        MessageBox.Show("Đơn đặt hàng này đã có vật tư này, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK);
                    }else
                    {
                        MessageBox.Show("Lỗi ghi chi tiết đặt hàng. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    }
          
                    return;
                }
                ThemCTDDH.Enabled = true; suaCTDDH.Enabled = true; GhiCTDDH.Enabled = false; XoaCTDDH.Enabled = true;
                UndoCTDDH.Enabled = false; grb_ctddh.Enabled = false;

            }


        }

        private void XoaCTDDH_Click(object sender, EventArgs e)
        {
            int k = Program.ExecMyReturn("sp_KiemTraCTPN", tbx_masoDDH_ct.Text, tbx_mavt_ct.Text);
            if (k == 1)
            {
                MessageBox.Show("Đơn đặt hàng này đã có phiếu nhập, không thể xóa.");
                return;
            }

            DialogResult xacNhan = MessageBox.Show("Bạn có chắc muốn xóa??", "Xác Nhận", MessageBoxButtons.YesNo);
            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    cTDDHBindingSource.RemoveCurrent();
                    this.cTDDHTableAdapter.Update(this.qLVTDataSet.CTDDH);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa Không Thành Công" + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    return;
                }
            }

        }

        private void UndoCTDDH_Click(object sender, EventArgs e)
        {
            cTDDHBindingSource.CancelEdit();
            cTDDHBindingSource.Position = vitri;
            ThemCTDDH.Enabled = true; suaCTDDH.Enabled = true; GhiCTDDH.Enabled = false; XoaCTDDH.Enabled = true;
            UndoCTDDH.Enabled = false; grb_ctddh.Enabled = false;
            grb_ddh.Enabled = true;
            btn_refresh.PerformClick();
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cTDDHBindingSource.Count > 0 || phieuNhapBindingSource.Count > 0)
            {
                MessageBox.Show("Đơn đặt hàng đã được sử dụng, không thể xóa!");
                return;
            }
            DialogResult xacNhan = MessageBox.Show("Bạn có chắc muốn xóa??", "Xác Nhận", MessageBoxButtons.YesNo);
            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    datHangBindingSource.RemoveCurrent();
                    this.datHangTableAdapter.Update(this.qLVTDataSet.DatHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa Không Thành Công" + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btn_phuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            datHangBindingSource.CancelEdit();
            datHangBindingSource.Position = vitri;
            btn_them.Enabled = false;
            tbx_masoddh.Enabled = false;
            grb_ctddh.Enabled = true;
            btn_refresh.PerformClick();
        }

        private void suaCTDDH_Click(object sender, EventArgs e)
        {
            int k = Program.ExecMyReturn("sp_KiemTraCTPN", tbx_masoDDH_ct.Text, tbx_mavt_ct.Text);
            if (k == 1)
            {
                MessageBox.Show("Đơn đặt hàng này đã có phiếu nhập chứa vật tư này.");

                // UndoCTDDH.PerformClick();
               //  cTDDHBindingSource.CancelEdit();
              //  cTDDHBindingSource.Position = vitri;
                //  Program.conn.Close();
                return;
            }
            else
            {
                ThemCTDDH.Enabled = true; suaCTDDH.Enabled = false; GhiCTDDH.Enabled = true; XoaCTDDH.Enabled = false;
                UndoCTDDH.Enabled = true; grb_ctddh.Enabled = true;
            }
        }

        private void btn_refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            // TODO: This line of code loads data into the 'qLVTDataSet.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);
            // TODO: This line of code loads data into the 'qLVTDataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVTDataSet.DatHang);
        }

        private void btn_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void tbx_masoDDH_ct_TextChanged(object sender, EventArgs e)
        {
            if (tbx_masoDDH_ct.Text == "")
            {
                suaCTDDH.Enabled = false;
            }else
            {
                suaCTDDH.Enabled = true;
            }
        }
    }
}
