using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiDat
{
   public class SQLHelper
    {
        SqlConnection conn;
        public SQLHelper(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }

        public SQLHelper()
        {
        }

        public bool IsConnection
        {
            get
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return true;
            }
        }

        //Kiểm tra chuỗi cấu hình data LinQ
        public int Check_Config()
        {
            conn = new SqlConnection(Properties.Settings.Default.QLCF_TTHQTConnectionString);
            if (Properties.Settings.Default.QLCF_TTHQTConnectionString == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }
    }
}
