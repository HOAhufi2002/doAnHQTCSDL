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
    public partial class DanhMucNV : Form
    {
        public DanhMucNV()
        {
            InitializeComponent();
        }
        appSetting ketnoi = new appSetting();
     
        public DataTable lay_Data_Grv_Sinhvien()
        {
                ketnoi.GetConnectionString("MyLib.Properties.Settings.QLCF_TTHQTConnectionString");
                string str = "hienthinhanvien";
                DataTable ds = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.GetConnectionString("MyLib.Properties.Settings.QLCF_TTHQTConnectionString"));
                da.Fill(ds);
                return ds;
                
        }
     
        public void load()
        {
            dgv_nhanvien.DataSource = lay_Data_Grv_Sinhvien();
            HienThiGioiTinh();
            HienThiChucVu();
            label9.Text = (dgv_nhanvien.RowCount - 1).ToString();
        }
        void HienThiGioiTinh()
        {
            using (conn = new SqlConnection(SqlconString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("cbboxgt", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable gt = new DataTable();
                da.Fill(gt);
                cb_gioitinh.DataSource = gt;
                cb_gioitinh.DisplayMember = "GIOITINH";
                conn.Close();
            }
          
          


        }
        void HienThiChucVu()
        {

          
            using (conn = new SqlConnection(SqlconString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("cbboxcv", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable gt = new DataTable();
                da.Fill(gt);

                cb_chucvu.DataSource = gt;
                cb_chucvu.DisplayMember = "CHUCVU";
                
                conn.Close();
            }


        }
        private void DanhMucNV_Load(object sender, EventArgs e)
        {

            load();
            HienThiGioiTinh();
            HienThiChucVu();
        }
   
        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        SqlConnection conn = null;
        String SqlconString = ConfigurationManager.ConnectionStrings["MyLib.Properties.Settings.QLCF_TTHQTConnectionString"].ConnectionString;
        private void button3_Click(object sender, EventArgs e)
        {
             using (conn = new SqlConnection(SqlconString))
                {
                   
                        try
                        {
                            conn.Open();
                            SqlCommand sql_cmnd = new SqlCommand("DeleteNV", conn);
                            sql_cmnd.CommandType = CommandType.StoredProcedure;
                            sql_cmnd.Parameters.AddWithValue("@MANV", SqlDbType.VarChar).Value = txt_manv.Text;
                            int i = sql_cmnd.ExecuteNonQuery();
                            if (i >= 1)
                            {
                                MessageBox.Show(" thành công ");
                                load();
                            }
                            else
                                MessageBox.Show(" thất bại");
                            conn.Close();
                        }
                     
                        catch
                        {
                            MessageBox.Show(" Bạn không có quyền ");
                        }
           
                }
            
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_manv.Enabled = true;
            txt_datetime.Clear();
            txt_diachi.Clear();
            txt_manv.Clear();
            txt_sdt.Clear();
            txt_tennhanvien.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
          using (conn = new SqlConnection(SqlconString))
            {
               
                try
                {
                    conn.Open();

                    SqlCommand cm = new SqlCommand("UpdateNV", conn);
                    cm.Parameters.AddWithValue("@MANV", txt_manv.Text);
                    cm.Parameters.AddWithValue("@TENNV", txt_tennhanvien.Text);
                    cm.Parameters.AddWithValue("@DIACHI", txt_diachi.Text);
                    cm.Parameters.AddWithValue("@GIOITINH", cb_gioitinh.Text);
                    cm.Parameters.AddWithValue("@NGAYSINH", txt_datetime.Text);
                    cm.Parameters.AddWithValue("@SDT", txt_sdt.Text);
                    cm.Parameters.AddWithValue("@CHUCVU", cb_chucvu.Text);
                    cm.CommandType = CommandType.StoredProcedure;

                    int i = cm.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        MessageBox.Show("Sửa Nhân Viên thành công!", "Đã thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Sửa Nhân Viên thất bại!");
                    load();
                    conn.Close();
                }

                catch
                {
                    MessageBox.Show(" Bạn không có quyền  ");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_manv.Enabled = false;
            txt_tennhanvien.Focus();

        }

        private void dgv_nhanvien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_nhanvien.SelectedRows)
            {

                txt_manv.Text = row.Cells[0].Value.ToString();
                txt_tennhanvien.Text = row.Cells[1].Value.ToString();
                txt_diachi.Text = row.Cells[2].Value.ToString();
                cb_gioitinh.Text = row.Cells[3].Value.ToString();
                txt_sdt.Text = row.Cells[5].Value.ToString();
                txt_datetime.Text = row.Cells[4].Value.ToString();
                cb_chucvu.Text = row.Cells[6].Value.ToString();

            }
        }
        DangNhap dn = new DangNhap();
        private void button2_Click_1(object sender, EventArgs e)
        {
           
             
            using (conn = new SqlConnection(SqlconString))
            {
                if (txt_manv.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" vui lòng nhập ");
                    return;
                }    
                else
                try
                {

                    conn.Open();

                    String ngay = String.Format("{0:MM/dd/yyyy}", txt_datetime.Text);
                    SqlCommand cm = new SqlCommand("InsertNV1", conn);
                    cm.Parameters.AddWithValue("@MANV", txt_manv.Text);
                    cm.Parameters.AddWithValue("@TENNV", txt_tennhanvien.Text);
                    cm.Parameters.AddWithValue("@DIACHI", txt_diachi.Text);
                    cm.Parameters.AddWithValue("@GIOITINH", cb_gioitinh.Text);
                    cm.Parameters.AddWithValue("@NGAYSINH", ngay);
                    cm.Parameters.AddWithValue("@SDT", txt_sdt.Text);
                    cm.Parameters.AddWithValue("@CHUCVU", cb_chucvu.Text);
                    cm.CommandType = CommandType.StoredProcedure;
                     int i = cm.ExecuteNonQuery();
                    if(i>=1 )
                    {
                        MessageBox.Show(" thêm nhân viên thành công ");
                    }    
                    else

                        MessageBox.Show(" thêm nhân viên thất bại");
                    load();

                    conn.Close();
                }

                catch
                {
                    MessageBox.Show("  Bạn không có quyền  ");
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
