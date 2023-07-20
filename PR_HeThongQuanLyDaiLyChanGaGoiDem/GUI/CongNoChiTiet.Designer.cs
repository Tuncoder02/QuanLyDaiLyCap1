namespace GUI
{
    partial class CongNoChiTiet
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
            this.lblCongNoChiTiet = new System.Windows.Forms.Label();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInHoaDonBanHang = new System.Windows.Forms.Button();
            this.lblNgayCongNo = new System.Windows.Forms.Label();
            this.lblTongTienMuaHang = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChiMuaHang = new System.Windows.Forms.Label();
            this.lblCongTy = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblChiTietHoaDonCongNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLocCongNo = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCongNoChiTiet
            // 
            this.lblCongNoChiTiet.AutoSize = true;
            this.lblCongNoChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongNoChiTiet.ForeColor = System.Drawing.Color.Blue;
            this.lblCongNoChiTiet.Location = new System.Drawing.Point(316, 1);
            this.lblCongNoChiTiet.Name = "lblCongNoChiTiet";
            this.lblCongNoChiTiet.Size = new System.Drawing.Size(227, 32);
            this.lblCongNoChiTiet.TabIndex = 1;
            this.lblCongNoChiTiet.Text = "Công nợ chi tiết";
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
            this.btnDangXuat.Location = new System.Drawing.Point(780, -1);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.btnInHoaDonBanHang);
            this.panel4.Controls.Add(this.lblNgayCongNo);
            this.panel4.Controls.Add(this.lblTongTienMuaHang);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.lblSDT);
            this.panel4.Controls.Add(this.lblDiaChiMuaHang);
            this.panel4.Controls.Add(this.lblCongTy);
            this.panel4.Controls.Add(this.lblTenKhachHang);
            this.panel4.Controls.Add(this.lblChiTietHoaDonCongNo);
            this.panel4.Location = new System.Drawing.Point(475, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 461);
            this.panel4.TabIndex = 4;
            // 
            // btnInHoaDonBanHang
            // 
            this.btnInHoaDonBanHang.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDonBanHang.ForeColor = System.Drawing.Color.White;
            this.btnInHoaDonBanHang.Location = new System.Drawing.Point(296, 420);
            this.btnInHoaDonBanHang.Name = "btnInHoaDonBanHang";
            this.btnInHoaDonBanHang.Size = new System.Drawing.Size(87, 26);
            this.btnInHoaDonBanHang.TabIndex = 14;
            this.btnInHoaDonBanHang.Text = "In hóa đơn";
            this.btnInHoaDonBanHang.UseVisualStyleBackColor = false;
            // 
            // lblNgayCongNo
            // 
            this.lblNgayCongNo.AutoSize = true;
            this.lblNgayCongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayCongNo.Location = new System.Drawing.Point(67, 32);
            this.lblNgayCongNo.Name = "lblNgayCongNo";
            this.lblNgayCongNo.Size = new System.Drawing.Size(249, 16);
            this.lblNgayCongNo.TabIndex = 13;
            this.lblNgayCongNo.Text = "Từ ngày 20/11/2023 đến ngày 20/12/2023";
            // 
            // lblTongTienMuaHang
            // 
            this.lblTongTienMuaHang.AutoSize = true;
            this.lblTongTienMuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienMuaHang.Location = new System.Drawing.Point(240, 392);
            this.lblTongTienMuaHang.Name = "lblTongTienMuaHang";
            this.lblTongTienMuaHang.Size = new System.Drawing.Size(51, 18);
            this.lblTongTienMuaHang.TabIndex = 11;
            this.lblTongTienMuaHang.Text = "Tổng:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 167);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(360, 222);
            this.dataGridView2.TabIndex = 10;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(13, 141);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(46, 18);
            this.lblSDT.TabIndex = 9;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblDiaChiMuaHang
            // 
            this.lblDiaChiMuaHang.AutoSize = true;
            this.lblDiaChiMuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChiMuaHang.Location = new System.Drawing.Point(13, 112);
            this.lblDiaChiMuaHang.Name = "lblDiaChiMuaHang";
            this.lblDiaChiMuaHang.Size = new System.Drawing.Size(65, 18);
            this.lblDiaChiMuaHang.TabIndex = 8;
            this.lblDiaChiMuaHang.Text = "Địa chỉ:";
            // 
            // lblCongTy
            // 
            this.lblCongTy.AutoSize = true;
            this.lblCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongTy.Location = new System.Drawing.Point(13, 82);
            this.lblCongTy.Name = "lblCongTy";
            this.lblCongTy.Size = new System.Drawing.Size(74, 18);
            this.lblCongTy.TabIndex = 7;
            this.lblCongTy.Text = "Tổ chức:";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(13, 51);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(132, 18);
            this.lblTenKhachHang.TabIndex = 6;
            this.lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // lblChiTietHoaDonCongNo
            // 
            this.lblChiTietHoaDonCongNo.AutoSize = true;
            this.lblChiTietHoaDonCongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietHoaDonCongNo.ForeColor = System.Drawing.Color.Blue;
            this.lblChiTietHoaDonCongNo.Location = new System.Drawing.Point(110, 6);
            this.lblChiTietHoaDonCongNo.Name = "lblChiTietHoaDonCongNo";
            this.lblChiTietHoaDonCongNo.Size = new System.Drawing.Size(163, 25);
            this.lblChiTietHoaDonCongNo.TabIndex = 5;
            this.lblChiTietHoaDonCongNo.Text = "Chi tiết công nợ";
            this.lblChiTietHoaDonCongNo.Click += new System.EventHandler(this.lblChiTietHoaDonNhapHang_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(17, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 552);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.lblCongNoChiTiet);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(3, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 508);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(96, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Danh sách khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLocCongNo);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblDenNgay);
            this.groupBox1.Controls.Add(this.lblTuNgay);
            this.groupBox1.Location = new System.Drawing.Point(33, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 146);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // btnLocCongNo
            // 
            this.btnLocCongNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLocCongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocCongNo.Location = new System.Drawing.Point(243, 96);
            this.btnLocCongNo.Name = "btnLocCongNo";
            this.btnLocCongNo.Size = new System.Drawing.Size(104, 29);
            this.btnLocCongNo.TabIndex = 4;
            this.btnLocCongNo.Text = "Lọc";
            this.btnLocCongNo.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(101, 68);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 26);
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(369, 279);
            this.dataGridView1.TabIndex = 3;
            // 
            // CongNoChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 573);
            this.Controls.Add(this.panel1);
            this.Name = "CongNoChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CongNoChiTiet";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCongNoChiTiet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnInHoaDonBanHang;
        private System.Windows.Forms.Label lblNgayCongNo;
        private System.Windows.Forms.Label lblTongTienMuaHang;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChiMuaHang;
        private System.Windows.Forms.Label lblCongTy;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblChiTietHoaDonCongNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLocCongNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label label2;
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