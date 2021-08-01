using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace QLVT_PHANTAN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new Form1());
        }

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;

        public static String servername = "";

        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLVT";
        public static String remotelogin = "HOTROKETNOI";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";

        public static String mUser = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0;
        // public static FormChinh formChinh;
        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            conn.Close();
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;

        }

        public static int ExecSqlNonQuery(String cmd, String connectionstring)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand(cmd, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else
                    MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        public static int ExecNonQuery(string strLenh)
        {
            SqlCommand Sqlcmd  = new SqlCommand();
            Sqlcmd.Connection = conn;
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandText = strLenh;
            if(conn.State == ConnectionState.Closed)
            {
                Program.KetNoi();
            }
            try
            {
                Sqlcmd.ExecuteNonQuery();
                return 1;
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message,"Lỗi", MessageBoxButtons.OK);
                return 2;
            }
        }

        public static int ExecMyReturn(String cmd, string maddh, string mavt)
        {
            SqlCommand Sqlcmd = new SqlCommand(cmd, conn);
            Sqlcmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para = new SqlParameter("@ret", SqlDbType.Int);
            para.Direction = ParameterDirection.ReturnValue;
            Sqlcmd.Parameters.Add(para);
            Sqlcmd.Parameters.Add(new SqlParameter("@maddh", maddh));
            Sqlcmd.Parameters.Add(new SqlParameter("@mavt", mavt));

            Sqlcmd.ExecuteNonQuery();
               // conn.Close();
            return Convert.ToInt32(para.Value);
        }

        public static int ExecMyReturn2(String cmd, string maddh, string mavt, int soluong)
        {
            SqlCommand Sqlcmd = new SqlCommand(cmd, conn);
            Sqlcmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para = new SqlParameter("@ret", SqlDbType.Int);
            para.Direction = ParameterDirection.ReturnValue;
            Sqlcmd.Parameters.Add(para);
            Sqlcmd.Parameters.Add(new SqlParameter("@maddh", maddh));
            Sqlcmd.Parameters.Add(new SqlParameter("@mavt", mavt));
            Sqlcmd.Parameters.Add(new SqlParameter("@soluong", soluong));

            Sqlcmd.ExecuteNonQuery();
        //    conn.Close();
            return Convert.ToInt32(para.Value);
        }

        public static int ExecMyReturn3(String cmd, int soluong, string mavt)
        {
            SqlCommand Sqlcmd = new SqlCommand(cmd, conn);
            Sqlcmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para = new SqlParameter("@ret", SqlDbType.Int);
            para.Direction = ParameterDirection.ReturnValue;
            Sqlcmd.Parameters.Add(para);
            Sqlcmd.Parameters.Add(new SqlParameter("@soluongxuat", soluong));
            Sqlcmd.Parameters.Add(new SqlParameter("@mavt", mavt));
           

            Sqlcmd.ExecuteNonQuery();
            //    conn.Close();
            return Convert.ToInt32(para.Value);
        }

    }
}
