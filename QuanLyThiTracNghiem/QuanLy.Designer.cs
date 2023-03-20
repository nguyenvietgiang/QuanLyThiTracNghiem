namespace QuanLyThiTracNghiem
{
    partial class QuanLy
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.côngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indsThisinh = new System.Windows.Forms.ToolStripMenuItem();
            this.inKetquathi = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripQLKD = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripQLTS = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripXemKQ = new System.Windows.Forms.ToolStripMenuItem();
            this.doimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tacgia = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXemkq = new System.Windows.Forms.Button();
            this.btnQLkhode = new System.Windows.Forms.Button();
            this.btnQLthisinh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.côngCụToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.doimatkhau,
            this.hướngDẫnToolStripMenuItem,
            this.tacgia});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // côngCụToolStripMenuItem
            // 
            this.côngCụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indsThisinh,
            this.inKetquathi});
            this.côngCụToolStripMenuItem.Name = "côngCụToolStripMenuItem";
            this.côngCụToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.côngCụToolStripMenuItem.Text = "Công cụ";
            // 
            // indsThisinh
            // 
            this.indsThisinh.Name = "indsThisinh";
            this.indsThisinh.Size = new System.Drawing.Size(225, 26);
            this.indsThisinh.Text = "In danh sách thí sinh";
            this.indsThisinh.Click += new System.EventHandler(this.indsThisinh_Click);
            // 
            // inKetquathi
            // 
            this.inKetquathi.Name = "inKetquathi";
            this.inKetquathi.Size = new System.Drawing.Size(225, 26);
            this.inKetquathi.Text = "In kết quả thi";
            this.inKetquathi.Click += new System.EventHandler(this.inKetquathi_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripQLKD,
            this.mstripQLTS,
            this.mstripXemKQ});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mstripQLKD
            // 
            this.mstripQLKD.Name = "mstripQLKD";
            this.mstripQLKD.Size = new System.Drawing.Size(196, 26);
            this.mstripQLKD.Text = "Quản lý kho đề";
            this.mstripQLKD.Click += new System.EventHandler(this.mstripQLKD_Click);
            // 
            // mstripQLTS
            // 
            this.mstripQLTS.Name = "mstripQLTS";
            this.mstripQLTS.Size = new System.Drawing.Size(196, 26);
            this.mstripQLTS.Text = "Quản lý thí sinh";
            this.mstripQLTS.Click += new System.EventHandler(this.mstripQLTS_Click);
            // 
            // mstripXemKQ
            // 
            this.mstripXemKQ.Name = "mstripXemKQ";
            this.mstripXemKQ.Size = new System.Drawing.Size(196, 26);
            this.mstripXemKQ.Text = "Xem kết quả thi";
            this.mstripXemKQ.Click += new System.EventHandler(this.mstripXemKQ_Click);
            // 
            // doimatkhau
            // 
            this.doimatkhau.Name = "doimatkhau";
            this.doimatkhau.Size = new System.Drawing.Size(112, 24);
            this.doimatkhau.Text = "Đổi mật khẩu";
            this.doimatkhau.Click += new System.EventHandler(this.doimatkhau_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Enabled = false;
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // tacgia
            // 
            this.tacgia.Name = "tacgia";
            this.tacgia.Size = new System.Drawing.Size(89, 24);
            this.tacgia.Text = "Thông Tin";
            this.tacgia.Click += new System.EventHandler(this.tacgia_Click);
            // 
            // btnXemkq
            // 
            this.btnXemkq.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXemkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnXemkq.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnXemkq.Location = new System.Drawing.Point(572, 203);
            this.btnXemkq.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemkq.Name = "btnXemkq";
            this.btnXemkq.Size = new System.Drawing.Size(290, 61);
            this.btnXemkq.TabIndex = 2;
            this.btnXemkq.Text = "Xem kết quả thi";
            this.btnXemkq.UseVisualStyleBackColor = false;
            this.btnXemkq.Click += new System.EventHandler(this.btnXemkq_Click);
            // 
            // btnQLkhode
            // 
            this.btnQLkhode.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnQLkhode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnQLkhode.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnQLkhode.Location = new System.Drawing.Point(0, 203);
            this.btnQLkhode.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLkhode.Name = "btnQLkhode";
            this.btnQLkhode.Size = new System.Drawing.Size(290, 61);
            this.btnQLkhode.TabIndex = 0;
            this.btnQLkhode.Text = "Quản lý câu hỏi";
            this.btnQLkhode.UseVisualStyleBackColor = false;
            this.btnQLkhode.Click += new System.EventHandler(this.btnQLkhode_Click);
            // 
            // btnQLthisinh
            // 
            this.btnQLthisinh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnQLthisinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnQLthisinh.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnQLthisinh.Location = new System.Drawing.Point(285, 203);
            this.btnQLthisinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLthisinh.Name = "btnQLthisinh";
            this.btnQLthisinh.Size = new System.Drawing.Size(290, 61);
            this.btnQLthisinh.TabIndex = 1;
            this.btnQLthisinh.Text = "Quản lý thí sinh";
            this.btnQLthisinh.UseVisualStyleBackColor = false;
            this.btnQLthisinh.Click += new System.EventHandler(this.btnQLthisinh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThiTracNghiem.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(862, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 263);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnXemkq);
            this.Controls.Add(this.btnQLthisinh);
            this.Controls.Add(this.btnQLkhode);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "QuanLy";
            this.Text = "Chương trình quản lý thi trắc nghiệm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem côngCụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indsThisinh;
        private System.Windows.Forms.ToolStripMenuItem inKetquathi;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tacgia;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstripQLKD;
        private System.Windows.Forms.ToolStripMenuItem mstripQLTS;
        private System.Windows.Forms.ToolStripMenuItem mstripXemKQ;
        private System.Windows.Forms.ToolStripMenuItem doimatkhau;
        private System.Windows.Forms.Button btnXemkq;
        private System.Windows.Forms.Button btnQLkhode;
        private System.Windows.Forms.Button btnQLthisinh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}