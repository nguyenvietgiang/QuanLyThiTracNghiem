namespace QuanLyThiTracNghiem
{
    partial class Quanlycauhoi
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.rtbNoidung = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drvCauhoi = new System.Windows.Forms.DataGridView();
            this.Colmacauhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colnoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldapana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldapanb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldapanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldapand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldapandung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxMamon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDapanA = new System.Windows.Forms.TextBox();
            this.txtDapanB = new System.Windows.Forms.TextBox();
            this.txtDapanC = new System.Windows.Forms.TextBox();
            this.txtDapanD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDapandung = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.doimk = new System.Windows.Forms.ToolStripMenuItem();
            this.huongdan = new System.Windows.Forms.ToolStripMenuItem();
            this.tacgia = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drvCauhoi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnThem.Location = new System.Drawing.Point(773, 94);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnSua.Location = new System.Drawing.Point(773, 149);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnXoa.Location = new System.Drawing.Point(773, 206);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // rtbNoidung
            // 
            this.rtbNoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNoidung.Location = new System.Drawing.Point(61, 94);
            this.rtbNoidung.Name = "rtbNoidung";
            this.rtbNoidung.Size = new System.Drawing.Size(642, 96);
            this.rtbNoidung.TabIndex = 3;
            this.rtbNoidung.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Môn ";
            // 
            // drvCauhoi
            // 
            this.drvCauhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvCauhoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colmacauhoi,
            this.Colnoidung,
            this.Coldapana,
            this.Coldapanb,
            this.Coldapanc,
            this.Coldapand,
            this.Coldapandung});
            this.drvCauhoi.Location = new System.Drawing.Point(12, 366);
            this.drvCauhoi.Name = "drvCauhoi";
            this.drvCauhoi.RowHeadersVisible = false;
            this.drvCauhoi.RowHeadersWidth = 51;
            this.drvCauhoi.Size = new System.Drawing.Size(861, 251);
            this.drvCauhoi.TabIndex = 8;
            this.drvCauhoi.Click += new System.EventHandler(this.drvCauhoi_Click);
            // 
            // Colmacauhoi
            // 
            this.Colmacauhoi.DataPropertyName = "iIDcauhoi";
            this.Colmacauhoi.HeaderText = "ID";
            this.Colmacauhoi.MinimumWidth = 6;
            this.Colmacauhoi.Name = "Colmacauhoi";
            this.Colmacauhoi.Width = 50;
            // 
            // Colnoidung
            // 
            this.Colnoidung.DataPropertyName = "sNoidung";
            this.Colnoidung.HeaderText = "Nội dung";
            this.Colnoidung.MinimumWidth = 6;
            this.Colnoidung.Name = "Colnoidung";
            this.Colnoidung.Width = 300;
            // 
            // Coldapana
            // 
            this.Coldapana.DataPropertyName = "sDapanA";
            this.Coldapana.HeaderText = "Đáp án A";
            this.Coldapana.MinimumWidth = 6;
            this.Coldapana.Name = "Coldapana";
            this.Coldapana.Width = 125;
            // 
            // Coldapanb
            // 
            this.Coldapanb.DataPropertyName = "sDapanB";
            this.Coldapanb.HeaderText = "Đáp án B";
            this.Coldapanb.MinimumWidth = 6;
            this.Coldapanb.Name = "Coldapanb";
            this.Coldapanb.Width = 125;
            // 
            // Coldapanc
            // 
            this.Coldapanc.DataPropertyName = "sDapanC";
            this.Coldapanc.HeaderText = "Đáp án C";
            this.Coldapanc.MinimumWidth = 6;
            this.Coldapanc.Name = "Coldapanc";
            this.Coldapanc.Width = 125;
            // 
            // Coldapand
            // 
            this.Coldapand.DataPropertyName = "sDapanD";
            this.Coldapand.HeaderText = "Đáp án D";
            this.Coldapand.MinimumWidth = 6;
            this.Coldapand.Name = "Coldapand";
            this.Coldapand.Width = 125;
            // 
            // Coldapandung
            // 
            this.Coldapandung.DataPropertyName = "sDapandung";
            this.Coldapandung.HeaderText = "Đáp án đúng";
            this.Coldapandung.MinimumWidth = 6;
            this.Coldapandung.Name = "Coldapandung";
            this.Coldapandung.Width = 150;
            // 
            // cbxMamon
            // 
            this.cbxMamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMamon.FormattingEnabled = true;
            this.cbxMamon.Items.AddRange(new object[] {
            "TO10\t",
            "TO11\t",
            "TO12"});
            this.cbxMamon.Location = new System.Drawing.Point(472, 42);
            this.cbxMamon.Name = "cbxMamon";
            this.cbxMamon.Size = new System.Drawing.Size(121, 28);
            this.cbxMamon.TabIndex = 9;
            this.cbxMamon.Tag = "";
            this.cbxMamon.Text = "Tất cả";
            this.cbxMamon.SelectedValueChanged += new System.EventHandler(this.cbxMamon_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "D";
            // 
            // txtDapanA
            // 
            this.txtDapanA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapanA.Location = new System.Drawing.Point(104, 208);
            this.txtDapanA.Name = "txtDapanA";
            this.txtDapanA.Size = new System.Drawing.Size(245, 26);
            this.txtDapanA.TabIndex = 14;
            // 
            // txtDapanB
            // 
            this.txtDapanB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapanB.Location = new System.Drawing.Point(104, 256);
            this.txtDapanB.Name = "txtDapanB";
            this.txtDapanB.Size = new System.Drawing.Size(245, 26);
            this.txtDapanB.TabIndex = 15;
            // 
            // txtDapanC
            // 
            this.txtDapanC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapanC.Location = new System.Drawing.Point(420, 208);
            this.txtDapanC.Name = "txtDapanC";
            this.txtDapanC.Size = new System.Drawing.Size(245, 26);
            this.txtDapanC.TabIndex = 16;
            // 
            // txtDapanD
            // 
            this.txtDapanD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapanD.Location = new System.Drawing.Point(421, 256);
            this.txtDapanD.Name = "txtDapanD";
            this.txtDapanD.Size = new System.Drawing.Size(245, 26);
            this.txtDapanD.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(61, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nội dung câu hỏi";
            // 
            // txtDapandung
            // 
            this.txtDapandung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapandung.Location = new System.Drawing.Point(309, 312);
            this.txtDapandung.Name = "txtDapandung";
            this.txtDapandung.Size = new System.Drawing.Size(66, 26);
            this.txtDapandung.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(183, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Đáp án đúng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(249, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 22;
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
            this.menuStrip1.Size = new System.Drawing.Size(885, 28);
            this.menuStrip1.TabIndex = 23;
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
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnTim.Location = new System.Drawing.Point(773, 266);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(80, 30);
            this.btnTim.TabIndex = 24;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Quanlycauhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 629);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDapandung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDapanD);
            this.Controls.Add(this.txtDapanC);
            this.Controls.Add(this.txtDapanB);
            this.Controls.Add(this.txtDapanA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxMamon);
            this.Controls.Add(this.drvCauhoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbNoidung);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Quanlycauhoi";
            this.Text = "Quản lý kho đề";
            this.Load += new System.EventHandler(this.Quanlycauhoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drvCauhoi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.RichTextBox rtbNoidung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView drvCauhoi;
        private System.Windows.Forms.ComboBox cbxMamon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDapanA;
        private System.Windows.Forms.TextBox txtDapanB;
        private System.Windows.Forms.TextBox txtDapanC;
        private System.Windows.Forms.TextBox txtDapanD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDapandung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colmacauhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colnoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldapana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldapanb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldapanc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldapand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldapandung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanly;
        private System.Windows.Forms.ToolStripMenuItem doimk;
        private System.Windows.Forms.ToolStripMenuItem huongdan;
        private System.Windows.Forms.ToolStripMenuItem tacgia;
        private System.Windows.Forms.Button btnTim;
    }
}