namespace GUI
{
    partial class Khohanghoa
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThongKeHangHoa = new System.Windows.Forms.Button();
            this.btnInDSHangHoa = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvKhoHangHoa = new System.Windows.Forms.DataGridView();
            this.lblKhoHangHoa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemHangHoa = new System.Windows.Forms.Button();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.lblHangHoa = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoHangHoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(17, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 552);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 36);
            this.panel2.TabIndex = 2;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.Control;
            this.btnDangXuat.Location = new System.Drawing.Point(782, 1);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(113, 29);
            this.btnDangXuat.TabIndex = 3;
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
            this.menuStrip1.Size = new System.Drawing.Size(894, 28);
            this.menuStrip1.TabIndex = 2;
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dtgvKhoHangHoa);
            this.panel3.Controls.Add(this.lblKhoHangHoa);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(3, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 500);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnThongKeHangHoa);
            this.panel4.Controls.Add(this.btnInDSHangHoa);
            this.panel4.Controls.Add(this.btnNhapHang);
            this.panel4.Location = new System.Drawing.Point(536, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 97);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnThongKeHangHoa
            // 
            this.btnThongKeHangHoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThongKeHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeHangHoa.Location = new System.Drawing.Point(51, 44);
            this.btnThongKeHangHoa.Name = "btnThongKeHangHoa";
            this.btnThongKeHangHoa.Size = new System.Drawing.Size(167, 30);
            this.btnThongKeHangHoa.TabIndex = 2;
            this.btnThongKeHangHoa.Text = "Thống Kê Hàng Hóa";
            this.btnThongKeHangHoa.UseVisualStyleBackColor = false;
            this.btnThongKeHangHoa.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // btnInDSHangHoa
            // 
            this.btnInDSHangHoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInDSHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDSHangHoa.Location = new System.Drawing.Point(131, 3);
            this.btnInDSHangHoa.Name = "btnInDSHangHoa";
            this.btnInDSHangHoa.Size = new System.Drawing.Size(122, 30);
            this.btnInDSHangHoa.TabIndex = 1;
            this.btnInDSHangHoa.Text = "In DS";
            this.btnInDSHangHoa.UseVisualStyleBackColor = false;
            this.btnInDSHangHoa.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.Location = new System.Drawing.Point(3, 3);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(122, 30);
            this.btnNhapHang.TabIndex = 0;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(283, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách hàng hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
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
            this.dtgvKhoHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKhoHangHoa_CellContentClick);
            // 
            // lblKhoHangHoa
            // 
            this.lblKhoHangHoa.AutoSize = true;
            this.lblKhoHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoHangHoa.ForeColor = System.Drawing.Color.Blue;
            this.lblKhoHangHoa.Location = new System.Drawing.Point(320, 17);
            this.lblKhoHangHoa.Name = "lblKhoHangHoa";
            this.lblKhoHangHoa.Size = new System.Drawing.Size(211, 32);
            this.lblKhoHangHoa.TabIndex = 1;
            this.lblKhoHangHoa.Text = "Kho Hàng Hóa";
            this.lblKhoHangHoa.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btnTimKiemHangHoa);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.lblMaHang);
            this.groupBox1.Controls.Add(this.lblHangHoa);
            this.groupBox1.Location = new System.Drawing.Point(25, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnTimKiemHangHoa
            // 
            this.btnTimKiemHangHoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimKiemHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemHangHoa.Location = new System.Drawing.Point(332, 53);
            this.btnTimKiemHangHoa.Name = "btnTimKiemHangHoa";
            this.btnTimKiemHangHoa.Size = new System.Drawing.Size(94, 33);
            this.btnTimKiemHangHoa.TabIndex = 4;
            this.btnTimKiemHangHoa.Text = "Tìm kiếm";
            this.btnTimKiemHangHoa.UseVisualStyleBackColor = false;
            this.btnTimKiemHangHoa.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(102, 58);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(204, 22);
            this.txtMaHang.TabIndex = 3;
            this.txtMaHang.TextChanged += new System.EventHandler(this.txtMaHang_TextChanged);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(102, 23);
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
            this.lblMaHang.Size = new System.Drawing.Size(66, 16);
            this.lblMaHang.TabIndex = 1;
            this.lblMaHang.Text = "Mã hàng";
            this.lblMaHang.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblHangHoa
            // 
            this.lblHangHoa.AutoSize = true;
            this.lblHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangHoa.ForeColor = System.Drawing.Color.Black;
            this.lblHangHoa.Location = new System.Drawing.Point(24, 26);
            this.lblHangHoa.Name = "lblHangHoa";
            this.lblHangHoa.Size = new System.Drawing.Size(72, 16);
            this.lblHangHoa.TabIndex = 0;
            this.lblHangHoa.Text = "Tên hàng";
            this.lblHangHoa.Click += new System.EventHandler(this.label2_Click);
            // 
            // Khohanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 573);
            this.Controls.Add(this.panel1);
            this.Name = "Khohanghoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khohanghoa";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoHangHoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKhoHangHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvKhoHangHoa;
        private System.Windows.Forms.Label lblHangHoa;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.Button btnTimKiemHangHoa;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnInDSHangHoa;
        private System.Windows.Forms.Button btnThongKeHangHoa;
        private System.Windows.Forms.Panel panel2;
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