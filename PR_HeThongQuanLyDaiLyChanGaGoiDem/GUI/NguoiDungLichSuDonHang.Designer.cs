namespace GUI
{
    partial class NguoiDungLichSuDonHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGioHang = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuTripCuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripCapNhatThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripLichSuMuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripGioHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMaHoaDonNhapHang = new System.Windows.Forms.Label();
            this.btnTimKiemDonNhap = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(336, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lịch sử đơn hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGioHang);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 565);
            this.panel1.TabIndex = 1;
            // 
            // btnGioHang
            // 
            this.btnGioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioHang.Location = new System.Drawing.Point(755, 0);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(171, 35);
            this.btnGioHang.TabIndex = 10;
            this.btnGioHang.Text = "Giỏ hàng (10)";
            this.btnGioHang.UseVisualStyleBackColor = false;
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTripCuaHang,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuTripCuaHang
            // 
            this.MenuTripCuaHang.Name = "MenuTripCuaHang";
            this.MenuTripCuaHang.Size = new System.Drawing.Size(86, 24);
            this.MenuTripCuaHang.Text = "Cửa hàng";
            this.MenuTripCuaHang.Click += new System.EventHandler(this.MenuTripCuaHang_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTripCapNhatThongTin,
            this.MenuTripLichSuMuaHang,
            this.MenuTripGioHang,
            this.MenuTripDangXuat});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // MenuTripCapNhatThongTin
            // 
            this.MenuTripCapNhatThongTin.Name = "MenuTripCapNhatThongTin";
            this.MenuTripCapNhatThongTin.Size = new System.Drawing.Size(224, 26);
            this.MenuTripCapNhatThongTin.Text = "Cập nhật thông tin";
            this.MenuTripCapNhatThongTin.Click += new System.EventHandler(this.MenuTripCapNhatThongTin_Click);
            // 
            // MenuTripLichSuMuaHang
            // 
            this.MenuTripLichSuMuaHang.Name = "MenuTripLichSuMuaHang";
            this.MenuTripLichSuMuaHang.Size = new System.Drawing.Size(224, 26);
            this.MenuTripLichSuMuaHang.Text = "Lịch sử mua hàng";
            this.MenuTripLichSuMuaHang.Click += new System.EventHandler(this.MenuTripLichSuMuaHang_Click);
            // 
            // MenuTripGioHang
            // 
            this.MenuTripGioHang.Name = "MenuTripGioHang";
            this.MenuTripGioHang.Size = new System.Drawing.Size(224, 26);
            this.MenuTripGioHang.Text = "Giỏ hàng";
            this.MenuTripGioHang.Click += new System.EventHandler(this.MenuTripGioHang_Click);
            // 
            // MenuTripDangXuat
            // 
            this.MenuTripDangXuat.Name = "MenuTripDangXuat";
            this.MenuTripDangXuat.Size = new System.Drawing.Size(224, 26);
            this.MenuTripDangXuat.Text = "Đăng xuất";
            this.MenuTripDangXuat.Click += new System.EventHandler(this.MenuTripDangXuat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(815, 263);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblMaHoaDonNhapHang);
            this.groupBox1.Controls.Add(this.btnTimKiemDonNhap);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblDenNgay);
            this.groupBox1.Controls.Add(this.lblTuNgay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 176);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 22);
            this.textBox1.TabIndex = 6;
            // 
            // lblMaHoaDonNhapHang
            // 
            this.lblMaHoaDonNhapHang.AutoSize = true;
            this.lblMaHoaDonNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDonNhapHang.ForeColor = System.Drawing.Color.Blue;
            this.lblMaHoaDonNhapHang.Location = new System.Drawing.Point(6, 111);
            this.lblMaHoaDonNhapHang.Name = "lblMaHoaDonNhapHang";
            this.lblMaHoaDonNhapHang.Size = new System.Drawing.Size(96, 16);
            this.lblMaHoaDonNhapHang.TabIndex = 5;
            this.lblMaHoaDonNhapHang.Text = "Mã đơn hàng";
            // 
            // btnTimKiemDonNhap
            // 
            this.btnTimKiemDonNhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiemDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemDonNhap.Location = new System.Drawing.Point(243, 141);
            this.btnTimKiemDonNhap.Name = "btnTimKiemDonNhap";
            this.btnTimKiemDonNhap.Size = new System.Drawing.Size(104, 29);
            this.btnTimKiemDonNhap.TabIndex = 4;
            this.btnTimKiemDonNhap.Text = "Tìm Kiếm";
            this.btnTimKiemDonNhap.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(121, 68);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.ForeColor = System.Drawing.Color.Blue;
            this.lblDenNgay.Location = new System.Drawing.Point(15, 68);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(75, 16);
            this.lblDenNgay.TabIndex = 1;
            this.lblDenNgay.Text = "Đến Ngày";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.ForeColor = System.Drawing.Color.Blue;
            this.lblTuNgay.Location = new System.Drawing.Point(27, 31);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(63, 16);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // NguoiDungLichSuDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 573);
            this.Controls.Add(this.panel1);
            this.Name = "NguoiDungLichSuDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NguoiDungLichSuDonHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMaHoaDonNhapHang;
        private System.Windows.Forms.Button btnTimKiemDonNhap;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Button btnGioHang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuTripCuaHang;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuTripCapNhatThongTin;
        private System.Windows.Forms.ToolStripMenuItem MenuTripLichSuMuaHang;
        private System.Windows.Forms.ToolStripMenuItem MenuTripGioHang;
        private System.Windows.Forms.ToolStripMenuItem MenuTripDangXuat;
    }
}