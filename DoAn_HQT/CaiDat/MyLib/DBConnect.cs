using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace MyLib
{
    public class DBConnect
    {
        private SqlConnection connect;
        private string strConnect, strServerName, strDatabaseName;

        #region get,set
        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }

        public string StrDatabaseName
        {
            get { return strDatabaseName; }
            set { strDatabaseName = value; }
        }

        public string StrServerName
        {
            get { return strServerName; }
            set { strServerName = value; }
        }

        public string StrConnect
        {
            get { return strConnect; }
            set { strConnect = value; }
        }
        #endregion

        public DBConnect()
        {
            StrServerName = @"MINHHOA\SQLEXPRESS";
            StrDatabaseName = "QLCF_TTHQT";
            StrConnect = @"Data Source=" + StrServerName + ";Initial Catalog=" + StrDatabaseName + ";Integrated Security=True";
            Connect = new SqlConnection(StrConnect);
        }

        public void openConnection()
        {
            if (Connect.State == ConnectionState.Closed)
                Connect.Open();
        }

        public void closeConnection()
        {
            if (Connect.State == ConnectionState.Open)
                Connect.Close();
        }
        public void disposeConnection()
        {
            if (Connect.State == ConnectionState.Open)
                Connect.Close();
            Connect.Dispose();
        }

        public void updateToDataBase(string strSQL)
        {//update database: thêm, xóa, sửa
            openConnection();
            SqlCommand cmd = new SqlCommand(strSQL, Connect);
            cmd.ExecuteNonQuery();
            closeConnection();
        }
        public SqlConnection get_connect()
        {
            return connect;
        }

        public int getCount(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(strSQL, Connect);

            int dem = (int)cmd.ExecuteScalar();
            closeConnection();
            return dem;
        }

        public SqlDataReader getDataReader(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(strSQL, Connect);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }

        public DataTable getDataTable(string sql, string tablename)
        {
            openConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConnection();
            return dt;
        }

        public void updateToDatabase(string sql, DataTable tablename)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            SqlCommandBuilder cbm = new SqlCommandBuilder(da);
            da.Update(tablename);
        }
    }
}
