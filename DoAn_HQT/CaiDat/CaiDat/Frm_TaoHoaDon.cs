using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyLib;
using System.Data.SqlClient;

namespace CaiDat
{
    public partial class Frm_TaoHoaDon : Form
    {
        DBConnect con = new DBConnect();
        DataTable dtDSNhanVien, dtDSBan;
        DataColumn[] keyNV = new DataColumn[1];
        DataColumn[] keyBan = new DataColumn[1];
        public Frm_TaoHoaDon()
        {
            InitializeComponent();
          
        }


        #region Load dữ liệu
        //Load combobox tên nhân viên
        public void loadComboboxNhanVien()
        {
            string sql = "exec TT_NHANVIEN";
            dtDSNhanVien = con.getDataTable(sql, "NHANVIEN");
            keyNV[0] = dtDSNhanVien.Columns["MANV"];
            dtDSNhanVien.PrimaryKey = keyNV;
            cbo_NhanVien.DataSource = dtDSNhanVien;
            cbo_NhanVien.DisplayMember = "TENNV";
            cbo_NhanVien.ValueMember = "MANV";
        }
        //Load combobox bàn
        public void loadComboboxBan()
        {
            string sql = "exec DS_BAN";
            dtDSBan = con.getDataTable(sql, "BAN");
            keyBan[0] = dtDSBan.Columns["MABAN"];
            dtDSBan.PrimaryKey = keyBan;
            cbo_Ban.DataSource = dtDSBan;
            cbo_Ban.DisplayMember = "SOBAN";
            cbo_Ban.ValueMember = "MABAN";
        }
        #endregion

        private void Frm_TaoHoaDon_Load(object sender, EventArgs e)
        {
            mtxt_NgayBan.Text = DateTime.Now.ToString();
            loadComboboxNhanVien();
            loadComboboxBan();
            txt_TongTien.Enabled = false;
        }

        #region Nút Ok tạo hóa đơn
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("exec THEM_HD '{0}','{1}','{2}',null", cbo_NhanVien.SelectedValue, cbo_Ban.SelectedValue, mtxt_NgayBan.Text);
                con.updateToDataBase(sql);
                MessageBox.Show("Tạo hóa đơn thành công");
              
            }
            catch
            {
                MessageBox.Show("Tạo hóa đơn thất bại");
            }
            this.Hide();
        }

        private void mtxt_NgayBan_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        #endregion

        #region Nút thoát
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
                this.Close();
        }
        #endregion
    }
}
