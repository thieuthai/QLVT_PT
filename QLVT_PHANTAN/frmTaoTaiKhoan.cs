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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        string giatriRole;
        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.Nhanvien1' table. You can move, or remove it, as needed.
            this.nhanvien1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanvien1TableAdapter.Fill(this.qLVTDataSet.Nhanvien1);
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
            this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr; 
            this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);

            nhanvien1ComboBox.SelectedIndex = 1; nhanvien1ComboBox.SelectedIndex = 0;

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if(Program.mGroup != "CongTy")
            {
                groupBox2.Enabled = false;
            }
            else
            {
                grb_role.Visible = false;
            }

        }

        private void nhanvien1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhanvien1ComboBox.SelectedIndex == -1) return;

            tbx_manv.Text = nhanvien1ComboBox.SelectedValue.ToString();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedIndex == -1) return;

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
            if(Program.KetNoi() == 0)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu cho chi nhánh không đúng.", "Lỗi đăng nhập.", MessageBoxButtons.OK);
                return;
            }else
            {
                // TODO: This line of code loads data into the 'qLVTDataSet.Nhanvien1' table. You can move, or remove it, as needed.
                this.nhanvien1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanvien1TableAdapter.Fill(this.qLVTDataSet.Nhanvien1);
                // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
                this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
                nhanvien1ComboBox.SelectedIndex = 1; nhanvien1ComboBox.SelectedIndex = 0;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbx_tendn.Text == "" || tbx_mk.Text == "") 
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu phải đầy đủ.");
                return;
            }

          
            string sql = "SELECT NAME FROM SYS.SYSUSERS WHERE NAME= '" + tbx_manv.Text.ToString() + "'";
            SqlDataReader reader;
            reader = Program.ExecSqlDataReader(sql);
            if (reader.HasRows)
            {
                MessageBox.Show("Nhân viên này đã có tài khoản.", "Lỗi", MessageBoxButtons.OK);
                reader.Close();
                return;
            }
            reader.Close();

            if (Program.mGroup == "CongTy")
            {
                giatriRole = "CongTy";
                try
                {
                    this.sp_TaoTaiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_TaoTaiKhoanTableAdapter.Fill(qLVTDataSet.sp_TaoTaiKhoan, tbx_tendn.Text, tbx_mk.Text, tbx_manv.Text, giatriRole);

                    MessageBox.Show("Tạo tài khoản thành công!");
                    tbx_tendn.Text = "";
                    tbx_mk.Text = "";
                    tbx_tendn.Focus();
                }catch(Exception ex)
                {
                    MessageBox.Show("Lỗi tạo tài khoản." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                if (radioCN.Checked)
                {
                    giatriRole = "ChiNhanh";
                }else if (radioNV.Checked)
                {
                    giatriRole = "NhanVien";
                }

                try
                {
                    this.sp_TaoTaiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_TaoTaiKhoanTableAdapter.Fill(qLVTDataSet.sp_TaoTaiKhoan, tbx_tendn.Text, tbx_mk.Text, tbx_manv.Text, giatriRole);

                    MessageBox.Show("Tạo tài khoản thành công!");
                    tbx_tendn.Text = "";
                    tbx_mk.Text = "";
                    tbx_tendn.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tạo tài khoản." + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
                    return;
                }

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
