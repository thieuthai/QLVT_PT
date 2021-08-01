using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_PHANTAN
{
    public partial class frmVattu : Form
    {
        public frmVattu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        Int32 vitri = 0;
       

        private void frmVattu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
            this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
            // TODO: This line of code loads data into the 'qLVTDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qLVTDataSet.Vattu);
            // TODO: This line of code loads data into the 'qLVTDataSet.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);
            // TODO: This line of code loads data into the 'qLVTDataSet.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qLVTDataSet.CTPN);
            // TODO: This line of code loads data into the 'qLVTDataSet.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.qLVTDataSet.CTPX);


            // cmbChiNhanh.SelectedIndex = 1; cmbChiNhanh.SelectedIndex = 0;
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

            tbx_mavt.Enabled = false;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_them.Enabled = false;
            tbx_mavt.Enabled = true;
            vattuBindingSource.AddNew();
            tbx_slt.Text = "0";
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cTDDHBindingSource.Count > 0 || cTPNBindingSource.Count > 0 || cTPXBindingSource.Count > 0)
            {
                MessageBox.Show("Vật tư này đã được sử dụng, không được xóa!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

            DialogResult xacNhan = MessageBox.Show("Bạn có chắc muốn xóa??", "Xác Nhận", MessageBoxButtons.YesNo);
            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    vattuBindingSource.RemoveCurrent();
                    this.vattuTableAdapter.Update(this.qLVTDataSet.Vattu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa Không Thành Công" + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btn_ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbx_mavt.Text == "")
            {
                MessageBox.Show("Mã vật tư không được thiếu");
                tbx_mavt.Focus();
                return;
            }
            if (tbx_tenvt.Text == "")
            {
                MessageBox.Show("Tên vật tư không được thiếu");
                tbx_tenvt.Focus();
                return;
            }
            if (tbx_dvt.Text == "")
            {
                MessageBox.Show("Đơn vị tính không được thiếu");
                tbx_dvt.Focus();
                return;
            }
            if (tbx_slt.Text == "")
            {
                MessageBox.Show("Số lượng tồn không được thiếu");
                tbx_slt.Focus();
                return;
            }

            if (Double.Parse(tbx_slt.Text) < 0)
            {
                MessageBox.Show("Số lượng tồn không được bé hơn 0.");
                tbx_slt.Focus();
                return;
            }
            if (btn_them.Enabled == false)
            {
                try
                {
                    vattuBindingSource.EndEdit();
                    vattuBindingSource.ResetCurrentItem();
                    if (qLVTDataSet.HasChanges())
                    {
                        this.vattuTableAdapter.Update(this.qLVTDataSet.Vattu);
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {

                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Mã vật tư Bị Trùng, vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK);
                    }
                    else if (ex.Message.Contains("IX_Vattu"))
                    {
                        MessageBox.Show("Tên vật tư này đã được sử dụng.", "Lỗi", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi vật tư. Kiểm tra lại dữ liệu." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    }
                    return;
                }
                btn_them.Enabled = true;
                tbx_mavt.Enabled = false;
            }
            else
            {
                try
                {
                    vattuBindingSource.EndEdit();
                    vattuBindingSource.ResetCurrentItem();
                    if (qLVTDataSet.HasChanges())
                    {
                        this.vattuTableAdapter.Update(this.qLVTDataSet.Vattu);
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
            vattuBindingSource.CancelEdit();
            btn_them.Enabled = true;
            tbx_mavt.Enabled = false;
            vattuBindingSource.Position = vitri;
        }

        private void btn_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;

            if (cmbChiNhanh.SelectedIndex == -1 )
            {
                return;
            }
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

            if(cmbChiNhanh.SelectedIndex != Program.mChinhanh)
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
                // TODO: This line of code loads data into the 'qLVTDataSet.Vattu' table. You can move, or remove it, as needed.
                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Fill(this.qLVTDataSet.Vattu);
                // TODO: This line of code loads data into the 'qLVTDataSet.CTDDH' table. You can move, or remove it, as needed.
                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);
                // TODO: This line of code loads data into the 'qLVTDataSet.CTPN' table. You can move, or remove it, as needed.
                this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPNTableAdapter.Fill(this.qLVTDataSet.CTPN);
                // TODO: This line of code loads data into the 'qLVTDataSet.CTPX' table. You can move, or remove it, as needed.
                this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPXTableAdapter.Fill(this.qLVTDataSet.CTPX);

             //   label1.Text = cmbChiNhanh.SelectedIndex.ToString();
            }
        }
    }
}
