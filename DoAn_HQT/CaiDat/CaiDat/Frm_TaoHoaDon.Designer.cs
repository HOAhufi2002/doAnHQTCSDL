namespace CaiDat
{
    partial class Frm_TaoHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_TenKH = new System.Windows.Forms.Label();
            this.txt_NgayLap = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.mtxt_NgayBan = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_Ban = new System.Windows.Forms.ComboBox();
            this.cbo_NhanVien = new System.Windows.Forms.ComboBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "TẠO HOÁ ĐƠN MỚI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 71);
            this.panel1.TabIndex = 48;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.AutoSize = true;
            this.txt_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Location = new System.Drawing.Point(45, 46);
            this.txt_TenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(108, 20);
            this.txt_TenKH.TabIndex = 43;
            this.txt_TenKH.Text = "Tên nhân viên";
            // 
            // txt_NgayLap
            // 
            this.txt_NgayLap.AutoSize = true;
            this.txt_NgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayLap.Location = new System.Drawing.Point(436, 50);
            this.txt_NgayLap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_NgayLap.Name = "txt_NgayLap";
            this.txt_NgayLap.Size = new System.Drawing.Size(76, 20);
            this.txt_NgayLap.TabIndex = 44;
            this.txt_NgayLap.Text = "Ngày bán";
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.Lavender;
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(572, 336);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(122, 62);
            this.btn_Ok.TabIndex = 49;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // mtxt_NgayBan
            // 
            this.mtxt_NgayBan.Location = new System.Drawing.Point(539, 48);
            this.mtxt_NgayBan.Mask = "00/00/0000";
            this.mtxt_NgayBan.Name = "mtxt_NgayBan";
            this.mtxt_NgayBan.Size = new System.Drawing.Size(175, 24);
            this.mtxt_NgayBan.TabIndex = 51;
            this.mtxt_NgayBan.ValidatingType = typeof(System.DateTime);
            this.mtxt_NgayBan.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxt_NgayBan_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tổng tiền";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(158, 104);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(175, 26);
            this.txt_TongTien.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Bàn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cbo_Ban);
            this.groupBox1.Controls.Add(this.cbo_NhanVien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtxt_NgayBan);
            this.groupBox1.Controls.Add(this.txt_NgayLap);
            this.groupBox1.Controls.Add(this.txt_TenKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 206);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cbo_Ban
            // 
            this.cbo_Ban.FormattingEnabled = true;
            this.cbo_Ban.Location = new System.Drawing.Point(539, 98);
            this.cbo_Ban.Name = "cbo_Ban";
            this.cbo_Ban.Size = new System.Drawing.Size(73, 26);
            this.cbo_Ban.TabIndex = 56;
            // 
            // cbo_NhanVien
            // 
            this.cbo_NhanVien.FormattingEnabled = true;
            this.cbo_NhanVien.Location = new System.Drawing.Point(158, 44);
            this.cbo_NhanVien.Name = "cbo_NhanVien";
            this.cbo_NhanVien.Size = new System.Drawing.Size(184, 26);
            this.cbo_NhanVien.TabIndex = 55;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Lavender;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Image = global::CaiDat.Properties.Resources.Exit;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(732, 335);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(109, 62);
            this.btn_Thoat.TabIndex = 57;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Frm_TaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 425);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_TaoHoaDon";
            this.Text = "Tạo hóa đơn mới";
            this.Load += new System.EventHandler(this.Frm_TaoHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_TenKH;
        private System.Windows.Forms.Label txt_NgayLap;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.MaskedTextBox mtxt_NgayBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_Ban;
        private System.Windows.Forms.ComboBox cbo_NhanVien;
        private System.Windows.Forms.Button btn_Thoat;
    }
}