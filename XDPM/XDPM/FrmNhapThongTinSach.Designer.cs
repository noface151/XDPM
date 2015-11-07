namespace XDPM
{
    partial class FrmNhapThongTinSach
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
            this.GVSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTim = new System.Windows.Forms.Button();
            this.txtSgianhapden = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSTheLoai = new System.Windows.Forms.ComboBox();
            this.cbSNXB = new System.Windows.Forms.ComboBox();
            this.txtSgianhaptu = new System.Windows.Forms.TextBox();
            this.txtSTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.cbTenTheLoai = new System.Windows.Forms.ComboBox();
            this.cbTenNXB = new System.Windows.Forms.ComboBox();
            this.BTSua = new System.Windows.Forms.Button();
            this.BtThem = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GVSach
            // 
            this.GVSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.Tensach});
            this.GVSach.Location = new System.Drawing.Point(12, 152);
            this.GVSach.Name = "GVSach";
            this.GVSach.Size = new System.Drawing.Size(352, 357);
            this.GVSach.TabIndex = 0;
            this.GVSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVSach_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            // 
            // Tensach
            // 
            this.Tensach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tensach.DataPropertyName = "Tensach";
            this.Tensach.HeaderText = "Tên sách";
            this.Tensach.Name = "Tensach";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Controls.Add(this.txtSgianhapden);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbSTheLoai);
            this.groupBox1.Controls.Add(this.cbSNXB);
            this.groupBox1.Controls.Add(this.txtSgianhaptu);
            this.groupBox1.Controls.Add(this.txtSTenSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(605, 93);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 5;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // txtSgianhapden
            // 
            this.txtSgianhapden.Location = new System.Drawing.Point(550, 43);
            this.txtSgianhapden.Name = "txtSgianhapden";
            this.txtSgianhapden.Size = new System.Drawing.Size(119, 20);
            this.txtSgianhapden.TabIndex = 4;
            this.txtSgianhapden.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đến";
            // 
            // cbSTheLoai
            // 
            this.cbSTheLoai.FormattingEnabled = true;
            this.cbSTheLoai.Location = new System.Drawing.Point(234, 42);
            this.cbSTheLoai.Name = "cbSTheLoai";
            this.cbSTheLoai.Size = new System.Drawing.Size(165, 21);
            this.cbSTheLoai.TabIndex = 2;
            this.cbSTheLoai.Text = "Chọn thể loại";
            // 
            // cbSNXB
            // 
            this.cbSNXB.FormattingEnabled = true;
            this.cbSNXB.Items.AddRange(new object[] {
            "Chọn nhà xuất bản"});
            this.cbSNXB.Location = new System.Drawing.Point(9, 42);
            this.cbSNXB.Name = "cbSNXB";
            this.cbSNXB.Size = new System.Drawing.Size(200, 21);
            this.cbSNXB.TabIndex = 2;
            this.cbSNXB.Text = "Chọn nhà xuất bản";
            // 
            // txtSgianhaptu
            // 
            this.txtSgianhaptu.Location = new System.Drawing.Point(425, 43);
            this.txtSgianhaptu.Name = "txtSgianhaptu";
            this.txtSgianhaptu.Size = new System.Drawing.Size(119, 20);
            this.txtSgianhaptu.TabIndex = 1;
            this.txtSgianhaptu.Text = "0";
            // 
            // txtSTenSach
            // 
            this.txtSTenSach.Location = new System.Drawing.Point(6, 87);
            this.txtSTenSach.Name = "txtSTenSach";
            this.txtSTenSach.Size = new System.Drawing.Size(393, 20);
            this.txtSTenSach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thể loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Danh sách Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.txtTacGia);
            this.groupBox2.Controls.Add(this.txtTensach);
            this.groupBox2.Controls.Add(this.cbTenTheLoai);
            this.groupBox2.Controls.Add(this.cbTenNXB);
            this.groupBox2.Controls.Add(this.BTSua);
            this.groupBox2.Controls.Add(this.BtThem);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(387, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 356);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(83, 293);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(178, 20);
            this.txtSoLuong.TabIndex = 4;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(83, 233);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(178, 20);
            this.txtGia.TabIndex = 4;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(83, 175);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(178, 20);
            this.txtTacGia.TabIndex = 4;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(83, 28);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(259, 20);
            this.txtTensach.TabIndex = 4;
            // 
            // cbTenTheLoai
            // 
            this.cbTenTheLoai.FormattingEnabled = true;
            this.cbTenTheLoai.Location = new System.Drawing.Point(83, 119);
            this.cbTenTheLoai.Name = "cbTenTheLoai";
            this.cbTenTheLoai.Size = new System.Drawing.Size(178, 21);
            this.cbTenTheLoai.TabIndex = 3;
            // 
            // cbTenNXB
            // 
            this.cbTenNXB.FormattingEnabled = true;
            this.cbTenNXB.Location = new System.Drawing.Point(83, 68);
            this.cbTenNXB.Name = "cbTenNXB";
            this.cbTenNXB.Size = new System.Drawing.Size(259, 21);
            this.cbTenNXB.TabIndex = 3;
            // 
            // BTSua
            // 
            this.BTSua.Location = new System.Drawing.Point(234, 327);
            this.BTSua.Name = "BTSua";
            this.BTSua.Size = new System.Drawing.Size(108, 23);
            this.BTSua.TabIndex = 2;
            this.BTSua.Text = "Sửa thông tin sách";
            this.BTSua.UseVisualStyleBackColor = true;
            this.BTSua.Click += new System.EventHandler(this.BTSua_Click);
            // 
            // BtThem
            // 
            this.BtThem.Location = new System.Drawing.Point(142, 327);
            this.BtThem.Name = "BtThem";
            this.BtThem.Size = new System.Drawing.Size(75, 23);
            this.BtThem.TabIndex = 1;
            this.BtThem.Text = "Thêm sách";
            this.BtThem.UseVisualStyleBackColor = true;
            this.BtThem.Click += new System.EventHandler(this.BtThem_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Giá bán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tác giả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thể loại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nhà xuất bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá từ";
            // 
            // FrmNhapThongTinSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GVSach);
            this.Name = "FrmNhapThongTinSach";
            this.Text = "Nhập thông tin sách";
            this.Load += new System.EventHandler(this.FrmNhapThongTinSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtSgianhapden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSTheLoai;
        private System.Windows.Forms.ComboBox cbSNXB;
        private System.Windows.Forms.TextBox txtSgianhaptu;
        private System.Windows.Forms.TextBox txtSTenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTSua;
        private System.Windows.Forms.Button BtThem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.ComboBox cbTenTheLoai;
        private System.Windows.Forms.ComboBox cbTenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

