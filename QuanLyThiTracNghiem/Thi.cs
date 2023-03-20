using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace QuanLyThiTracNghiem
{
    public partial class Thi : Form
    {
        int s, m, h;
        public int diemThi;
        DataTable bangDeThi = new DataTable();
        int cauHienTai = 0;
        public int soCauDung = 0;
        int soCauHoi = 0;
        public bool deThi = false;
        int soCauNgauNhien = 10;

        string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;

        public Thi(string chonmon, string dienten, string dienma)
        {
            InitializeComponent();
            gettenmon = chonmon;
            getmathisinh = dienma;
            gettenthisinh = dienten;
            //lớp 10
            if(chonmon == "Toán 10")
            {
                lblMamon.Text = "TO10";
            }
            if (chonmon == "Toán 11")
            {
                lblMamon.Text = "TO11";
            }
            if (chonmon == "Toán 12")
            {
                lblMamon.Text = "TO12";
            }
        }
        
        void loadDeThi()
        {
            
            try
            {
                using(SqlConnection cnn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblCauhoi WHERE sMamon= 'TO10'", cnn);
                    DataTable Bangcauhoi = new DataTable();
                    da.Fill(Bangcauhoi);
                    TaoBangRandomCauHoi(Bangcauhoi);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // thời gian làm bài
            m = 0;
            s = 0;
            h = 0; 
        }

        //tạo bảng random câu hỏi
        void TaoBangRandomCauHoi(DataTable Bangcauhoi)
        {
            try
            {
                Random rd = new Random();
                ArrayList arrCauhoi = new ArrayList();
                arrCauhoi.Clear();
                int x, dem = 0;
                int SoCauBangGoc = Bangcauhoi.Rows.Count;
                while (dem < soCauNgauNhien)
                {
                    x = rd.Next(0, SoCauBangGoc);
                    if (!arrCauhoi.Contains(x))
                    {
                        arrCauhoi.Add(x);
                        dem++;
                    }
                }
                for(int j = SoCauBangGoc - 1; j>=0; j--)
                {
                    if (!arrCauhoi.Contains(j))
                    {
                        Bangcauhoi.Rows.RemoveAt(j);
                    }
                }
                bangDeThi = Bangcauhoi;
                bangDeThi.Columns.Add("tblCauhoi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void TaoBangRandomCauTraLoi()
        {
            try
            {
                soCauHoi = soCauNgauNhien;//bangDeThi.Rows.Count;
                string DapAnDung = "";
                string A, B, C, D;
                int DapAn;
                Random Rnd = new Random();
                ArrayList ArrDapAn = new ArrayList();
                for (int i = 0; i < soCauHoi; i++)
                {
                    A = "";
                    B = "";
                    C = "";
                    D = "";
                    DapAnDung = "";
                    DapAn = 0;
                    ArrDapAn.Clear();
                    ArrDapAn.Add(2);
                    ArrDapAn.Add(3);
                    ArrDapAn.Add(4);
                    ArrDapAn.Add(5);

                    DapAn = Rnd.Next(ArrDapAn.Count);
                    A = bangDeThi.Rows[i][(int)ArrDapAn[DapAn]].ToString();
                    if ((bangDeThi.Rows[i][6].ToString().ToUpper().Contains("A") && (int)ArrDapAn[DapAn] == 2) || (bangDeThi.Rows[i][6].ToString().ToUpper().Contains("B") && (int)ArrDapAn[DapAn] == 3) || (bangDeThi.Rows[i][6].ToString().ToUpper().Contains("C") && (int)ArrDapAn[DapAn] == 4) || (bangDeThi.Rows[i][6].ToString().ToUpper().Contains("D") && (int)ArrDapAn[DapAn] == 5))
                        DapAnDung += "A";
                    ArrDapAn.RemoveAt(DapAn);
                    DapAn = Rnd.Next(ArrDapAn.Count);
                    B = bangDeThi.Rows[i][(int)ArrDapAn[DapAn]].ToString();
                    if ((bangDeThi.Rows[i][6].ToString().ToUpper().Contains("A") && (int)ArrDapAn[DapAn] == 2) || (bangDeThi.Rows[i][6].ToString().ToUpper().Contains("B") && (int)ArrDapAn[DapAn] == 3) || (bangDeThi.Rows[i][6].ToString().ToUpper().Contains("C") && (int)ArrDapAn[DapAn] == 4) || (bangDeThi.Rows[i][6].ToString().ToUpper().Contains("D") && (int)ArrDapAn[DapAn] == 5))
                        DapAnDung += "B";
                    ArrDapAn.RemoveAt(DapAn);
                    DapAn = Rnd.Next(ArrDapAn.Count);
                    C = bangDeThi.Rows[i][(int)ArrDapAn[DapAn]].ToString();
                    if ((bangDeThi.Rows[i][6].ToString().ToUpper().Contains("A") && (int)ArrDapAn[DapAn] == 2) || (bangDeThi.Rows[i][6].ToString().ToUpper().Contains("B") && (int)ArrDapAn[DapAn] == 3) || (bangDeThi.Rows[i][6].ToString().ToUpper().Contains("C") && (int)ArrDapAn[DapAn] == 4) || (bangDeThi.Rows[i][6].ToString().ToUpper().Contains("D") && (int)ArrDapAn[DapAn] == 5))
                        DapAnDung += "C";
                    ArrDapAn.RemoveAt(DapAn);
                    DapAn = Rnd.Next(ArrDapAn.Count);
                    D = bangDeThi.Rows[i][(int)ArrDapAn[DapAn]].ToString();
                    if ((bangDeThi.Rows[i][6].ToString().ToUpper().Contains("A") && (int)ArrDapAn[DapAn] == 2) || (bangDeThi.Rows[i][6].ToString().ToUpper().Contains("B") && (int)ArrDapAn[DapAn] == 3) || (bangDeThi.Rows[i][6].ToString().ToUpper().Contains("C") && (int)ArrDapAn[DapAn] == 4) || (bangDeThi.Rows[i][6].ToString().ToUpper().Contains("D") && (int)ArrDapAn[DapAn] == 5))
                        DapAnDung += "D";
                    bangDeThi.Rows[i][2] = A;
                    bangDeThi.Rows[i][3] = B;
                    bangDeThi.Rows[i][4] = C;
                    bangDeThi.Rows[i][5] = D;
                    bangDeThi.Rows[i][6] = DapAnDung;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void Thi_Load(object sender, EventArgs e)
        {
            lblNgaythi.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

            {
                try
                {
                    if (deThi == true)
                        loadDeThi();
                    else
                        loadDeThi();
                    TaoBangRandomCauTraLoi();
                    loadCauHoiVaoControl();
                    timer1.Start();

                    btnCautruoc.Enabled = false;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        void loadCauHoiVaoControl()
        {
            try
            {
                groupBox1.Text = "Câu: " + (cauHienTai + 1).ToString();
                lblNoidungcauhoi.Text = bangDeThi.Rows[cauHienTai][1].ToString();
                lblA.Text = bangDeThi.Rows[cauHienTai][2].ToString();
                lblB.Text = bangDeThi.Rows[cauHienTai][3].ToString();
                lblC.Text = bangDeThi.Rows[cauHienTai][4].ToString();
                lblD.Text = bangDeThi.Rows[cauHienTai][5].ToString();
                if (bangDeThi.Rows[cauHienTai][7].ToString().Contains("A"))
                {
                    rdbA.Checked = true;
                }
                if (bangDeThi.Rows[cauHienTai][7].ToString().Contains("B"))
                {
                    rdbB.Checked = true;
                }
                if (bangDeThi.Rows[cauHienTai][7].ToString().Contains("C"))
                {
                    rdbC.Checked = true;
                }
                if (bangDeThi.Rows[cauHienTai][7].ToString().Contains("D"))
                {
                    rdbD.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Ghi lại đáp án
        void GhiLaiDapAnTS()
        {
            string DapAnTS = "";
            if (rdbA.Checked == true)
                DapAnTS += "A";
            if (rdbB.Checked == true)
                DapAnTS += "B";
            if (rdbC.Checked == true)
                DapAnTS += "C";
            if (rdbD.Checked == true)
                DapAnTS += "D";
            bangDeThi.Rows[cauHienTai][7] = DapAnTS;
        }

        //lay thong tin//
        public string gettenmon
        {
            set
            {
                this.lblMonthi.Text = value;
            }
        }
        public string getmathisinh
        {
            set
            {
                this.lblMathisinh.Text = value;

            }

        }
        public string gettenthisinh
        {
            set
            {
                this.lblHotenthisinh.Text = value;
            }
        }

        // nút câu trước 
        private void btnCautruoc_Click(object sender, EventArgs e)
        {
            try
            {
                GhiLaiDapAnTS();
                if (cauHienTai > 0)
                {
                    GhiLaiDapAnTS();
                    btnCautiep.Enabled = true;
                    rdbA.Checked = false;
                    rdbB.Checked = false;
                    rdbC.Checked = false;
                    rdbD.Checked = false;
                    cauHienTai--;
                    loadCauHoiVaoControl();
                }
                if (cauHienTai == 0)
                    btnCautruoc.Enabled = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnCautiep_Click(object sender, EventArgs e)
        {
            try
            {
                GhiLaiDapAnTS();
                if (cauHienTai < soCauHoi - 1)
                {
                    GhiLaiDapAnTS();
                    btnCautruoc.Enabled = true;
                    rdbA.Checked = false;
                    rdbB.Checked = false;
                    rdbC.Checked = false;
                    rdbD.Checked = false;
                    cauHienTai++;
                    loadCauHoiVaoControl();
                }
                if (cauHienTai == soCauHoi - 1)
                    btnCautiep.Enabled = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        int th = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            s--;
            th--;
            if (th == 0)
            {
                timer1.Stop();
                MessageBox.Show("Hết giờ làm bài!", "Thông báo");
                rdbA.Checked = false;
                rdbB.Checked = false;
                rdbC.Checked = false;
                rdbD.Checked = false;

                GhiLaiDapAnTS();
                soCauDung = 0;
                for (int i = 0; i < soCauHoi; i++)
                {
                    if (bangDeThi.Rows[i][6].ToString().ToUpper() == bangDeThi.Rows[i][7].ToString().ToUpper())
                        soCauDung++;
                }
                int diem;
                diem = soCauDung * 1;
                MessageBox.Show("Đúng " + soCauDung.ToString() + " câu " + "  Bạn được  " + diem.ToString() + "  điểm ");
                this.Close();

            }
            if (s == 0)
            {
                m--;
                if (m == 0)
                {
                    s = 60;
                    th = s;
                }
                s = 60;
            }

            lblThoigian.Text = h.ToString() + "  : " + m.ToString() + " : " + s.ToString();

        }

        private void btnNopbai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn kết thúc bài làm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                try
                {
                    timer1.Stop();
                    btnNopbai.Enabled = false;

                    GhiLaiDapAnTS();
                    soCauDung = 0;
                    for (int i = 0; i < soCauHoi; i++)
                    {
                        if (bangDeThi.Rows[i][6].ToString().ToUpper() == bangDeThi.Rows[i][7].ToString().ToUpper())
                            soCauDung++;

                    }

                    diemThi = soCauDung * 1;
                    MessageBox.Show("Đúng " + soCauDung.ToString() + " câu " + "  Bạn được  " + diemThi.ToString() + "  điểm ");
                    this.Close();

                    string tenmon = lblMonthi.Text;
                    string ten = lblHotenthisinh.Text;
                    string mats = lblMathisinh.Text;
                    string diem1 = diemThi.ToString();
                    string socaudung = soCauDung.ToString();
                    Ketquathicanhan frmKetquathicanhan = new Ketquathicanhan(tenmon, ten, mats, diem1, socaudung);
                    frmKetquathicanhan.ShowDialog();
                    //them form ket qua 

                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            else
            { return; }
        }
    }
}
