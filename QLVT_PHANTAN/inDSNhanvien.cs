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
    public partial class inDSNhanvien : Form
    {
        public inDSNhanvien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rpt_nhanvien obj;
            obj = new rpt_nhanvien();
            try
            {
                string strLenh;
                strLenh = "EXEC [dbo].SP_inNhanvien";
                SqlDataReader reader;
                reader = Program.ExecSqlDataReader(strLenh);
                DataTable table = new DataTable();
                table.Load(reader);
                obj.SetDataSource(table);
                crystalReportViewer1.ReportSource = obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inDSNhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
            this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);

            cbxChiNhanh.DataSource = Program.bds_dspm;
            cbxChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup != "CongTy")
            {
                groupBox2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChiNhanh.SelectedIndex == -1) return;

            Program.servername = cbxChiNhanh.SelectedValue.ToString();

            if(cbxChiNhanh.SelectedIndex != Program.mChinhanh)
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
                MessageBox.Show("Lỗi đăng nhập ở server phân mảnh.");
                return;
            }
            else
            {
                this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
                button1.PerformClick();
            }
        }
    }
}
