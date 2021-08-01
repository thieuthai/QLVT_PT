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
    public partial class frmPhieuXuat : Form
    {
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuXuatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        int vitri = 0;

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.Vattu1' table. You can move, or remove it, as needed.
            this.vattu1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattu1TableAdapter.Fill(this.qLVTDataSet.Vattu1);
            // TODO: This line of code loads data into the 'qLVTDataSet.Kho1' table. You can move, or remove it, as needed.
            this.kho1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.kho1TableAdapter.Fill(this.qLVTDataSet.Kho1);
            // TODO: This line of code loads data into the 'qLVTDataSet.Nhanvien1' table. You can move, or remove it, as needed.
            this.nhanvien1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanvien1TableAdapter.Fill(this.qLVTDataSet.Nhanvien1);
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
            this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
            // TODO: This line of code loads data into the 'qLVTDataSet.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.qLVTDataSet.CTPX);
            // TODO: This line of code loads data into the 'qLVTDataSet.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);


            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CongTy")
            {
                btn_them.Enabled = false; btn_xoa.Enabled = false; btn_ghi.Enabled = false; btn_phuchoi.Enabled = false;

            }
            else
            {
                groupBox2.Enabled = false;
            }

            tbx_mapx.Enabled = false;

           // kho1ComboBox.SelectedIndex = 1; kho1ComboBox.SelectedIndex = 0;
          //  nhanvien1ComboBox.SelectedIndex = 1; nhanvien1ComboBox.SelectedIndex = 0;
         //   vattu1ComboBox.SelectedIndex = 1; vattu1ComboBox.SelectedIndex = 0;

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
                this.vattu1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattu1TableAdapter.Fill(this.qLVTDataSet.Vattu1);
                // TODO: This line of code loads data into the 'qLVTDataSet.Kho1' table. You can move, or remove it, as needed.
                this.kho1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.kho1TableAdapter.Fill(this.qLVTDataSet.Kho1);
                // TODO: This line of code loads data into the 'qLVTDataSet.Nhanvien1' table. You can move, or remove it, as needed.
                this.nhanvien1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanvien1TableAdapter.Fill(this.qLVTDataSet.Nhanvien1);
                // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
                this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
                // TODO: This line of code loads data into the 'qLVTDataSet.CTPX' table. You can move, or remove it, as needed.
                this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPXTableAdapter.Fill(this.qLVTDataSet.CTPX);
                // TODO: This line of code loads data into the 'qLVTDataSet.PhieuXuat' table. You can move, or remove it, as needed.
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);
            }
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
            catch { }
        }

        private void kho1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kho1ComboBox.SelectedIndex == -1) return;

            tbx_makho.Text = kho1ComboBox.SelectedValue.ToString();
        }

        private void tbx_makho_TextChanged(object sender, EventArgs e)
        {
            try
            {
                kho1BindingSource.Position = kho1BindingSource.Find("MAKHO", tbx_makho.Text);
            }
            catch { }
        }

        private void vattu1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vattu1ComboBox.SelectedIndex == -1) return;

            tbx_mavt_ct.Text = vattu1ComboBox.SelectedValue.ToString();
        }

        private void tbx_mavt_ct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vattu1BindingSource.Position = vattu1BindingSource.Find("MAVT", tbx_mavt_ct.Text);
            }
            catch { }
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_them.Enabled = false;
            phieuXuatBindingSource.AddNew();
            kho1ComboBox.SelectedIndex = 1; kho1ComboBox.SelectedIndex = 0;
            nhanvien1ComboBox.SelectedIndex = 1; nhanvien1ComboBox.SelectedIndex = 0;
            tbx_mapx.Enabled = true;
            tbx_ngay.Text = DateTime.Now.ToShortDateString();

        }

        private void btn_ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbx_mapx.Text == "")
            {
                MessageBox.Show("Mã phiếu xuất không được thiếu");
                tbx_mapx.Focus();
                return;
            }
            if (tbx_hotenkh.Text == "")
            {
                MessageBox.Show("Họ tên khách hàng không được thiếu");
                tbx_hotenkh.Focus();
                return;
            }
            if (tbx_ngay.Text == "")
            {
                MessageBox.Show("Ngày không được thiếu");
                tbx_ngay.Focus();
                return;
            }
            if (tbx_manv.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu");
                tbx_manv.Focus();
                return;
            }
            if (tbx_makho.Text == "")
            {
                MessageBox.Show("Mã kho không được thiếu");
                tbx_makho.Focus();
                return;
            }

            if(btn_them.Enabled == false)
            {
                string sql = "if exists (select MAPX from PhieuXuat where MAPX = '" + tbx_mapx.Text.Trim() + "') select MAPX from PhieuXuat where MAPX = '" + tbx_mapx.Text.Trim() + "' else select MAPX from LINK1.QLVT.DBO.PhieuXuat where MAPX = '" + tbx_mapx.Text.Trim() + "'";
                SqlDataReader reader;
                reader = Program.ExecSqlDataReader(sql);
                if (reader.HasRows)
                {
                    MessageBox.Show("Mã phiếu xuất này đã tồn tại ở Chi nhánh này hoặc Chi nhánh khác", "Lỗi", MessageBoxButtons.OK);
                    reader.Close();
                    return;
                }
                reader.Close();

                try
                {
                    phieuXuatBindingSource.EndEdit();
                    phieuXuatBindingSource.ResetCurrentItem();
                    if (qLVTDataSet.HasChanges())
                    {
                        this.phieuXuatTableAdapter.Update(this.qLVTDataSet.PhieuXuat);
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch(Exception ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Mã phiếu xuất bị trùng, vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi phiếu nhập. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    }
                    return;
                }
                btn_them.Enabled = true; tbx_mapx.Enabled = false;
            }
            //else
            //{
            //    try
            //    {
            //        phieuXuatBindingSource.EndEdit();
            //        phieuXuatBindingSource.ResetCurrentItem();
            //        if (qLVTDataSet.HasChanges())
            //        {
            //            this.phieuXuatTableAdapter.Update(this.qLVTDataSet.PhieuXuat);
            //        }
            //        MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
            //    }
            //    catch (Exception ex)
            //    {       
            //            MessageBox.Show("Lỗi ghi phiếu nhập. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
            //            return;
            //    }
            //    btn_them.Enabled = true; tbx_mapx.Enabled = false;
            //}
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(cTPXBindingSource.Count > 0)
            {
                MessageBox.Show("Phiếu xuất này đã có chi tiết, không thể xóa.!");
                return;
            }
            DialogResult xacNhan = MessageBox.Show("Bạn có chắc muốn xóa??", "Xác Nhận", MessageBoxButtons.YesNo);
            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    phieuXuatBindingSource.RemoveCurrent();
                    this.phieuXuatTableAdapter.Update(this.qLVTDataSet.PhieuXuat);
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
            
            phieuXuatBindingSource.CancelEdit();
            phieuXuatBindingSource.Position = vitri;
            btn_them.Enabled = true;
            tbx_mapx.Enabled = false;
            btn_refresh.PerformClick();
            
        }

        private void btn_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void ThemCTPX_Click(object sender, EventArgs e)
        {
            ThemCTPX.Enabled = false;
            cTPXBindingSource.AddNew();
            tbx_mapx_ct.Text = tbx_mapx.Text;
            vattu1ComboBox.SelectedIndex = 1; vattu1ComboBox.SelectedIndex = 0;
        }

        private void GhiCTPX_Click(object sender, EventArgs e)
        {
            if (tbx_mapx_ct.Text == "")
            {
                MessageBox.Show("Mã phiếu xuất không được thiếu.");
                tbx_mapx_ct.Focus();
                return;
            }
            if (tbx_mavt_ct.Text == "")
            {
                MessageBox.Show("Mã vật tư không được thiếu.");
                tbx_mavt_ct.Focus();
                return;
            }
            if (tbx_sl_ct.Text == "")
            {
                MessageBox.Show("Số lượng không được thiếu.");
                tbx_sl_ct.Focus();
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

            int k = Program.ExecMyReturn3("SP_XUATHANG", Convert.ToInt32(tbx_sl_ct.Text), tbx_mavt_ct.Text.ToString());
            if (k == 1)
            {
                MessageBox.Show("Số lượng xuất không được phép vượt quá số lượng tồn.", "Lỗi.", MessageBoxButtons.OK);
                return;
            }
            else
            {



                if (ThemCTPX.Enabled == false)
                {
                    try
                    {
                        Program.ExecNonQuery("exec SP_GiamSLT_Vattu '" + tbx_mavt_ct.Text + "', '" + tbx_sl_ct.Text + "'");
                        cTPXBindingSource.EndEdit();
                        cTPXBindingSource.ResetCurrentItem();
                        if (qLVTDataSet.HasChanges())
                        {
                            this.cTPXTableAdapter.Update(this.qLVTDataSet.CTPX);
                        }
                        MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);

                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("PK_CTPX"))
                        {
                            MessageBox.Show("Phiếu xuất này đã có vật tư này, vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi ghi phiếu nhập. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                        }
                        return;
                    }
                    ThemCTPX.Enabled = true;
                }
                //else
                //{
                //    try
                //    {
                //        cTPXBindingSource.EndEdit();
                //        cTPXBindingSource.ResetCurrentItem();
                //        if (qLVTDataSet.HasChanges())
                //        {
                //            this.cTPXTableAdapter.Update(this.qLVTDataSet.CTPX);
                //        }
                //        MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);

                //    }
                //    catch (Exception ex)
                //    {
                //        if (ex.Message.Contains("PK_CTPX"))
                //        {
                //            MessageBox.Show("Phiếu xuất này đã có vật tư này, vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK);
                //        }
                //        else
                //        {
                //            MessageBox.Show("Lỗi ghi phiếu nhập. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                //        }
                //        return;
                //    }
                //    ThemCTPX.Enabled = true;
                //}
            }
        }

        private void XoaCTPX_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Bạn có chắc muốn xóa??", "Xác Nhận", MessageBoxButtons.YesNo);
            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    Program.ExecNonQuery("exec SP_ThemSLT_Vattu '" + tbx_mavt_ct.Text + "', '" + tbx_sl_ct.Text + "'");
                    cTPXBindingSource.RemoveCurrent();
                    this.cTPXTableAdapter.Update(this.qLVTDataSet.CTPX);
                    MessageBox.Show("Đã xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa Không Thành Công" + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void UndoCTPX_Click(object sender, EventArgs e)
        {
            cTPXBindingSource.CancelEdit();
            cTPXBindingSource.Position = vitri;
            ThemCTPX.Enabled = true;
            btn_refresh.PerformClick();
        }

        private void btn_refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.qLVTDataSet.CTPX);
            // TODO: This line of code loads data into the 'qLVTDataSet.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);
        }
    }
}
