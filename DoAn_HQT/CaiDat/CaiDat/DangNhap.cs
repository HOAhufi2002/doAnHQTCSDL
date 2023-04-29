using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaiDat
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
       
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format(@"Data Source=MINHHOA\SQLEXPRESS;Initial Catalog=QLCF_TTHQT;Persist Security Info=True;User ID={0};Password={1};", txtDangNhap.Text, txtMatKhau.Text);
            try
            {
                if (string.IsNullOrEmpty(txtDangNhap.Text.Trim()))
                {
                    MessageBox.Show("Không được bỏ trống Tên đăng nhập");
                    this.txtDangNhap.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtMatKhau.Text))
                {
                    MessageBox.Show("Không được bỏ trống Mật khẩu");
                    this.txtMatKhau.Focus();
                    return;
                }
                appSetting app = new appSetting();
                SQLHelper helper = new SQLHelper(connectionString);
                SQLHelperDataSet dataSet = new SQLHelperDataSet(connectionString);
                if (helper.IsConnection && dataSet.IsConnection)
                {
                    //qL_DangNhap.SaveConfig(cbo_servername.Text, txt_username.Text, txt_password.Text, cbo_database.Text);
                    MessageBox.Show("Bạn đã đăng nhập thành công.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    app.SaveConnectionString("MyLib.Properties.Settings.QLCF_TTHQTConnectionString", connectionString);
                    TrangChinh tc = new TrangChinh();
                    tc.Show();
                  
                    //Application.Restart();
                    //Environment.Exit(0);
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void DangNhap_Load(object sender, EventArgs e)
        {
          
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
      
            this.Close();
        }
    }
}
