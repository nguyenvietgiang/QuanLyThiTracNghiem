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
    public partial class Ketquathicanhan : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        SqlConnection cnn;
        int socausai;
        string strngay;
        public Ketquathicanhan(string strtenmon, string strten, string strma, string strdiem, string strsocaudung)
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            InitializeComponent();

            getvalueformtenmon = strtenmon;//ten mon thi
            getvalueformdienten = strten;//ten
            getvalueformdienma = strma;//ma thi sinh
            getvaluediem = strdiem;//diem
            getvaluesocaudung = strsocaudung;//so cau dung
            socausai = 40 - int.Parse(strsocaudung);//so cau sai
            //lbsocausai.Text = socausai.ToString();
        }

        //lay du lieu tu form thi
        public string getvalueformtenmon
        {
            set
            {
                this.lblTenmon.Text = value;
            }
        }
        public string getvalueformdienten
        {
            set
            {
                this.lblHoten.Text = value;
            }

        }
        public string getvalueformdienma
        {
            set
            {
                this.lblMathisinh.Text = value;
            }
        }
        public string getvaluediem
        {
            set
            {
                this.lblDiem.Text = value;
            }
        }
        public string getvaluesocaudung
        {
            set
            {
                this.lblSocaudung.Text = value;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ketquathicanhan_Load(object sender, EventArgs e)
        {
            string strten, strma, strsocaudung, strdiem, strMon;
            strten = lblHoten.Text;
            strma = lblMathisinh.Text;
            strsocaudung = lblSocaudung.Text;
            strMon = lblTenmon.Text;
            strdiem = lblDiem.Text;
            strngay = DateTime.Now.ToShortDateString();
            lblNgaythi.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "spKetqua_INSERT";

                    try
                    {
                        cmd.Parameters.Add("@iMaketqua", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.AddWithValue("@sMahocsinh", strma);
                        cmd.Parameters.AddWithValue("@sHotenKQ", strten);
                        cmd.Parameters.AddWithValue("@sTenmon", strMon);
                        cmd.Parameters.AddWithValue("@iDiem", strdiem);
                        cmd.Parameters.AddWithValue("@tNgaythi", strngay);
                        cmd.Parameters.AddWithValue("@iSocaudung", strsocaudung);
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi lưu kết quả!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
