namespace CaiDat
{
    partial class LapHoaDonBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_LoadDSHoaDon = new System.Windows.Forms.Button();
            this.data_DSHoaDon = new System.Windows.Forms.DataGridView();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.data_DSChiTietHD = new System.Windows.Forms.DataGridView();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_TenSanPham = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_In = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btn_LoadDSHoaDon);
            this.groupBox1.Controls.Add(this.data_DSHoaDon);
            this.groupBox1.Controls.Add(this.btn_TaoHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 457);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // btn_LoadDSHoaDon
            // 
            this.btn_LoadDSHoaDon.BackColor = System.Drawing.Color.Lavender;
            this.btn_LoadDSHoaDon.Location = new System.Drawing.Point(16, 393);
            this.btn_LoadDSHoaDon.Name = "btn_LoadDSHoaDon";
            this.btn_LoadDSHoaDon.Size = new System.Drawing.Size(202, 51);
            this.btn_LoadDSHoaDon.TabIndex = 4;
            this.btn_LoadDSHoaDon.Text = "Tải lại danh sách hóa đơn";
            this.btn_LoadDSHoaDon.UseVisualStyleBackColor = false;
            this.btn_LoadDSHoaDon.Click += new System.EventHandler(this.btn_LoadDSHoaDon_Click);
            // 
            // data_DSHoaDon
            // 
            this.data_DSHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.data_DSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_DSHoaDon.Location = new System.Drawing.Point(16, 72);
            this.data_DSHoaDon.Name = "data_DSHoaDon";
            this.data_DSHoaDon.RowHeadersWidth = 51;
            this.data_DSHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_DSHoaDon.Size = new System.Drawing.Size(298, 300);
            this.data_DSHoaDon.TabIndex = 3;
            this.data_DSHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_DSHoaDon_CellContentClick);
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.BackColor = System.Drawing.Color.Lavender;
            this.btn_TaoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(10, 21);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(304, 40);
            this.btn_TaoHoaDon.TabIndex = 3;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn mới";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = false;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.btn_TaoHoaDon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_ThanhTien);
            this.groupBox2.Controls.Add(this.btn_ThanhToan);
            this.groupBox2.Controls.Add(this.data_DSChiTietHD);
            this.groupBox2.Controls.Add(this.txt_DonGia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_SoLuong);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbo_TenSanPham);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_MaHD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(359, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 457);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Đơn giá";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(111, 143);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(116, 24);
            this.txt_ThanhTien.TabIndex = 29;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.Lavender;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Image = global::CaiDat.Properties.Resources.Loading;
            this.btn_ThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThanhToan.Location = new System.Drawing.Point(447, 386);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(150, 55);
            this.btn_ThanhToan.TabIndex = 28;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // data_DSChiTietHD
            // 
            this.data_DSChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_DSChiTietHD.BackgroundColor = System.Drawing.Color.White;
            this.data_DSChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_DSChiTietHD.Location = new System.Drawing.Point(16, 180);
            this.data_DSChiTietHD.Name = "data_DSChiTietHD";
            this.data_DSChiTietHD.RowHeadersWidth = 51;
            this.data_DSChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_DSChiTietHD.Size = new System.Drawing.Size(581, 192);
            this.data_DSChiTietHD.TabIndex = 12;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(111, 103);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(116, 24);
            this.txt_DonGia.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thành tiền";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(111, 64);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(62, 24);
            this.txt_SoLuong.TabIndex = 5;
            this.txt_SoLuong.Leave += new System.EventHandler(this.txt_SoLuong_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng";
            // 
            // cbo_TenSanPham
            // 
            this.cbo_TenSanPham.FormattingEnabled = true;
            this.cbo_TenSanPham.Location = new System.Drawing.Point(421, 22);
            this.cbo_TenSanPham.Name = "cbo_TenSanPham";
            this.cbo_TenSanPham.Size = new System.Drawing.Size(176, 26);
            this.cbo_TenSanPham.TabIndex = 3;
            this.cbo_TenSanPham.SelectedIndexChanged += new System.EventHandler(this.cbo_TenSanPham_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(111, 23);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(154, 24);
            this.txt_MaHD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // btn_In
            // 
            this.btn_In.BackColor = System.Drawing.Color.Lavender;
            this.btn_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.Image = global::CaiDat.Properties.Resources.Print;
            this.btn_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_In.Location = new System.Drawing.Point(1005, 402);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(106, 60);
            this.btn_In.TabIndex = 34;
            this.btn_In.Text = "In";
            this.btn_In.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_In.UseVisualStyleBackColor = false;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Lavender;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Image = global::CaiDat.Properties.Resources.Back;
            this.btn_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Huy.Location = new System.Drawing.Point(1005, 328);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(106, 60);
            this.btn_Huy.TabIndex = 32;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.Lavender;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Image = global::CaiDat.Properties.Resources.Save;
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(1005, 254);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(106, 60);
            this.btn_Luu.TabIndex = 31;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Lavender;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = global::CaiDat.Properties.Resources.Modify;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(1005, 180);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(106, 60);
            this.btn_Sua.TabIndex = 30;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Lavender;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = global::CaiDat.Properties.Resources.Delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(1005, 106);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(106, 60);
            this.btn_Xoa.TabIndex = 29;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Lavender;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = global::CaiDat.Properties.Resources.Add;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(1005, 32);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(106, 60);
            this.btn_Them.TabIndex = 28;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 54);
            this.button1.TabIndex = 35;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LapHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 593);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LapHoaDonBan";
            this.Text = "Lập hóa đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LapHoaDonBan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_DSHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSChiTietHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView data_DSHoaDon;
        private System.Windows.Forms.Button btn_TaoHoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView data_DSChiTietHD;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_TenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_LoadDSHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Button button1;
    }
}