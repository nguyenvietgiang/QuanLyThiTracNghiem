using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void quanly_Click(object sender, EventArgs e)
        {
            QuanLy frm = new QuanLy();
            this.Hide();
            this.Close();
            frm.ShowDialog();
            //this.Show();
        }
    }
}
