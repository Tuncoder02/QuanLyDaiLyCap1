namespace GUI
{
    partial class NguoiDungTrangCuaHang
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThemVaoGioHang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemSanPham = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.btnGioHang = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuTripCuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripCapNhatThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripLichSuMuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripGioHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTripDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGioHang);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 565);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(624, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chi tiết sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btnThemVaoGioHang);
            this.panel2.Location = new System.Drawing.Point(522, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 426);
            this.panel2.TabIndex = 5;
            // 
            // btnThemVaoGioHang
            // 
            this.btnThemVaoGioHang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThemVaoGioHang.Location = new System.Drawing.Point(89, 383);
            this.btnThemVaoGioHang.Name = "btnThemVaoGioHang";
            this.btnThemVaoGioHang.Size = new System.Drawing.Size(225, 30);
            this.btnThemVaoGioHang.TabIndex = 0;
            this.btnThemVaoGioHang.Text = "Thêm vào giỏ hàng";
            this.btnThemVaoGioHang.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(160, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(458, 288);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiemSanPham);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTenSanPham);
            this.groupBox1.Location = new System.Drawing.Point(33, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTimKiemSanPham
            // 
            this.btnTimKiemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSanPham.Location = new System.Drawing.Point(334, 93);
            this.btnTimKiemSanPham.Name = "btnTimKiemSanPham";
            this.btnTimKiemSanPham.Size = new System.Drawing.Size(108, 35);
            this.btnTimKiemSanPham.TabIndex = 9;
            this.btnTimKiemSanPham.Text = "Tìm kiếm";
            this.btnTimKiemSanPham.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(392, 56);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 20);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Đệm";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(392, 30);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(50, 20);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Gối";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(326, 56);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 20);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Ga";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(326, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Chăn";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 28);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 28);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanPham.Location = new System.Drawing.Point(20, 28);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(105, 16);
            this.lblTenSanPham.TabIndex = 0;
            this.lblTenSanPham.Text = "Tên sản phẩm";
            // 
            // btnGioHang
            // 
            this.btnGioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioHang.Location = new System.Drawing.Point(755, -7);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(171, 35);
            this.btnGioHang.TabIndex = 8;
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
            this.menuStrip1.TabIndex = 7;
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
            // NguoiDungTrangCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 573);
            this.Controls.Add(this.panel1);
            this.Name = "NguoiDungTrangCuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NguoiDungTrangCuaHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTimKiemSanPham;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThemVaoGioHang;
        private System.Windows.Forms.Label label2;
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