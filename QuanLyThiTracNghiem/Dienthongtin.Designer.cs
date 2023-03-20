namespace QuanLyThiTracNghiem
{
    partial class Dienthongtin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatdau = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.doimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.huongdan = new System.Windows.Forms.ToolStripMenuItem();
            this.tacgia = new System.Windows.Forms.ToolStripMenuItem();
            this.cbMa = new System.Windows.Forms.ComboBox();
            this.cbTen = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(90, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÍ SINH ĐIỀN THÔNG TIN CÁ NHÂN";
            // 
            // btnBatdau
            // 
            this.btnBatdau.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatdau.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnBatdau.Location = new System.Drawing.Point(265, 290);
            this.btnBatdau.Name = "btnBatdau";
            this.btnBatdau.Size = new System.Drawing.Size(124, 50);
            this.btnBatdau.TabIndex = 1;
            this.btnBatdau.Text = "Làm bài";
            this.btnBatdau.UseVisualStyleBackColor = false;
            this.btnBatdau.Click += new System.EventHandler(this.btnBatdau_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(155, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã thí sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(192, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(152, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bài thi Môn:";
            // 
            // cbMon
            // 
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Items.AddRange(new object[] {
            "Toán 10",
            "Toán 11",
            "Toán 12"});
            this.cbMon.Location = new System.Drawing.Point(280, 220);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(183, 28);
            this.cbMon.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoat,
            this.doimatkhau,
            this.huongdan,
            this.tacgia});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thoat
            // 
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(61, 24);
            this.thoat.Text = "Thoát";
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // doimatkhau
            // 
            this.doimatkhau.Name = "doimatkhau";
            this.doimatkhau.Size = new System.Drawing.Size(112, 24);
            this.doimatkhau.Text = "Đổi mật khẩu";
            this.doimatkhau.Click += new System.EventHandler(this.doimatkhau_Click);
            // 
            // huongdan
            // 
            this.huongdan.Enabled = false;
            this.huongdan.Name = "huongdan";
            this.huongdan.Size = new System.Drawing.Size(98, 24);
            this.huongdan.Text = "Hướng dẫn";
            // 
            // tacgia
            // 
            this.tacgia.Name = "tacgia";
            this.tacgia.Size = new System.Drawing.Size(69, 24);
            this.tacgia.Text = "Tác giả";
            this.tacgia.Click += new System.EventHandler(this.tacgia_Click);
            // 
            // cbMa
            // 
            this.cbMa.FormattingEnabled = true;
            this.cbMa.Items.AddRange(new object[] {
            "Toán 10",
            "Toán 11",
            "Toán 12"});
            this.cbMa.Location = new System.Drawing.Point(280, 95);
            this.cbMa.Name = "cbMa";
            this.cbMa.Size = new System.Drawing.Size(183, 28);
            this.cbMa.TabIndex = 10;
            // 
            // cbTen
            // 
            this.cbTen.FormattingEnabled = true;
            this.cbTen.Location = new System.Drawing.Point(280, 142);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(183, 67);
            this.cbTen.TabIndex = 11;
            // 
            // Dienthongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 397);
            this.Controls.Add(this.cbTen);
            this.Controls.Add(this.cbMa);
            this.Controls.Add(this.cbMon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBatdau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Dienthongtin";
            this.Text = "Điền thông tin cá nhân";
            this.Load += new System.EventHandler(this.Dienthongtin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thoat;
        private System.Windows.Forms.ToolStripMenuItem doimatkhau;
        private System.Windows.Forms.ToolStripMenuItem huongdan;
        private System.Windows.Forms.ToolStripMenuItem tacgia;
        public System.Windows.Forms.ComboBox cbMon;
        public System.Windows.Forms.ComboBox cbMa;
        public System.Windows.Forms.Button btnBatdau;
        private System.Windows.Forms.CheckedListBox cbTen;
    }
}