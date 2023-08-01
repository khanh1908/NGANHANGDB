using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace NGANHANG
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static SqlConnection conn = new SqlConnection();
        public static string connstr;
        //public static string connstr_publisher = "Data Source=LAPTOP-8SBAMO62;Initial Catalog=NGANHANG;Integrated Security=True";
        public static string connstr_publisher = "Data Source=LAPTOP-8SBAMO62;Initial Catalog=NGANHANG;User ID=sa;Pwd=123456";

        public static SqlDataReader myReader;
        public static string servername = "";
        public static string username = "";
        public static string mlogin = "";
        public static string password = "";

        public static string database = "NGANHANG";
        public static string remotelogin = "HTKN";
        public static string remotepassword = "123456";
        public static string mloginDN = "";
        public static string passwordDN = "";
        public static string mGroup = "";
        public static string mHoten = "";
        public static int mChinhanh = 0;

        public static BindingSource bds_dspm = new BindingSource();
        public static FormMain frmMain;

        public static int KetNoi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                connstr = "Data Source=" + servername +
                                    ";Initial Catalog=" + database +
                                    ";User ID=" + mlogin +
                                    ";Pwd=" + password;
                conn.ConnectionString = connstr;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối csdl.\nBạn xem lại username và password.\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader execSqlDataReader(string query)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(query, conn);
            sqlcmd.CommandType = CommandType.Text;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable execSqlDataTable(string query)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int execSqlNonQuery(string query)
        {
            SqlCommand sqlcmd = new SqlCommand(query, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMain = new FormMain();
            Application.Run(frmMain);
        }
    }
}
