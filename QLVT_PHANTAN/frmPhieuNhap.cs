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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuNhapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        int vitri = 0;

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
            this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
            // TODO: This line of code loads data into the 'qLVTDataSet.Nhanvien1' table. You can move, or remove it, as needed.
            this.nhanvien1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanvien1TableAdapter.Fill(this.qLVTDataSet.Nhanvien1);
            // TODO: This line of code loads data into the 'qLVTDataSet.Kho1' table. You can move, or remove it, as needed.
            this.kho1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.kho1TableAdapter.Fill(this.qLVTDataSet.Kho1);
            // TODO: This line of code loads data into the 'qLVTDataSet.DatHang1' table. You can move, or remove it, as needed.
            this.datHang1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHang1TableAdapter.Fill(this.qLVTDataSet.DatHang1);
            // TODO: This line of code loads data into the 'qLVTDataSet.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qLVTDataSet.CTPN);
            // TODO: This line of code loads data into the 'qLVTDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);

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

            //  kho1ComboBox.SelectedIndex = 1; kho1ComboBox.SelectedIndex = 0;
            //   nhanvien1ComboBox.SelectedIndex = 1; nhanvien1ComboBox.SelectedIndex = 0;
            //    datHang1ComboBox.SelectedIndex = 1; datHang1ComboBox.SelectedIndex = 0;
            cmb_mavt.SelectedIndex = 1; cmb_mavt.SelectedIndex = 0;
      
            tbx_mapn.Enabled = false;

        }

        private void tbx_masoddh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                datHang1BindingSource.Position = datHang1BindingSource.Find("MasoDDH", tbx_masoddh.Text);
                this.sP_LayMaVT_CTDDHTableAdapter.Fill(qLVTDataSet.SP_LayMaVT_CTDDH, tbx_masoddh.Text);
            }
            catch
            {

            }
        }

        private void datHang1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (datHang1ComboBox.SelectedIndex == -1) return;

            tbx_masoddh.Text = datHang1ComboBox.SelectedValue.ToString();
        }

        private void tbx_manv_TextChanged(object sender, EventArgs e)
        {
            this.sP_LaySoLuong_CTDDHTableAdapter.Fill(qLVTDataSet.SP_LaySoLuong_CTDDH, tbx_mavt_ct.Text, tbx_masoddh.Text);
            this.sP_LayDonGia_CTDDHTableAdapter.Fill(qLVTDataSet.SP_LayDonGia_CTDDH, tbx_mavt_ct.Text, tbx_masoddh.Text);
            try
            {
                nhanvien1BindingSource.Position = nhanvien1BindingSource.Find("MANV", tbx_manv.Text);
               
            }
            catch
            {

            }
        }

        private void nhanvien1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhanvien1ComboBox.SelectedIndex == -1) return;

            tbx_manv.Text = nhanvien1ComboBox.SelectedValue.ToString();
        }

        private void tbx_makho_TextChanged(object sender, EventArgs e)
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
                this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
                // TODO: This line of code loads data into the 'qLVTDataSet.Nhanvien1' table. You can move, or remove it, as needed.
                this.nhanvien1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanvien1TableAdapter.Fill(this.qLVTDataSet.Nhanvien1);
                // TODO: This line of code loads data into the 'qLVTDataSet.Kho1' table. You can move, or remove it, as needed.
                this.kho1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.kho1TableAdapter.Fill(this.qLVTDataSet.Kho1);
                // TODO: This line of code loads data into the 'qLVTDataSet.DatHang1' table. You can move, or remove it, as needed.
                this.datHang1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHang1TableAdapter.Fill(this.qLVTDataSet.DatHang1);
                // TODO: This line of code loads data into the 'qLVTDataSet.CTPN' table. You can move, or remove it, as needed.
                this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPNTableAdapter.Fill(this.qLVTDataSet.CTPN);
                // TODO: This line of code loads data into the 'qLVTDataSet.PhieuNhap' table. You can move, or remove it, as needed.
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
            }
            }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_them.Enabled = false;
            tbx_mapn.Enabled = true;
            phieuNhapBindingSource.AddNew();
            kho1ComboBox.SelectedIndex = 1; kho1ComboBox.SelectedIndex = 0;
            nhanvien1ComboBox.SelectedIndex = 1; nhanvien1ComboBox.SelectedIndex = 0;
            datHang1ComboBox.SelectedIndex = 1; datHang1ComboBox.SelectedIndex = 0;
            tbx_ngay.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbx_mapn.Text == "")
            {
                MessageBox.Show("Mã phiếu nhập không được thiếu");
                tbx_mapn.Focus();
                return;
            }
            if (tbx_ngay.Text == "")
            {
                MessageBox.Show("Ngày không được thiếu");
                tbx_ngay.Focus();
                return;
            }
        

            if (btn_them.Enabled == false)
            {
                string sql = "if exists (select MAPN from PhieuNhap where MAPN = '" + tbx_mapn.Text.Trim() + "') select MAPN from PhieuNhap where MAPN = '" + tbx_mapn.Text.Trim() + "' else select MAPN from LINK1.QLVT.DBO.PhieuNhap where MAPN = '" + tbx_mapn.Text.Trim() + "'";
                SqlDataReader reader;
                reader = Program.ExecSqlDataReader(sql);
                if (reader.HasRows)
                {
                    MessageBox.Show("Mã phiếu nhập này đã tồn tại ở Chi nhánh này hoặc Chi nhánh khác", "Lỗi", MessageBoxButtons.OK);
                    reader.Close();
                    return;
                }
                reader.Close();

                try
                {
                    phieuNhapBindingSource.EndEdit();
                    phieuNhapBindingSource.ResetCurrentItem();
                    if (qLVTDataSet.HasChanges())
                    {
                        this.phieuNhapTableAdapter.Update(this.qLVTDataSet.PhieuNhap);
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch(Exception ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Mã phiếu nhập bị trùng, vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK);
                    }
                    else if (ex.Message.Contains("IX_PhieuNhap"))
                    {
                        MessageBox.Show("Đơn đặt hàng này đã có phiếu nhập. Vui lòng chọn đơn đặt hàng khác.","Lỗi",MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi phiếu nhập. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    }
                    return;
                }
                btn_them.Enabled = true; tbx_mapn.Enabled = false;
            }
            else
            {
                try
                {
                    phieuNhapBindingSource.EndEdit();
                    phieuNhapBindingSource.ResetCurrentItem();
                    if (qLVTDataSet.HasChanges())
                    {
                        this.phieuNhapTableAdapter.Update(this.qLVTDataSet.PhieuNhap);
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("IX_PhieuNhap"))
                    {
                        MessageBox.Show("Đơn đặt hàng này đã có phiếu nhập. Vui lòng chọn đơn đặt hàng khác.", "Lỗi", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi phiếu nhập. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    }
                    
                        return;
                }
                btn_them.Enabled = true; tbx_mapn.Enabled = false;
            }
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(cTPNBindingSource.Count > 0)
            {
                MessageBox.Show("Phiếu nhập này đã có chi tiết, không thể xóa!");
                return;
            }

            DialogResult xacNhan = MessageBox.Show("Bạn có chắc muốn xóa??", "Xác Nhận", MessageBoxButtons.YesNo);
            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    phieuNhapBindingSource.RemoveCurrent();
                    this.phieuNhapTableAdapter.Update(this.qLVTDataSet.PhieuNhap);
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
            phieuNhapBindingSource.CancelEdit();
            phieuNhapBindingSource.Position = vitri;
            btn_them.Enabled = true;
            tbx_mapn.Enabled = false;
            btn_refresh.PerformClick();
        }

        private void btn_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void ThemCTPN_Click(object sender, EventArgs e)
        {
            ThemCTPN.Enabled = false;
            cTPNBindingSource.AddNew();
            tbx_mapn_ct.Text = tbx_mapn.Text;
            cmb_mavt.SelectedIndex = -1;
            grbPN.Enabled = false;
        }

      
        private void cmb_mavt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_mavt.SelectedIndex == -1) return;

            tbx_mavt_ct.Text = cmb_mavt.SelectedValue.ToString();
        }

        private void tbx_mavt_ct_TextChanged(object sender, EventArgs e)
        {
            this.sP_LaySoLuong_CTDDHTableAdapter.Fill(qLVTDataSet.SP_LaySoLuong_CTDDH, tbx_mavt_ct.Text, tbx_masoddh.Text);
            this.sP_LayDonGia_CTDDHTableAdapter.Fill(qLVTDataSet.SP_LayDonGia_CTDDH, tbx_mavt_ct.Text, tbx_masoddh.Text);
            try
            {
                sP_LayMaVT_CTDDHBindingSource.Position = sP_LayMaVT_CTDDHBindingSource.Find("MAVT", tbx_mavt_ct.Text);
              
            }
            catch
            {

            }

        }

        private void GhiCTPN_Click(object sender, EventArgs e)
        {
            if(tbx_sl_ct.Text == "")
            {
                MessageBox.Show("Số lượng không được thiếu!");
                tbx_sl_ct.Focus();
                return;
            }
            if(tbx_dg_ct.Text == "")
            {
                MessageBox.Show("Đơn giá không được thiếu!");
                tbx_dg_ct.Focus();
                return;
            }
            if (tbx_mavt_ct.Text == "")
            {
                MessageBox.Show("Vật tư không được thiếu!");
                tbx_mavt_ct.Focus();
                return;
            }
            if (tbx_mapn_ct.Text == "")
            {
                MessageBox.Show("Mã phiếu nhập không được thiếu!");
                tbx_mapn_ct.Focus();
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

            //int k = Program.ExecMyReturn2("SP_NHAPHANG", tbx_masoddh.Text.ToString(), tbx_mavt_ct.Text.ToString(), Convert.ToInt32(tbx_sl_ct.Text));
            //if(k == 0)
            //{
            //    MessageBox.Show("Vật tư này đã nhập đủ. Không thể thêm.");
            //    return;
            //}
            //else if (k == 1)
            //{
            //    MessageBox.Show("Số lượng nhập lớn hơn số lượng đặt. Vui lòng nhập lại số lượng");
            //    return;
            //}
            //else
            //{
                if(ThemCTPN.Enabled == false)
                {
                    try
                    {
                        cTPNBindingSource.EndEdit();
                        cTPNBindingSource.ResetCurrentItem();
                        if (qLVTDataSet.HasChanges())
                        {
                       
                        this.cTPNTableAdapter.Update(this.qLVTDataSet.CTPN);

                            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                        }
                    Program.ExecNonQuery("exec SP_ThemSLT_Vattu '" + tbx_mavt_ct.Text + "', '" + tbx_sl_ct.Text + "'");
                }
                catch(Exception ex)
                    {
                        if (ex.Message.Contains("PK_CTPN"))
                        {
                            MessageBox.Show("Vật tư này đã có trong phiếu nhập, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi ghi chi tiết phiếu nhập. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                        }
                        return;
                    }

                    ThemCTPN.Enabled = true; grbPN.Enabled = true;
                }
          //  }
        }

        private void XoaCTPN_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Bạn có chắc muốn xóa??", "Xác Nhận", MessageBoxButtons.YesNo);
            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    Program.ExecNonQuery("exec SP_GiamSLT_Vattu '" + tbx_mavt_ct.Text + "', '" + tbx_sl_ct.Text + "'");
                    cTPNBindingSource.RemoveCurrent();
                    this.cTPNTableAdapter.Update(this.qLVTDataSet.CTPN);
                    MessageBox.Show("Đã xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa Không Thành Công" + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void UndoCTPN_Click(object sender, EventArgs e)
        {
            cTPNBindingSource.CancelEdit();
            cTPNBindingSource.Position = vitri;
            ThemCTPN.Enabled = true;
            grbPN.Enabled = true;
            btn_refresh.PerformClick();
        }

        private void tbx_dg_ct_TextChanged(object sender, EventArgs e)
        {
           try
            {
                sP_LayDonGia_CTDDHBindingSource.Position = sP_LayDonGia_CTDDHBindingSource.Find("DONGIA", tbx_dg_ct.Text);
            }
            catch { }
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            tbx_dg_ct.Text = textEdit1.Text;
        }

        private void textEdit2_TextChanged(object sender, EventArgs e)
        {
            tbx_sl_ct.Text = textEdit2.Text;
        }

        private void tbx_sl_ct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sP_LaySoLuong_CTDDHBindingSource.Position = sP_LaySoLuong_CTDDHBindingSource.Find("SOLUONG", tbx_sl_ct.Text);
            }
            catch { }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qLVTDataSet.CTPN);
            // TODO: This line of code loads data into the 'qLVTDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
        }
    }
}
