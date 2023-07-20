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
    public partial class CongNoChiTiet : Form
    {
        public CongNoChiTiet()
        {
            InitializeComponent();
        }

        private void lblChiTietHoaDonNhapHang_Click(object sender, EventArgs e)
        {

        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonNhapHang sistema = new HoaDonNhapHang();
            sistema.ShowDialog();
            this.Close();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Khohanghoa sistema = new Khohanghoa();
            sistema.ShowDialog();
            this.Close();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinKhachHang sistema = new ThongTinKhachHang();
            sistema.ShowDialog();
            this.Close();
        }

        private void tổngCôngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CongNoTongHop sistema = new CongNoTongHop();
            sistema.ShowDialog();
            this.Close();
        }

        private void MenuTripHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void MenuTripHDBH_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonBanHang sistema = new HoaDonBanHang();
            sistema.ShowDialog();
            this.Close();
        }

        private void MenuTripHDNH_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonNhapHang sistema = new HoaDonNhapHang();
            sistema.ShowDialog();
            this.Close();
        }

        private void MenuTripKhoHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Khohanghoa sistema = new Khohanghoa();
            sistema.ShowDialog();
            this.Close();
        }

        private void MenuTripDSKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinKhachHang sistema = new ThongTinKhachHang();
            sistema.ShowDialog();
            this.Close();
        }

        private void MenuTripTongCongNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            CongNoTongHop sistema = new CongNoTongHop();
            sistema.ShowDialog();
            this.Close();
        }

        private void MenuTripChiTietCongNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            CongNoChiTiet sistema = new CongNoChiTiet();
            sistema.ShowDialog();
            this.Close();
        }
        private void danhSáchĐạiLýCấp2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
