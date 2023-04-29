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
using System.Data;

namespace CaiDat
{
    public partial class LapHoaDonBan : Form
    {
        DBConnect con = new DBConnect();
        DataTable dtDSHoaDon,dtDSCTHD, dtDSDanPham;
        DataColumn[] keyHD = new DataColumn[1];
        DataColumn[] keyCTHD = new DataColumn[1];
        DataColumn[] keySP = new DataColumn[1];
        public LapHoaDonBan()
        {
            InitializeComponent();
        }

        #region Hàm phụ
        //Tương tác trên data gridview
        public void tuongTacDataGridView()
        {
            data_DSHoaDon.ReadOnly = true;
            data_DSHoaDon.AllowUserToAddRows = false;

            data_DSChiTietHD.ReadOnly = true;
            data_DSChiTietHD.AllowUserToAddRows = false;
        }
        //Lấy đơn giá từng sản phẩm
        public float layDonGia(string ma)
        {
            float donGia = 0;
            string sql = string.Format("exec TT_SANPHAM_MA '{0}'",ma);
            SqlDataReader rd = con.getDataReader(sql);
            if(rd.Read())
            {
                donGia = float.Parse(rd["DONGIA"].ToString());
            }
            rd.Close();
            con.closeConnection();
            return donGia;
        }
        //Tính tổng tiền
        public float tinhTongTien(string ma)
        {
            float tong = 0;
            string sql = string.Format("exec DS_CTHD '{0}'", txt_MaHD.Text);
            SqlDataReader rd = con.getDataReader(sql);
            while(rd.Read())
            {
                tong += float.Parse(rd["THANHTIEN"].ToString());
            }
            rd.Close();
            con.closeConnection();
            return tong;
        }
        //Tính thành tiền
        public void capNhatThanhTien()
        {
            try
            {
                int sl = Convert.ToInt32(txt_SoLuong.Text);
                float donGia = layDonGia(cbo_TenSanPham.SelectedValue.ToString());
                float thanhTien = donGia * sl;
                txt_ThanhTien.Text = Convert.ToString(thanhTien);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
        }
        #endregion

        #region Nút tạo hóa đơn mới
        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            Frm_TaoHoaDon taoHD = new Frm_TaoHoaDon();
            taoHD.Show();
        }
        #endregion

        #region Load dữ liệu
        //Load danh sách các hóa đơn
        public void loadDataDSHoaDon()
        {
            string sql = "exec DS_HOADON";
            dtDSHoaDon = con.getDataTable(sql, "HOADON");
            keyHD[0] = dtDSHoaDon.Columns["MAHD"];
            dtDSHoaDon.PrimaryKey = keyHD;
            data_DSHoaDon.DataSource = dtDSHoaDon;
            data_DSHoaDon.Columns["MAHD"].HeaderText = "Mã hóa đơn";
            data_DSHoaDon.Columns["MANV"].HeaderText = "Mã nhân viên";
            data_DSHoaDon.Columns["MABAN"].HeaderText = "Mã bàn";
            data_DSHoaDon.Columns["NGAYBAN"].HeaderText = "Ngày bán";
            data_DSHoaDon.Columns["TONGTIEN"].HeaderText = "Tổng tiền";

            data_DSHoaDon.Columns["MAHD"].Width = 130;
            data_DSHoaDon.Columns["MANV"].Width = 150;

            dataBindingHD();
        }
        //Load các chi tiết hóa đơn
        public void loadDataCTHD()
        {
            string sql = string.Format("exec DS_CTHD '{0}'",txt_MaHD.Text);
            dtDSCTHD = con.getDataTable(sql, "CHITIETHD");
            keyCTHD[0] = dtDSCTHD.Columns["MASP"];
            dtDSCTHD.PrimaryKey = keyCTHD;
            data_DSChiTietHD.DataSource = dtDSCTHD;
            data_DSChiTietHD.Columns["MAHD"].HeaderText = "Mã hóa đơn";
            data_DSChiTietHD.Columns["MASP"].HeaderText = "Mã sản phẩm";
            data_DSChiTietHD.Columns["THANHTIEN"].HeaderText = "Thành tiền";
            data_DSChiTietHD.Columns["SL"].HeaderText = "Số lượng";

            data_DSChiTietHD.Columns["MAHD"].Width = 150;
            data_DSChiTietHD.Columns["MASP"].Width = 150;
            dataBindingCTHD();
        }
        //Load combobox sản phẩm
        public void loadDataSP()
        {
            string sql = string.Format("exec DS_SP");
            dtDSDanPham = con.getDataTable(sql, "SANPHAM");
            keySP[0] = dtDSDanPham.Columns["MASP"];
            dtDSDanPham.PrimaryKey = keySP;
            cbo_TenSanPham.DataSource = dtDSDanPham;
            cbo_TenSanPham.DisplayMember = "TENSP";
            cbo_TenSanPham.ValueMember = "MASP";
        }
        #endregion

        #region Binding 
        //Binding danh sách hóa đơn
        public void dataBindingHD()
        {
            txt_MaHD.DataBindings.Add("Text", dtDSHoaDon, "MAHD");
        }
        //Binding chi tiết hóa đơn
        public void dataBindingCTHD()
        {
            cbo_TenSanPham.DataBindings.Add("SelectedValue", dtDSCTHD, "MASP");
            txt_ThanhTien.DataBindings.Add("Text", dtDSCTHD, "THANHTIEN");
            txt_SoLuong.DataBindings.Add("Text", dtDSCTHD, "SL");
        }
        //Clear Binding danh sách hóa đơn
        public void clearDataBindingHD()
        {
            txt_MaHD.DataBindings.Clear();
        }
        //Clear Binding chi tiết hóa đơn
        public void clearDataBindingCTHD()
        {
            txt_SoLuong.DataBindings.Clear();
            txt_ThanhTien.DataBindings.Clear();
            txt_DonGia.DataBindings.Clear();
            cbo_TenSanPham.DataBindings.Clear();
        }
        #endregion

        private void LapHoaDonBan_Load(object sender, EventArgs e)
        {
            loadDataDSHoaDon();
            loadDataCTHD();
            loadDataSP();
            tuongTacDataGridView();
            txt_MaHD.Enabled = false;
            txt_DonGia.ReadOnly = true;
            txt_ThanhTien.Clear();
            txt_SoLuong.Clear();
            txt_ThanhTien.Enabled = false;
            btn_Luu.Enabled = false;
        }

        #region Nút load lại danh sách
        private void btn_LoadDSHoaDon_Click(object sender, EventArgs e)
        {
            clearDataBindingHD();
            string sql = "exec DS_HOADON";
            dtDSHoaDon = con.getDataTable(sql, "HOADON");
            keyHD[0] = dtDSHoaDon.Columns["MAHD"];
            dtDSHoaDon.PrimaryKey = keyHD;
            data_DSHoaDon.DataSource = dtDSHoaDon;
            dataBindingHD();
        }
        #endregion

        #region Sự kiện
        private void data_DSHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clearDataBindingCTHD();
            data_DSChiTietHD.DataSource = null;
            data_DSChiTietHD.Refresh();
            loadDataCTHD();
        }
        private void cbo_TenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_DonGia.Clear();
            //Sự kiện khi click vào sản phẩm hiện đơn giá sản phẩm lên thành tiền
            float donGia = layDonGia(cbo_TenSanPham.SelectedValue.ToString());
            txt_DonGia.Text = Convert.ToString(donGia);         
        }
        private void txt_SoLuong_Leave(object sender, EventArgs e)
        {
            capNhatThanhTien();
        }
        #endregion

        #region Nút thêm, xóa, sửa, lưu
        //Thêm
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_SoLuong.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            DataRow row = dtDSCTHD.Rows.Find(cbo_TenSanPham.SelectedValue.ToString());
            try
            {
                //Nếu sản phẩm đã có cập nhật lại số lượng
                if (row != null)
                {
                    int sl = Convert.ToInt32(txt_SoLuong.Text) + 1;
                    row["SL"] = sl.ToString();
                    row["THANHTIEN"] = txt_ThanhTien.Text;
                    data_DSChiTietHD.Refresh();
                    MessageBox.Show("Cập nhật số lượng thành công");
                    btn_Luu.Enabled = true;
                }
                else
                {
                    clearDataBindingCTHD();
                    string sql = string.Format("exec THEM_CTHD '{0}','{1}',{2},{3}", txt_MaHD.Text, cbo_TenSanPham.SelectedValue, txt_ThanhTien.Text, txt_SoLuong.Text);
                    con.updateToDataBase(sql);
                    data_DSChiTietHD.DataSource = null;
                    data_DSChiTietHD.Refresh();
                    loadDataCTHD();
                    MessageBox.Show("Thêm sản phẩm thành công");
                    btn_Luu.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Thêm sản phẩm thất bại");
            }
        }
        //Xóa
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DataRow row = dtDSCTHD.Rows.Find(cbo_TenSanPham.SelectedValue.ToString());
            try
            {
                //Nếu sản phẩm đã có cập nhật lại số lượng
             
                    clearDataBindingCTHD();
                    string sql = string.Format("exec xoactdh '{0}'", cbo_TenSanPham.SelectedValue);
                    con.updateToDataBase(sql);
                    data_DSChiTietHD.DataSource = null;
                    data_DSChiTietHD.Refresh();
                    loadDataCTHD();
                    MessageBox.Show("xóa hóa đơn thành công");
                    btn_Luu.Enabled = true;
              
            }
            catch
            {
                MessageBox.Show(" thất bại");
            }
        }
        //Sửa
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataRow row = dtDSCTHD.Rows.Find(cbo_TenSanPham.SelectedValue.ToString());
            try
            {
                //Nếu sản phẩm đã có cập nhật lại số lượng
           
                clearDataBindingCTHD();
                string sql = string.Format("exec updatecthd '{0}','{1}','{2}','{3}'", txt_MaHD.Text,cbo_TenSanPham.SelectedValue,txt_ThanhTien.Text,txt_SoLuong.Text);
                con.updateToDataBase(sql);
                data_DSChiTietHD.DataSource = null;
                data_DSChiTietHD.Refresh();
                loadDataCTHD();
                MessageBox.Show("sửa hóa đơn thành công");
                btn_Luu.Enabled = true;

            }
            catch
            {
                MessageBox.Show(" sửa thất bại");
            }
        }
        //Lưu
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "exec DS_ALL_CTHD";
                con.updateToDatabase(sql, dtDSCTHD);
                MessageBox.Show("Lưu thành công");
                btn_Luu.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Lưu thất bại");
            }

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

        #region Nút thanh toán
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            DataRow row = dtDSHoaDon.Rows.Find(txt_MaHD.Text);
            if (row == null)
            {
                MessageBox.Show("Thanh toán thất bại");
                return;
            }
            float tongTien = tinhTongTien(txt_MaHD.Text);
            //Thông báo message box
            string kq = string.Format("Tổng tiền hóa đơn: {0}", tongTien);
            DialogResult r = MessageBox.Show(kq, "Vui lòng xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                row["TONGTIEN"] = Convert.ToString(tongTien);
                string sql = string.Format("exec CAPNHAT_TONGTIEN '{0}', {1}", txt_MaHD.Text, Convert.ToString(tongTien));
                con.updateToDataBase(sql);
                MessageBox.Show("Thanh toán thành công");
            }
        }
        #endregion

        #region Nút in
        private void btn_In_Click(object sender, EventArgs e)
        {
            Frm_InHoaDon hoaDon = new Frm_InHoaDon();
            hoaDon.maHD = txt_MaHD.Text;
            hoaDon.Show();
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_SoLuong.Clear();
        }
    }
}
