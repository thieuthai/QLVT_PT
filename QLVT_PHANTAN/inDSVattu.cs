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
    public partial class inDSVattu : Form
    {
        public inDSVattu()
        {
            InitializeComponent();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            rpt_vattu obj;
            obj = new rpt_vattu();
            try
            {
                string strLenh;
                strLenh = "EXEC [dbo].SP_inVattu";
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
    }
}
