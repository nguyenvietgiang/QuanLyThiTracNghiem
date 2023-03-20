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
    public partial class Danhsachthisinh : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public static SqlConnection cnn = new SqlConnection(connectionString);
        public Danhsachthisinh()
        {
            InitializeComponent();
        }
        private DataTable getHocsinh()
        {
            string procName = "spHocsinh_GET";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(procName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable("tblHocsinh");
                        da.Fill(tbl);
                        return tbl;
                    }
                }
            }

        }
        private void Siso()
        {
            label2.Text = $"Sĩ Số: {drvThisinh.RowCount-1}";
        }
        private void Danhsachthisinh_Load(object sender, EventArgs e)
        {
            hienThisinh();
            Siso();
        }
        private void hienThisinh()
        {
            DataTable t = getHocsinh();
            DataView v = new DataView(t);
            //v.RowFilter = "bGioitinh=True";
            drvThisinh.AutoGenerateColumns = false;
            drvThisinh.ReadOnly = true;
            drvThisinh.DataSource = v;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string c;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.CommandText = "spHocsinh_INSERT";
         
                    try
                    {
                        cmd.Parameters.AddWithValue("@sMahocsinh", txtMathisinh.Text);
                        cmd.Parameters.AddWithValue("@sHoten", txtHoten.Text);
                        cmd.Parameters.AddWithValue("@iKhoi", txtLop.Text);
                        cmd.Parameters.AddWithValue("@tNgaysinh", Convert.ToDateTime(txtNgaysinh.Text));
                        cmd.Parameters.AddWithValue("@sTenDN", txtTenDN.Text);
                        cmd.Parameters.AddWithValue("@sMatkhau", txtMK.Text);
                        cmd.ExecuteNonQuery();
                        c = $"{ drvThisinh.RowCount}";
                        MessageBox.Show("Đã Thêm thí sinh thứ: "+c+" vào danh sách");
                        cnn.Close();
                        hienThisinh();
                        Siso();
                    }
                    catch
                    {
                        MessageBox.Show("Bạn điền sai hoặc thiếu thông tin, kiểm tra lại !", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                   
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "spHocsinh_UPDATE";

                    try
                    {
                        cmd.Parameters.AddWithValue("@sMahocsinh", txtMathisinh.Text);
                        cmd.Parameters.AddWithValue("@sHoten", txtHoten.Text);
                        cmd.Parameters.AddWithValue("@iKhoi", txtLop.Text);
                        cmd.Parameters.AddWithValue("@tNgaysinh", Convert.ToDateTime(txtNgaysinh.Text));
                        cmd.Parameters.AddWithValue("@sTenDN", txtTenDN.Text);
                        cmd.Parameters.AddWithValue("@sMatkhau", txtMK.Text);
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        hienThisinh();
                        MessageBox.Show("Sửa thông tin thí sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thông tin sửa không chính xác!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                DialogResult re = MessageBox.Show("Bạn có muốn xóa thí sinh này không?"
                    , "Thông báo"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);
                if (re == DialogResult.No)
                {
                    return;
                }
                try
                {
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        using (SqlCommand cmd = new SqlCommand("", cnn))
                        {
                            cmd.CommandType = CommandType.Text;

                            cmd.CommandText = "DELETE FROM tblHocsinh WHERE sMahocsinh = '" + txtMathisinh.Text + "'";

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Đã Xóa Thành Công!");
                            cnn.Close();
                            hienThisinh();
                            Siso();
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (!ex.Message.Contains("REFERENCE"))
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, hãy liên hệ với đội ngũ kỹ thuật"
                            , "Kết quả"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thí sinh này đang có điểm thi, không xóa được"
                            , "Kết quả"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string Filter = "{tblHocsinh.iKhoi}>=10";
            if (!string.IsNullOrEmpty(txtHoten.Text.Trim()))
           
                Filter += string.Format("AND {1} LIKE '*{0}*'"
                                                        , txtHoten.Text
                                                        , "{tblHocsinh.sHoten}");
                Report f = new Report();
                f.ShowReport("Danhsachhocsinh.rpt"
                    , "Danh Sách Hoc sinh"
                    , Filter);
                f.Show();
            
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string dieuKienLoc = "iKhoi >= 10";
            if (!string.IsNullOrEmpty(txtHoten.Text))
            {
                dieuKienLoc += string.Format(" AND sHoten LIKE '%{0}%'", txtHoten.Text);
            }
            if (!string.IsNullOrEmpty(txtMathisinh.Text))
            {
                dieuKienLoc += string.Format(" AND sMahocsinh LIKE '%{0}%'", txtMathisinh.Text);
            }

            //lay du lieu tu form
            DataView dvThisinh = drvThisinh.DataSource as DataView;
            dvThisinh.RowFilter = dieuKienLoc;
            drvThisinh.DataSource = dvThisinh;
            Siso();
        }

        private void drvThisinh_Click(object sender, EventArgs e)
        {
            DataView dvKhachhang = (DataView)drvThisinh.DataSource;
            DataRowView row = dvKhachhang[drvThisinh.CurrentRow.Index];
            txtMathisinh.Text = row["sMahocsinh"].ToString();
            txtHoten.Text = row["sHoten"].ToString();
            txtNgaysinh.Text = row["tNgaysinh"].ToString();
            txtLop.Text = row["iKhoi"].ToString();
            txtTenDN.Text = row["sTenDN"].ToString();
            txtMK.Text = row["sMatkhau"].ToString();
        }

        private void btnXemhet_Click(object sender, EventArgs e)
        {
            txtMathisinh.Text = txtHoten.Text = txtNgaysinh.Text = txtLop.Text = txtTenDN.Text = txtMK.Text = string.Empty;
            txtMathisinh.Focus();
            hienThisinh();
            Siso();
        }

        private void quanly_Click(object sender, EventArgs e)
        {
            QuanLy ql = new QuanLy();
            this.Hide();
            ql.ShowDialog();
        }

        private void doimk_Click(object sender, EventArgs e)
        {
            Doimatkhau dmk = new Doimatkhau();
            this.Hide();
            dmk.ShowDialog();
        }

        private void tacgia_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }

        private void txtMathisinh_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMathisinh.Text))
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
    }
}
