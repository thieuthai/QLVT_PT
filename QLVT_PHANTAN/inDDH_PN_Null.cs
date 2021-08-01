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
    public partial class inDDH_PN_Null : Form
    {
        public inDDH_PN_Null()
        {
            InitializeComponent();
        }

        private void btn_inphieu_Click(object sender, EventArgs e)
        {
            rpt_ddh_pn_null obj;
            obj = new rpt_ddh_pn_null();
            try
            {
                string strLenh;
                strLenh = "EXEC [dbo].SP_inDDH_PN_NULL";
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

        private void inDDH_PN_Null_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_DanhsachChinhanh' table. You can move, or remove it, as needed.
            this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);

            sp_DanhsachChinhanhComboBox.DataSource = Program.bds_dspm;
            sp_DanhsachChinhanhComboBox.SelectedIndex = Program.mChinhanh;

            if(Program.mGroup != "CongTy")
            {
                groupBox2.Enabled = false;
            }
           
        }

        private void sp_DanhsachChinhanhComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sp_DanhsachChinhanhComboBox.SelectedIndex == -1) return;

            Program.servername = sp_DanhsachChinhanhComboBox.SelectedValue.ToString();

            if(sp_DanhsachChinhanhComboBox.SelectedIndex != Program.mChinhanh)
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
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu ở chi nhánh.");
                return;
            }
            else
            {
                this.sp_DanhsachChinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_DanhsachChinhanhTableAdapter.Fill(this.qLVTDataSet.sp_DanhsachChinhanh);
                btn_inphieu.PerformClick();
            }
        }
    }
}
