using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DTO;
using BLL;

namespace GUI
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }


        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Nhập tài khoản")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = SystemColors.Highlight;
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                txtTaiKhoan.Text = "Nhập tài khoản";
                txtTaiKhoan.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Nhập mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = SystemColors.Highlight;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Nhập mật khẩu";
                txtMatKhau.ForeColor = SystemColors.InactiveCaption;
            }
        }

        Account TK = new Account();
        AccountBLL AccBLL= new AccountBLL();
       private void lblTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TK.TaiKhoan = txtTaiKhoan.Text;
            TK.MatKhau = txtMatKhau.Text;
            string info = AccBLL.CheckLogin(TK);
            if (info == "0")
            {
                MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NguoiDungTrangCuaHang sistema = new NguoiDungTrangCuaHang();
                sistema.ShowDialog();
                this.Close();
            }
            else if (info == "1")
            {
                MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Khohanghoa sistema = new Khohanghoa();
                sistema.ShowDialog();
                this.Close();

            }
            else if (info == "2")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                txtTaiKhoan.Focus();
            }
            else
            if(info=="3")
            {
                MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                txtTaiKhoan.Focus();
            }
            else if(info=="requeid_taikhoan")
            {
                MessageBox.Show("Chưa nhập tài khoản !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(info=="requeid_matkhau")
            {
                MessageBox.Show("Chưa nhập mật khẩu !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }
    }
}
