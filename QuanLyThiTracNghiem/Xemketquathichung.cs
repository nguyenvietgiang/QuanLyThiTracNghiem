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
    public partial class Xemketquathichung : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;

        public Xemketquathichung()
        {
            InitializeComponent();
        }

        private DataTable getKetqua()
        {
            string procName = "spKetqua_GET";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(procName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable("tblKetqua");
                        da.Fill(tbl);
                        return tbl;
                    }
                }
            }

        }

        private void hienKetqua()
        {
            DataTable t = getKetqua();
            DataView v = new DataView(t);
            drvKetqua.AutoGenerateColumns = false;
            drvKetqua.ReadOnly = true;
            drvKetqua.DataSource = v;
        }

        private void Xemketquathichung_Load(object sender, EventArgs e)
        {
            hienKetqua();
        }

        private void drvKetqua_Click(object sender, EventArgs e)
        {
            DataView dvKetqua = (DataView)drvKetqua.DataSource;
            DataRowView row = dvKetqua[drvKetqua.CurrentRow.Index];
            txtMathisinh.Text = row["sMahocsinh"].ToString();
            txtHoten.Text = row["sHotenKQ"].ToString();
            cbxMonthi.Text = row["sTenmon"].ToString();
            txtSocaudung.Text = row["iSocaudung"].ToString();
            cbxDiem.Text = row["iDiem"].ToString();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string dieuKienLoc = "iMaketqua>0";
            if (!string.IsNullOrEmpty(txtMathisinh.Text))
            {
                dieuKienLoc += string.Format(" AND sMahocsinh LIKE '%{0}%'", txtMathisinh.Text);
            }
            if (!string.IsNullOrEmpty(txtHoten.Text))
            {
                dieuKienLoc += string.Format(" AND sHotenKQ LIKE '%{0}%'", txtHoten.Text);
            }
            if (!string.IsNullOrEmpty(txtSocaudung.Text))
            {
                dieuKienLoc += string.Format(" AND iSocaudung = {0}", txtSocaudung.Text);
            }
            if (!string.IsNullOrEmpty(cbxDiem.Text))
            {
                dieuKienLoc += string.Format(" AND iDiem = {0}", cbxDiem.Text);
            }

            //lay du lieu tu form
            DataView dvKetqua = drvKetqua.DataSource as DataView;
            dvKetqua.RowFilter = dieuKienLoc;
            drvKetqua.DataSource = dvKetqua;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string Filter = "{tblKetqua.iMaketqua}>0";
            if (!string.IsNullOrEmpty(txtMathisinh.Text.Trim()))

                Filter += string.Format("AND {1} LIKE '*{0}*'"
                                                        , txtMathisinh.Text
                                                        , "{tblKetqua.sMahocsinh}");
            Report f = new Report();
            f.ShowReport("Ketquathi.rpt"
                , "Danh Sách ket qua"
                , Filter);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "DELETE FROM tblKetqua WHERE sMahocsinh = '" + txtMathisinh.Text + "'";

                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    hienKetqua();
                }
            }
        }

        private void tacgia_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
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
    }
}
