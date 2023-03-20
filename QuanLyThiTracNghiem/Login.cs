using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbHienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienmatkhau.Checked)
            {
                txtMatkhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatkhau.PasswordChar = '*';
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                string tk = txtTaikhoan.Text;
                string mk = txtMatkhau.Text;
                
                if (tk !="admin")
                {
                    string sql = "select * from tblHocsinh where tblHocsinh.sTenDN='" + tk + "'and tblHocsinh.sMatkhau ='" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        Dienthongtin frm = new Dienthongtin();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông Báo");
                    }
                }
                 else if ((tk == "admin"))
                 {
                    string sql = "select * from tblAdmin where tblAdmin.sTaikhoan='" + tk + "'and tblAdmin.sMatkhau ='" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        QuanLy frm = new QuanLy();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông Báo");
                    }
                }
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập sai tài khoản, thử lại", "Thông Báo");
            }
            
        }

        
    }
}
