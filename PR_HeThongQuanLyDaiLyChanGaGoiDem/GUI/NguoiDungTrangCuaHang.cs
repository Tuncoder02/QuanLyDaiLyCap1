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
    public partial class NguoiDungTrangCuaHang : Form
    {
        public NguoiDungTrangCuaHang()
        {
            InitializeComponent();
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
