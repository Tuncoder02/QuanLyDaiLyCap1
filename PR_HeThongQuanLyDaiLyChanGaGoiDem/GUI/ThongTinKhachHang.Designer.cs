namespace GUI
{
    partial class ThongTinKhachHang
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
            this.btnTimKiemHangHoa = new System.Windows.Forms.Button();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblDanhSachKhachHang = new System.Windows.Forms.Label();
            this.dtgvKhoHangHoa = new System.Windows.Forms.DataGridView();
            this.lblThongTinKhachHang = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSuaKhachHang = new System.Windows.Forms.Button();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuTripHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripHDBH = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripHDNH = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripKhoHang = new System.Windows.Forms.ToolStripMenuItem();
            this.hệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripDSKH = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchĐạiLýCấp2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngNợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripTongCongNo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripChiTietCongNo = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoHangHoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiemHangHoa
            // 
            this.btnTimKiemHangHoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimKiemHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemHangHoa.Location = new System.Drawing.Point(369, 53);
            this.btnTimKiemHangHoa.Name = "btnTimKiemHangHoa";
            this.btnTimKiemHangHoa.Size = new System.Drawing.Size(94, 33);
            this.btnTimKiemHangHoa.TabIndex = 4;
            this.btnTimKiemHangHoa.Text = "Tìm kiếm";
            this.btnTimKiemHangHoa.UseVisualStyleBackColor = false;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(147, 58);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(204, 22);
            this.txtMaHang.TabIndex = 3;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(147, 23);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(204, 22);
            this.txtTenHang.TabIndex = 2;
            this.txtTenHang.TextChanged += new System.EventHandler(this.txtTenHang_TextChanged);
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHang.Location = new System.Drawing.Point(30, 58);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(111, 16);
            this.lblMaHang.TabIndex = 1;
            this.lblMaHang.Text = "Mã khách hàng";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.ForeColor = System.Drawing.Color.Black;
            this.lblTenKhachHang.Location = new System.Drawing.Point(24, 26);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(117, 16);
            this.lblTenKhachHang.TabIndex = 0;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            this.lblTenKhachHang.Click += new System.EventHandler(this.lblHangHoa_Click);
            // 
            // lblDanhSachKhachHang
            // 
            this.lblDanhSachKhachHang.AutoSize = true;
            this.lblDanhSachKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachKhachHang.ForeColor = System.Drawing.Color.Blue;
            this.lblDanhSachKhachHang.Location = new System.Drawing.Point(283, 170);
            this.lblDanhSachKhachHang.Name = "lblDanhSachKhachHang";
            this.lblDanhSachKhachHang.Size = new System.Drawing.Size(323, 32);
            this.lblDanhSachKhachHang.TabIndex = 3;
            this.lblDanhSachKhachHang.Text = "Danh sách khách hàng";
            // 
            // dtgvKhoHangHoa
            // 
            this.dtgvKhoHangHoa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvKhoHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhoHangHoa.Location = new System.Drawing.Point(25, 205);
            this.dtgvKhoHangHoa.Name = "dtgvKhoHangHoa";
            this.dtgvKhoHangHoa.RowHeadersWidth = 51;
            this.dtgvKhoHangHoa.RowTemplate.Height = 24;
            this.dtgvKhoHangHoa.Size = new System.Drawing.Size(836, 275);
            this.dtgvKhoHangHoa.TabIndex = 2;
            // 
            // lblThongTinKhachHang
            // 
            this.lblThongTinKhachHang.AutoSize = true;
            this.lblThongTinKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinKhachHang.ForeColor = System.Drawing.Color.Blue;
            this.lblThongTinKhachHang.Location = new System.Drawing.Point(269, 16);
            this.lblThongTinKhachHang.Name = "lblThongTinKhachHang";
            this.lblThongTinKhachHang.Size = new System.Drawing.Size(307, 32);
            this.lblThongTinKhachHang.TabIndex = 1;
            this.lblThongTinKhachHang.Text = "Thông tin khách hàng";
            this.lblThongTinKhachHang.Click += new System.EventHandler(this.lblKhoHangHoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btnXemThongTin);
            this.groupBox1.Controls.Add(this.btnXoaKH);
            this.groupBox1.Controls.Add(this.btnSuaKhachHang);
            this.groupBox1.Controls.Add(this.btnThemKhachHang);
            this.groupBox1.Controls.Add(this.btnTimKiemHangHoa);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.lblMaHang);
            this.groupBox1.Controls.Add(this.lblTenKhachHang);
            this.groupBox1.Location = new System.Drawing.Point(25, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXemThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemThongTin.Location = new System.Drawing.Point(614, 48);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(137, 33);
            this.btnXemThongTin.TabIndex = 8;
            this.btnXemThongTin.Text = "Xem Thông Tin";
            this.btnXemThongTin.UseVisualStyleBackColor = false;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.Location = new System.Drawing.Point(730, 9);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(94, 33);
            this.btnXoaKH.TabIndex = 7;
            this.btnXoaKH.Text = "Xóa KH";
            this.btnXoaKH.UseVisualStyleBackColor = false;
            // 
            // btnSuaKhachHang
            // 
            this.btnSuaKhachHang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSuaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKhachHang.Location = new System.Drawing.Point(630, 9);
            this.btnSuaKhachHang.Name = "btnSuaKhachHang";
            this.btnSuaKhachHang.Size = new System.Drawing.Size(94, 33);
            this.btnSuaKhachHang.TabIndex = 6;
            this.btnSuaKhachHang.Text = "Sửa KH";
            this.btnSuaKhachHang.UseVisualStyleBackColor = false;
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThemKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachHang.Location = new System.Drawing.Point(530, 9);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(94, 33);
            this.btnThemKhachHang.TabIndex = 5;
            this.btnThemKhachHang.Text = "Thêm KH";
            this.btnThemKhachHang.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(17, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 552);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lblDanhSachKhachHang);
            this.panel3.Controls.Add(this.dtgvKhoHangHoa);
            this.panel3.Controls.Add(this.lblThongTinKhachHang);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(3, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 500);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(4, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 32);
            this.panel2.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.Control;
            this.btnDangXuat.Location = new System.Drawing.Point(781, -1);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(113, 29);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTripHangHoa,
            this.hệToolStripMenuItem,
            this.côngNợToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuTripHangHoa
            // 
            this.MenuTripHangHoa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTripHDBH,
            this.MenuTripHDNH,
            this.MenuTripKhoHang});
            this.MenuTripHangHoa.Name = "MenuTripHangHoa";
            this.MenuTripHangHoa.Size = new System.Drawing.Size(88, 24);
            this.MenuTripHangHoa.Text = "Hàng hóa";
            this.MenuTripHangHoa.Click += new System.EventHandler(this.MenuTripHangHoa_Click);
            // 
            // MenuTripHDBH
            // 
            this.MenuTripHDBH.Name = "MenuTripHDBH";
            this.MenuTripHDBH.Size = new System.Drawing.Size(224, 26);
            this.MenuTripHDBH.Text = "Hóa đơn bán hàng";
            this.MenuTripHDBH.Click += new System.EventHandler(this.MenuTripHDBH_Click);
            // 
            // MenuTripHDNH
            // 
            this.MenuTripHDNH.Name = "MenuTripHDNH";
            this.MenuTripHDNH.Size = new System.Drawing.Size(224, 26);
            this.MenuTripHDNH.Text = "Hóa đơn nhập hàng";
            this.MenuTripHDNH.Click += new System.EventHandler(this.MenuTripHDNH_Click);
            // 
            // MenuTripKhoHang
            // 
            this.MenuTripKhoHang.Name = "MenuTripKhoHang";
            this.MenuTripKhoHang.Size = new System.Drawing.Size(224, 26);
            this.MenuTripKhoHang.Text = "Kho hàng";
            this.MenuTripKhoHang.Click += new System.EventHandler(this.MenuTripKhoHang_Click);
            // 
            // hệToolStripMenuItem
            // 
            this.hệToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTripDSKH,
            this.danhSáchĐạiLýCấp2ToolStripMenuItem});
            this.hệToolStripMenuItem.Name = "hệToolStripMenuItem";
            this.hệToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệToolStripMenuItem.Text = "Hệ thống";
            // 
            // MenuTripDSKH
            // 
            this.MenuTripDSKH.Name = "MenuTripDSKH";
            this.MenuTripDSKH.Size = new System.Drawing.Size(240, 26);
            this.MenuTripDSKH.Text = "Danh sách khách hàng";
            this.MenuTripDSKH.Click += new System.EventHandler(this.MenuTripDSKH_Click);
            // 
            // danhSáchĐạiLýCấp2ToolStripMenuItem
            // 
            this.danhSáchĐạiLýCấp2ToolStripMenuItem.Name = "danhSáchĐạiLýCấp2ToolStripMenuItem";
            this.danhSáchĐạiLýCấp2ToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.danhSáchĐạiLýCấp2ToolStripMenuItem.Text = "Danh sách đại lý cấp 2";
            this.danhSáchĐạiLýCấp2ToolStripMenuItem.Click += new System.EventHandler(this.danhSáchĐạiLýCấp2ToolStripMenuItem_Click);
            // 
            // côngNợToolStripMenuItem
            // 
            this.côngNợToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTripTongCongNo,
            this.MenuTripChiTietCongNo});
            this.côngNợToolStripMenuItem.Name = "côngNợToolStripMenuItem";
            this.côngNợToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.côngNợToolStripMenuItem.Text = "Công nợ";
            // 
            // MenuTripTongCongNo
            // 
            this.MenuTripTongCongNo.Name = "MenuTripTongCongNo";
            this.MenuTripTongCongNo.Size = new System.Drawing.Size(197, 26);
            this.MenuTripTongCongNo.Text = "Tổng công nợ";
            this.MenuTripTongCongNo.Click += new System.EventHandler(this.MenuTripTongCongNo_Click);
            // 
            // MenuTripChiTietCongNo
            // 
            this.MenuTripChiTietCongNo.Name = "MenuTripChiTietCongNo";
            this.MenuTripChiTietCongNo.Size = new System.Drawing.Size(197, 26);
            this.MenuTripChiTietCongNo.Text = "Chi tiết công nợ";
            this.MenuTripChiTietCongNo.Click += new System.EventHandler(this.MenuTripChiTietCongNo_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // ThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 573);
            this.Controls.Add(this.panel1);
            this.Name = "ThongTinKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoHangHoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiemHangHoa;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblDanhSachKhachHang;
        private System.Windows.Forms.DataGridView dtgvKhoHangHoa;
        private System.Windows.Forms.Label lblThongTinKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnSuaKhachHang;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuTripHangHoa;
        private System.Windows.Forms.ToolStripMenuItem MenuTripHDBH;
        private System.Windows.Forms.ToolStripMenuItem MenuTripHDNH;
        private System.Windows.Forms.ToolStripMenuItem MenuTripKhoHang;
        private System.Windows.Forms.ToolStripMenuItem hệToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuTripDSKH;
        private System.Windows.Forms.ToolStripMenuItem danhSáchĐạiLýCấp2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngNợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuTripTongCongNo;
        private System.Windows.Forms.ToolStripMenuItem MenuTripChiTietCongNo;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Button btnDangXuat;
    }
}