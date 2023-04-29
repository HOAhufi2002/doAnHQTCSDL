using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyLib;
using System.Configuration;
namespace CaiDat
{
    public partial class DanhMucSP : Form
    {
        public DanhMucSP()
        {
            InitializeComponent();
        }
        appSetting ketnoi = new appSetting();
        SqlConnection conn = null;
        String SqlconString = ConfigurationManager.ConnectionStrings["MyLib.Properties.Settings.QLCF_TTHQTConnectionString"].ConnectionString;
        public DataTable lay_Data_Grv_sp()
        {
            ketnoi.GetConnectionString("MyLib.Properties.Settings.QLCF_TTHQTConnectionString");
            string str = "exec danhmucsp";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.GetConnectionString("MyLib.Properties.Settings.QLCF_TTHQTConnectionString"));
            da.Fill(ds);
            return ds;
        }
        public void tongsanpham()
        {
            using (conn = new SqlConnection(SqlconString))
            {
                conn.Open();
                SqlCommand cm = new SqlCommand("tongsp", conn);
                cm.CommandType = CommandType.StoredProcedure;
                label8.Text = cm.ExecuteScalar().ToString();
                conn.Close();
            }
        }
        public void load()
        {
            dataGridView1.DataSource = lay_Data_Grv_sp();
            hienthiloai();
            tongsanpham();



        }
   
        void hienthiloai()
        {
            using (conn = new SqlConnection(SqlconString))
            {
                SqlCommand cmd = new SqlCommand("cbboxloai", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable gt = new DataTable();
                da.Fill(gt);
                cb_loai.DataSource = gt;
                cb_loai.DisplayMember = "TenLoai";
                cb_loai.ValueMember = "maloai";
            }



        }
        private void DanhMucSP_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        SqlCommand cm;
        private void button2_Click(object sender, EventArgs e)
        {
            //@MASP,@MALOAI,@TENSP,@SLconlai,@DVT,@DonGia
            if(txt_masp.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" vui lòng nhập ");
                return;
            }    
            try
            {
                using (conn = new SqlConnection(SqlconString))
                {
                    conn.Open();
                    SqlCommand cm = new SqlCommand("insertsp", conn);
                    cm.Parameters.AddWithValue("@MASP", txt_masp.Text);
                    cm.Parameters.AddWithValue("@MALOAI", cb_loai.SelectedValue.ToString());
                    cm.Parameters.AddWithValue("@TENSP", txt_tensp.Text);
                    cm.Parameters.AddWithValue("@DVT", txt_donvitinh.Text);
                    cm.Parameters.AddWithValue("@DonGia", txt_giaban.Text);


                    cm.CommandType = CommandType.StoredProcedure;

                    int i = cm.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        MessageBox.Show(" thành công ");
                        load();
                    }
                    else MessageBox.Show(" thất bại");
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show(" bạn không có quyền thực hiện thao tác này");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (conn = new SqlConnection(SqlconString))
                {
                    conn.Open();
                    SqlCommand cm = new SqlCommand("DeleteSP", conn);
                    cm.Parameters.AddWithValue("@MASP", txt_masp.Text);
                    cm.CommandType = CommandType.StoredProcedure;
                    int i = cm.ExecuteNonQuery();

                    if (i >= 1)
                    {
                        MessageBox.Show(" thành công ");
                        load();
                    }
                    else MessageBox.Show(" thất bại");
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show(" bạn không có quyền thực hiện thao tác này");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_masp.Enabled = false;
            txt_tensp.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
            try
            {
                using (conn = new SqlConnection(SqlconString))
                {
                    conn.Open();
                    SqlCommand cm = new SqlCommand("UpdateSP", conn);
                    cm.Parameters.AddWithValue("@MASP", txt_masp.Text);
                    cm.Parameters.AddWithValue("@MALOAI", cb_loai.SelectedValue.ToString());
                    cm.Parameters.AddWithValue("@TENSP", txt_tensp.Text);

                    cm.Parameters.AddWithValue("@DVT", txt_donvitinh.Text);
                    cm.Parameters.AddWithValue("@DonGia", txt_giaban.Text);

                    cm.CommandType = CommandType.StoredProcedure;

                    int i = cm.ExecuteNonQuery();

                    if (i >= 1)
                    {
                        MessageBox.Show(" thành công ");
                        load();
                    }
                    else MessageBox.Show(" thất bại");
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show(" bạn không có quyền thực hiện thao tác này");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_masp.Enabled = true;
            txt_masp.Clear();
       
            txt_tensp.Clear();
            txt_donvitinh.Clear();
            txt_giaban.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                txt_masp.Text = row.Cells[0].Value.ToString();
                txt_tensp.Text = row.Cells[2].Value.ToString();
                cb_loai.Text = row.Cells[1].Value.ToString();
                txt_giaban.Text = row.Cells[4].Value.ToString();
                txt_donvitinh.Text = row.Cells[3].Value.ToString();
            }
        }
    
        private void label8_Click(object sender, EventArgs e)
        {
            
        }
    }
}
