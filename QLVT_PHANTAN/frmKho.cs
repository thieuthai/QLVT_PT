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
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        int vitri = 0;
        private void frmKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
            this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
            // TODO: This line of code loads data into the 'qLVTDataSet.ChiNhanh1' table. You can move, or remove it, as needed.
         //   this.chiNhanh1TableAdapter.Fill(this.qLVTDataSet.ChiNhanh1);
            // TODO: This line of code loads data into the 'qLVTDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);
            // TODO: This line of code loads data into the 'qLVTDataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVTDataSet.DatHang);
            // TODO: This line of code loads data into the 'qLVTDataSet.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);


            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if(Program.mGroup != "CongTy")
            {
                groupBox2.Enabled = false;
            }
            else
            {
                btn_ghi.Enabled = false;
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_phuchoi.Enabled = false;
            }
                

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedIndex == -1) return;

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
            {
                MessageBox.Show("Loi ket noi");
                return;
            }
           else
            {
               
                this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
                // TODO: This line of code loads data into the 'qLVTDataSet.ChiNhanh1' table. You can move, or remove it, as needed.
            //    this.chiNhanh1TableAdapter.Fill(this.qLVTDataSet.ChiNhanh1);
                // TODO: This line of code loads data into the 'qLVTDataSet.Kho' table. You can move, or remove it, as needed.
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);
                // TODO: This line of code loads data into the 'qLVTDataSet.DatHang' table. You can move, or remove it, as needed.
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.qLVTDataSet.DatHang);
                // TODO: This line of code loads data into the 'qLVTDataSet.PhieuXuat' table. You can move, or remove it, as needed.
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);
              //  label1.Text = Program.mlogin;

            }
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_them.Enabled = false;
            khoBindingSource.AddNew();
     
            if (cmbChiNhanh.SelectedIndex == 0)
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
            if (tbx_makho.Text == "")
            {
                MessageBox.Show("Mã kho không được thiếu");
                tbx_makho.Focus();
                return;
            }
            if (tbx_tenkho.Text == "")
            {
                MessageBox.Show("Tên kho không được thiếu");
                tbx_tenkho.Focus();
                return;
            }
            if (tbx_diachi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu");
                tbx_diachi.Focus();
                return;
            }
            if (tbx_macn.Text == "")
            {
                MessageBox.Show("Mã chi nhánh không được thiếu");
                tbx_macn.Focus();
                return;
            }
            if (btn_them.Enabled == false)
            {
                string sql = "if exists (select MAKHO from Kho where MAKHO = '" + tbx_makho.Text.Trim() + "') select MAKHO from Kho where MAKHO = '" + tbx_makho.Text.Trim() + "' else select MAKHO from LINK1.QLVT.DBO.Kho where MAKHO = '" + tbx_makho.Text.Trim() + "'";
                SqlDataReader reader;
                reader = Program.ExecSqlDataReader(sql);
                if (reader.HasRows)
                {
                    MessageBox.Show("Mã kho này đã tồn tại ở Chi nhánh này hoặc Chi nhánh khác", "Lỗi", MessageBoxButtons.OK);
                    reader.Close();
                    return;
                }
                reader.Close();

                try
                {
                    khoBindingSource.EndEdit();
                    khoBindingSource.ResetCurrentItem();
                    if (qLVTDataSet.HasChanges())
                    {
                        this.khoTableAdapter.Update(this.qLVTDataSet.Kho);
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch(Exception ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Mã kho bị trùng, vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK);
                    }
                    else if (ex.Message.Contains("IX_Kho")){
                        MessageBox.Show("Tên kho không được phép trùng, vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi kho. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    }
                    return;
                }
                btn_them.Enabled = true;
                // chiNhanh1ComboBox.Enabled = true;
            }else
            {
                try
                {
                    khoBindingSource.EndEdit();
                    khoBindingSource.ResetCurrentItem();
                    if (qLVTDataSet.HasChanges())
                    {
                        this.khoTableAdapter.Update(this.qLVTDataSet.Kho);
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch(Exception ex)
                {
                        MessageBox.Show("Lỗi ghi nhân viên. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
        }

    

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(datHangBindingSource.Count > 0)
            {
                MessageBox.Show("Kho này đã đặt hàng, không xóa được.");
            }
            if(phieuXuatBindingSource.Count > 0)
            {
                MessageBox.Show("Kho này đã xuất hàng, không xóa được.");
            }

            DialogResult xacNhan = MessageBox.Show("Bạn có chắc muốn xóa??", "Xác Nhận", MessageBoxButtons.YesNo);
            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    khoBindingSource.RemoveCurrent();
                    this.khoTableAdapter.Update(this.qLVTDataSet.Kho);
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

        private void btn_phuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            khoBindingSource.CancelEdit();
            khoBindingSource.Position = vitri;
            tbx_makho.Enabled = true;
            btn_them.Enabled = true;
            frmKho_Load(sender, e);
            
        }
    }
}
