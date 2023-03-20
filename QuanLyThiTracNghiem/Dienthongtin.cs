using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public partial class Dienthongtin : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        SqlConnection cnn;

        public Dienthongtin()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            InitializeComponent();
        }
       
        void loadcbbox1()
        {
            var cmd = new SqlCommand("select sMahocsinh from tblHocsinh", cnn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMa.DisplayMember = "sMahocsinh";
            cbMa.DataSource = dt;
        }
        private void btnBatdau_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTen.Text == "" || cbMa.Text == "" || cbMon.Text == "")
                {
                    MessageBox.Show("Bạn phải điền đầy đủ thông tin");
                }
                else
                {
                    //string TenThSinh = txtHotenTS.Text;
                    //string MaThiSinh = txtMaTS.Text;
                    //string strSQL = "insert THISINHTHI values('" + MaThiSinh + "','" + TenThSinh + "')";
                    SqlCommand cmd = new SqlCommand(connectionString, cnn);
                    cmd.ExecuteNonQuery();
                    if (MessageBox.Show("Bạn có chắc chắn thi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        //chuyen thong tin sang form thi
                        string chonmon = cbMon.Text;
                        string dienten = cbTen.Text;
                        string dienma = cbMa.Text;
                        Thi thithat = new Thi(chonmon, dienten, dienma);
                        thithat.ShowDialog();
                        this.Close();


                    }

                }
            }
            catch
            {
                string chonmon = cbMon.Text;
                string dienten = cbTen.Text;
                string dienma = cbMa.Text;
                Thi thithat = new Thi(chonmon, dienten, dienma);
                thithat.ShowDialog();
                this.Close();

            }
        }

        private void txtMaTS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnBatdau_Click(null, null);
            }
        }

        private void Dienthongtin_Load(object sender, EventArgs e)
        {
            loadcbbox1();
            SqlConnection sqlcon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select sHoten from tblHocsinh", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbTen.Items.Add(dt.Rows[i]["sHoten"].ToString());
            }
        }

        private void tacgia_Click(object sender, EventArgs e)
        {
            Main tacgia = new Main();
            this.Hide();
            tacgia.ShowDialog();
        }

        private void doimatkhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thí sinh liên hệ với giáo viên phụ trách để đổi mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
