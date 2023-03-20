using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void btnQLthisinh_Click(object sender, EventArgs e)
        {
            Danhsachthisinh frmDSTT = new Danhsachthisinh();
            this.Hide();
            frmDSTT.ShowDialog();
            //this.Show();
        }

        private void btnQLkhode_Click(object sender, EventArgs e)
        {
            Quanlycauhoi frmQLCH = new Quanlycauhoi();
            this.Hide();
            frmQLCH.ShowDialog();
            //this.Show();
        }

        private void btnXemkq_Click(object sender, EventArgs e)
        {
            Xemketquathichung frm = new Xemketquathichung();
            this.Hide();
            frm.ShowDialog();
            //this.Show();
        }

        private void mstripXemKQ_Click(object sender, EventArgs e)
        {
            Xemketquathichung frm = new Xemketquathichung();
            this.Hide();
            frm.ShowDialog();
            //this.Show();
        }

        private void mstripQLTS_Click(object sender, EventArgs e)
        {
            Danhsachthisinh frmDSTT = new Danhsachthisinh();
            this.Hide();
            frmDSTT.ShowDialog();
            //this.Show();
        }

        private void mstripQLKD_Click(object sender, EventArgs e)
        {
            Quanlycauhoi frmQLCH = new Quanlycauhoi();
            this.Hide();
            frmQLCH.ShowDialog();
            //this.Show();
        }

        private void indsThisinh_Click(object sender, EventArgs e)
        {
            Report frm = new Report();
            frm.ShowReport("Danhsachhocsinh.rpt", "Danh sách học sinh", "");
            frm.Show();
        }

        private void inKetquathi_Click(object sender, EventArgs e)
        {
            Report frm = new Report();
            frm.ShowReport("Ketquathi.rpt", "Kết quả thi", "");
            frm.Show();
        }

        private void tacgia_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            this.Hide();
            frm.ShowDialog();
            //this.Show();
        }

        private void doimatkhau_Click(object sender, EventArgs e)
        {
            Doimatkhau dmk = new Doimatkhau();
            this.Hide();
            dmk.ShowDialog();
        }
    }
    
}
