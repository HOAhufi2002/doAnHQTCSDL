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
using MyLib;
using System.Configuration;
namespace CaiDat
{
    public partial class Frm_DoanhThu : Form
    {
        DBConnect con = new DBConnect();
        DataTable dtHoaDon, dtTong;
        DataColumn[] key = new DataColumn[1];
        appSetting ketnoi = new appSetting();
        SqlConnection conn = null;
        String SqlconString = ConfigurationManager.ConnectionStrings["MyLib.Properties.Settings.QLCF_TTHQTConnectionString"].ConnectionString;
        public Frm_DoanhThu()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
                this.Close();
        }
        public DataTable lay_Data_Grv_HD()
        {
            
                ketnoi.GetConnectionString("MyLib.Properties.Settings.QLCF_TTHQTConnectionString");
                string str = "doanhthu";
                DataTable ds = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.GetConnectionString("MyLib.Properties.Settings.QLCF_TTHQTConnectionString"));
                da.Fill(ds);
                return ds;
         

        }

        public void loadData()
        {


            try
            {
                data_DSHoaDon.DataSource = lay_Data_Grv_HD();
            }
            catch
            {
                MessageBox.Show("Bạn không có quyền xem ");
                return;
            }
        }
        //public void tonghoadon()
        //{
        //    using (conn = new SqlConnection(SqlconString))
        //    {
        //        conn.Open();
        //        SqlCommand cm = new SqlCommand("DEM_HOADON {0}", conn);
        //        cm.CommandType = CommandType.StoredProcedure;
        //        label2.Text = cm.ExecuteScalar().ToString();
        //        conn.Close();
        //    }
        //}

        private void Frm_DoanhThu_Load(object sender, EventArgs e)
        {
            loadData();
            //tonghoadon();
        
        }

        //Tính tổng tiền
        public float tinhTongTienDoanhThu( string ngayban)
        {
            float tong = 0;
            string sql = string.Format("set dateformat dmy exec TIMKIEM_NGAY '{0}'", mtxt_NgayBan.Text);
            SqlDataReader rd = con.getDataReader(sql);
            while (rd.Read())
            {
                tong += int.Parse(rd["TONGTIEN"].ToString());
            }
            rd.Close();
            con.closeConnection();
            return tong;
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (mtxt_NgayBan.Text.Trim().Length < 10)
            {
                MessageBox.Show("Ngày sai, vui lòng nhập lại ngày");
                return;
            }
            string sql = string.Format("set dateformat dmy exec TIMKIEM_NGAY '{0:dd/M/YYYY}'", mtxt_NgayBan.Text);
            dtHoaDon = con.getDataTable(sql, "HOADON");
            //Tạo khóa chính
            key[0] = dtHoaDon.Columns["MaHD"];
            dtHoaDon.PrimaryKey = key;
            data_DSHoaDon.DataSource = dtHoaDon;
            txt_TongTienDoanhThu.Text = tinhTongTienDoanhThu(mtxt_NgayBan.Text).ToString();

        }
    }
}
