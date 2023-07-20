namespace GUI
{
    partial class Dangnhap
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
            this.lblDangnhap = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDangnhap1 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDangnhap
            // 
            this.lblDangnhap.AutoSize = true;
            this.lblDangnhap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDangnhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDangnhap.Location = new System.Drawing.Point(104, 29);
            this.lblDangnhap.Name = "lblDangnhap";
            this.lblDangnhap.Size = new System.Drawing.Size(456, 25);
            this.lblDangnhap.TabIndex = 0;
            this.lblDangnhap.Text = "Hệ thống quản lý chăn ga gối đệm đại lý cấp 1";
            this.lblDangnhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDangnhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tải_xuống_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(38, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDangnhap1
            // 
            this.lblDangnhap1.AutoSize = true;
            this.lblDangnhap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangnhap1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDangnhap1.Location = new System.Drawing.Point(361, 71);
            this.lblDangnhap1.Name = "lblDangnhap1";
            this.lblDangnhap1.Size = new System.Drawing.Size(191, 38);
            this.lblDangnhap1.TabIndex = 2;
            this.lblDangnhap1.Text = "Đăng Nhập";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTaiKhoan.Location = new System.Drawing.Point(390, 133);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(293, 38);
            this.txtTaiKhoan.TabIndex = 3;
            this.txtTaiKhoan.Text = "Nhập tài khoản";
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtTaiKhoan.Enter += new System.EventHandler(this.txtTaiKhoan_Enter);
            this.txtTaiKhoan.Leave += new System.EventHandler(this.txtTaiKhoan_Leave);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTaiKhoan.Location = new System.Drawing.Point(236, 136);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(148, 32);
            this.lblTaiKhoan.TabIndex = 4;
            this.lblTaiKhoan.Text = "Tài khoản";
            this.lblTaiKhoan.Click += new System.EventHandler(this.lblTaiKhoan_Click);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMatKhau.Location = new System.Drawing.Point(241, 201);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(143, 32);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Mật Khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMatKhau.Location = new System.Drawing.Point(390, 201);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(293, 38);
            this.txtMatKhau.TabIndex = 6;
            this.txtMatKhau.Text = "Nhập mật khẩu";
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDangNhap.Location = new System.Drawing.Point(522, 273);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(161, 48);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // chkHienMatKhau
            // 
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.BackColor = System.Drawing.SystemColors.Control;
            this.chkHienMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienMatKhau.Location = new System.Drawing.Point(539, 245);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size = new System.Drawing.Size(144, 22);
            this.chkHienMatKhau.TabIndex = 8;
            this.chkHienMatKhau.Text = "Hiển thị mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = false;
            this.chkHienMatKhau.CheckedChanged += new System.EventHandler(this.chkHienMatKhau_CheckedChanged);
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(728, 362);
            this.Controls.Add(this.chkHienMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblDangnhap1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDangnhap);
            this.MaximizeBox = false;
            this.Name = "Dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dangnhap";
            this.Load += new System.EventHandler(this.Dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDangnhap1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
    }
}