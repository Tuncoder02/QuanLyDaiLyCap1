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
    public partial class Khohanghoa : Form
    {
        public Khohanghoa()
        {
            InitializeComponent();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonBanHang sistema = new HoaDonBanHang();
            sistema.ShowDialog();
            this.Close();
        }

        private void côngNợTừngKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CongNoChiTiet sistema = new CongNoChiTiet();
            sistema.ShowDialog();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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

        private void hệToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinKhachHang sistema = new ThongTinKhachHang();
            sistema.ShowDialog();
            this.Close();
        }

        private void danhSáchĐạiLýCấp2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void côngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tổngCôngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CongNoTongHop sistema = new CongNoTongHop();
            sistema.ShowDialog();
            this.Close();
        }

        private void dtgvKhoHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {

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
    }
}
