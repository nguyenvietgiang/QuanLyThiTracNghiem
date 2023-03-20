namespace QuanLyThiTracNghiem
{
    partial class Xemketquathichung
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
            this.drvKetqua = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTimkiem = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbxDiem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMon = new System.Windows.Forms.Label();
            this.cbxMonthi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtSocaudung = new System.Windows.Forms.TextBox();
            this.txtMathisinh = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.doimk = new System.Windows.Forms.ToolStripMenuItem();
            this.huongdan = new System.Windows.Forms.ToolStripMenuItem();
            this.tacgia = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.drvKetqua)).BeginInit();
            this.grbTimkiem.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drvKetqua
            // 
            this.drvKetqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvKetqua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.drvKetqua.Location = new System.Drawing.Point(16, 265);
            this.drvKetqua.Margin = new System.Windows.Forms.Padding(4);
            this.drvKetqua.Name = "drvKetqua";
            this.drvKetqua.RowHeadersWidth = 51;
            this.drvKetqua.Size = new System.Drawing.Size(880, 279);
            this.drvKetqua.TabIndex = 0;
            this.drvKetqua.Click += new System.EventHandler(this.drvKetqua_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sMahocsinh";
            this.Column1.HeaderText = "Mã thí sinh";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sHotenKQ";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tNgaythi";
            this.Column3.HeaderText = "Ngày thi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sTenmon";
            this.Column4.HeaderText = "Môn thi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "iSocaudung";
            this.Column5.HeaderText = "Trả lời đúng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "iDiem";
            this.Column6.HeaderText = "Điểm";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // grbTimkiem
            // 
            this.grbTimkiem.Controls.Add(this.btnXoa);
            this.grbTimkiem.Controls.Add(this.cbxDiem);
            this.grbTimkiem.Controls.Add(this.label4);
            this.grbTimkiem.Controls.Add(this.lblMon);
            this.grbTimkiem.Controls.Add(this.cbxMonthi);
            this.grbTimkiem.Controls.Add(this.label3);
            this.grbTimkiem.Controls.Add(this.label2);
            this.grbTimkiem.Controls.Add(this.label1);
            this.grbTimkiem.Controls.Add(this.txtHoten);
            this.grbTimkiem.Controls.Add(this.txtSocaudung);
            this.grbTimkiem.Controls.Add(this.txtMathisinh);
            this.grbTimkiem.Controls.Add(this.btnIn);
            this.grbTimkiem.Controls.Add(this.btnTimkiem);
            this.grbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimkiem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbTimkiem.Location = new System.Drawing.Point(16, 33);
            this.grbTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.grbTimkiem.Name = "grbTimkiem";
            this.grbTimkiem.Padding = new System.Windows.Forms.Padding(4);
            this.grbTimkiem.Size = new System.Drawing.Size(880, 224);
            this.grbTimkiem.TabIndex = 1;
            this.grbTimkiem.TabStop = false;
            this.grbTimkiem.Text = "Hiển Thị";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnXoa.Location = new System.Drawing.Point(301, 170);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 37);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxDiem
            // 
            this.cbxDiem.FormattingEnabled = true;
            this.cbxDiem.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxDiem.Location = new System.Drawing.Point(749, 44);
            this.cbxDiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDiem.Name = "cbxDiem";
            this.cbxDiem.Size = new System.Drawing.Size(52, 28);
            this.cbxDiem.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Điểm:";
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Location = new System.Drawing.Point(360, 48);
            this.lblMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(77, 20);
            this.lblMon.TabIndex = 9;
            this.lblMon.Text = "Môn thi:";
            // 
            // cbxMonthi
            // 
            this.cbxMonthi.FormattingEnabled = true;
            this.cbxMonthi.Location = new System.Drawing.Point(445, 44);
            this.cbxMonthi.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMonthi.Name = "cbxMonthi";
            this.cbxMonthi.Size = new System.Drawing.Size(160, 28);
            this.cbxMonthi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đúng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã thí sinh:";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(145, 119);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(164, 26);
            this.txtHoten.TabIndex = 4;
            // 
            // txtSocaudung
            // 
            this.txtSocaudung.Location = new System.Drawing.Point(445, 119);
            this.txtSocaudung.Margin = new System.Windows.Forms.Padding(4);
            this.txtSocaudung.Name = "txtSocaudung";
            this.txtSocaudung.Size = new System.Drawing.Size(160, 26);
            this.txtSocaudung.TabIndex = 3;
            // 
            // txtMathisinh
            // 
            this.txtMathisinh.Location = new System.Drawing.Point(145, 46);
            this.txtMathisinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMathisinh.Name = "txtMathisinh";
            this.txtMathisinh.Size = new System.Drawing.Size(164, 26);
            this.txtMathisinh.TabIndex = 2;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnIn.Location = new System.Drawing.Point(683, 138);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(120, 37);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In kết quả";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimkiem.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnTimkiem.Location = new System.Drawing.Point(683, 81);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(120, 37);
            this.btnTimkiem.TabIndex = 0;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanly,
            this.doimk,
            this.huongdan,
            this.tacgia});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanly
            // 
            this.quanly.Name = "quanly";
            this.quanly.Size = new System.Drawing.Size(73, 24);
            this.quanly.Text = "Quản lý";
            this.quanly.Click += new System.EventHandler(this.quanly_Click);
            // 
            // doimk
            // 
            this.doimk.Name = "doimk";
            this.doimk.Size = new System.Drawing.Size(112, 24);
            this.doimk.Text = "Đổi mật khẩu";
            this.doimk.Click += new System.EventHandler(this.doimk_Click);
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
            // Xemketquathichung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 559);
            this.Controls.Add(this.grbTimkiem);
            this.Controls.Add(this.drvKetqua);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Xemketquathichung";
            this.Text = "Xem kết quả thi chung";
            this.Load += new System.EventHandler(this.Xemketquathichung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drvKetqua)).EndInit();
            this.grbTimkiem.ResumeLayout(false);
            this.grbTimkiem.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView drvKetqua;
        private System.Windows.Forms.GroupBox grbTimkiem;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.ComboBox cbxMonthi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtSocaudung;
        private System.Windows.Forms.TextBox txtMathisinh;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cbxDiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quanly;
        private System.Windows.Forms.ToolStripMenuItem doimk;
        private System.Windows.Forms.ToolStripMenuItem huongdan;
        private System.Windows.Forms.ToolStripMenuItem tacgia;
    }
}