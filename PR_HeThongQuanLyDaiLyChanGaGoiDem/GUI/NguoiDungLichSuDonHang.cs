using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NguoiDungLichSuDonHang : Form
    {
        public NguoiDungLichSuDonHang()
        {
            InitializeComponent();
        }

        private void MenuTripCuaHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            NguoiDungTrangCuaHang sistema = new NguoiDungTrangCuaHang();
            sistema.ShowDialog();
            this.Close();
        }

        private void MenuTripCapNhatThongTin_Click(object sender, EventArgs e)
        {
            this.Hide();
            NguoiDungThongTinTaiKhoan sistema = new NguoiDungThongTinTaiKhoan();
            sistema.ShowDialog();
            this.Close();
        }

        private void MenuTripLichSuMuaHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            NguoiDungLichSuDonHang sistema = new NguoiDungLichSuDonHang();
            sistema.ShowDialog();
            this.Close();

        }

        private void MenuTripGioHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            NguoiDungGioHang sistema = new NguoiDungGioHang();
            sistema.ShowDialog();
            this.Close();
        }

        private void MenuTripDangXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            NguoiDungGioHang sistema = new NguoiDungGioHang();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
