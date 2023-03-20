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
    public partial class Doimatkhau : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public Doimatkhau()
        {
            InitializeComponent();
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "spAdmin_UPDATEPASSWORD";

                       if(txtnhaplai.Text == txtmkmoi.Text)
                       {
                           cmd.Parameters.AddWithValue("@sMatkhau", txtmkmoi.Text);
                           cmd.ExecuteNonQuery();
                           cnn.Close();
                           MessageBox.Show("Đổi mật khẩu thành công, áp dụng trong phiên đăng nhập tiếp theo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
                       else {
                           MessageBox.Show("Không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       }
                }
            }
        }
    }
}
