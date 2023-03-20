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
    public partial class Quanlycauhoi : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        private string m_KHReportFilter;
        public Quanlycauhoi()
        {
            InitializeComponent();
        }

        private DataTable getCauhoi()
        {
            string procName = "spCauhoi_GET";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(procName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable("tblCauhoi");
                        da.Fill(tbl);
                        return tbl;
                    }
                }
            }

        }
        private void hienCauhoi()
        {
            DataTable t = getCauhoi();
            DataView v = new DataView(t);
            drvCauhoi.AutoGenerateColumns = false;
            drvCauhoi.ReadOnly = true;
            drvCauhoi.DataSource = v;
        }
        private void Quanlycauhoi_Load(object sender, EventArgs e)
        {
            hienCauhoi();
        }

        private void drvCauhoi_Click(object sender, EventArgs e)
        {
            DataView dvCauhoi = (DataView)drvCauhoi.DataSource;
            DataRowView row = dvCauhoi[drvCauhoi.CurrentRow.Index];
            txtID.Text = row["iIDcauhoi"].ToString();
            rtbNoidung.Text = row["sNoidung"].ToString();
            txtDapanA.Text = row["sDapanA"].ToString();
            txtDapanB.Text = row["sDapanB"].ToString();
            txtDapanC.Text = row["sDapanC"].ToString();
            txtDapanD.Text = row["sDapanD"].ToString();
            txtDapandung.Text = row["sDapandung"].ToString();
            cbxMamon.Text = row["sMamon"].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "spCauhoi_INSERT";

                    try
                    {
                        cmd.Parameters.Add("@iIDcauhoi", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.AddWithValue("@sNoidung", rtbNoidung.Text);
                        cmd.Parameters.AddWithValue("@sDapanA", txtDapanA.Text);
                        cmd.Parameters.AddWithValue("@sDapanB", txtDapanB.Text);
                        cmd.Parameters.AddWithValue("@sDapanC", txtDapanC.Text);
                        cmd.Parameters.AddWithValue("@sDapanD", txtDapanD.Text);
                        cmd.Parameters.AddWithValue("@sDapandung", txtDapandung.Text);
                        cmd.Parameters.AddWithValue("@sMamon", cbxMamon.Text);
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        hienCauhoi();
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi khi thêm câu hỏi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    cmd.CommandText = "spCauhoi_UPDATE";
                    try
                    {
                        cmd.Parameters.AddWithValue("@iIDcauhoi", txtID.Text);
                        cmd.Parameters.AddWithValue("@sNoidung", rtbNoidung.Text);
                        cmd.Parameters.AddWithValue("@sDapanA", txtDapanA.Text);
                        cmd.Parameters.AddWithValue("@sDapanB", txtDapanB.Text);
                        cmd.Parameters.AddWithValue("@sDapanC", txtDapanC.Text);
                        cmd.Parameters.AddWithValue("@sDapanD", txtDapanD.Text);
                        cmd.Parameters.AddWithValue("@sDapandung", txtDapandung.Text);
                        cmd.Parameters.AddWithValue("@sMamon", cbxMamon.Text);
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        hienCauhoi();
                        MessageBox.Show("Sửa câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    try {
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "DELETE FROM tblCauhoi WHERE iIDcauhoi = '" + txtID.Text + "'";

                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        hienCauhoi();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } catch
                    {
                        MessageBox.Show("Có lỗi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    

                }
            }
        }

        private void cbxMamon_SelectedValueChanged(object sender, EventArgs e)
        {
           
                string dieuKienLoc = "iIDcauhoi>0";
                if (!string.IsNullOrEmpty(cbxMamon.Text))
                {
                    dieuKienLoc += string.Format(" AND sMamon LIKE '%{0}%'", cbxMamon.Text);
                }
                //lay du lieu tu form
                DataView dvCauhoi = drvCauhoi.DataSource as DataView;
                dvCauhoi.RowFilter = dieuKienLoc;
                drvCauhoi.DataSource = dvCauhoi;
           
        }

        private void doimk_Click(object sender, EventArgs e)
        {
            Doimatkhau dmk = new Doimatkhau();
            this.Hide();
            dmk.ShowDialog();
        }

        private void quanly_Click(object sender, EventArgs e)
        {
            QuanLy ql = new QuanLy();
            this.Hide();
            ql.ShowDialog();
        }

        private void tacgia_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string conditionSearch = "iIDcauhoi is not null";
            m_KHReportFilter = "len({tblCauhoi.iIDcauhoi})>0 ";

            if (!string.IsNullOrEmpty(rtbNoidung.Text))
            {
                conditionSearch += string.Format(" AND sNoidung LIKE '%{0}%' ", rtbNoidung.Text);
                m_KHReportFilter += string.Format("AND {1} LIKE '*{0}*'"
                                                        , rtbNoidung.Text
                                                        , "{tblCauhoi.sNoidung}");
              
            }
            DataView dvct = drvCauhoi.DataSource as DataView;
            dvct.RowFilter = conditionSearch;
            drvCauhoi.DataSource = dvct;
        }

       
    }
}
