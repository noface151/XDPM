namespace XDPM
{
    partial class FrmNhaXuatBan
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
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.txtTienNo = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.BTSua = new System.Windows.Forms.Button();
            this.BtThem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btTim = new System.Windows.Forms.Button();
            this.txtSNoden = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSNotu = new System.Windows.Forms.TextBox();
            this.txtSTenNXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GVNXB = new System.Windows.Forms.DataGridView();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDuong = new System.Windows.Forms.TextBox();
            this.txtSQuan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVNXB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSoTK
            // 
            this.txtSoTK.Location = new System.Drawing.Point(103, 224);
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(178, 20);
            this.txtSoTK.TabIndex = 4;
            // 
            // txtTienNo
            // 
            this.txtTienNo.Location = new System.Drawing.Point(105, 289);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.ReadOnly = true;
            this.txtTienNo.Size = new System.Drawing.Size(178, 20);
            this.txtTienNo.TabIndex = 4;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(103, 28);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(239, 20);
            this.txtTenNXB.TabIndex = 4;
            // 
            // BTSua
            // 
            this.BTSua.Location = new System.Drawing.Point(196, 327);
            this.BTSua.Name = "BTSua";
            this.BTSua.Size = new System.Drawing.Size(156, 23);
            this.BTSua.TabIndex = 2;
            this.BTSua.Text = "Sửa thông tin nhà xuất bản";
            this.BTSua.UseVisualStyleBackColor = true;
            this.BTSua.Click += new System.EventHandler(this.BTSua_Click);
            // 
            // BtThem
            // 
            this.BtThem.Location = new System.Drawing.Point(77, 327);
            this.BtThem.Name = "BtThem";
            this.BtThem.Size = new System.Drawing.Size(113, 23);
            this.BtThem.TabIndex = 1;
            this.BtThem.Text = "Thêm Nhà xuất bản";
            this.BtThem.UseVisualStyleBackColor = true;
            this.BtThem.Click += new System.EventHandler(this.BtThem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số tài khoản";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tiền nợ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên nhà xuất bản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.txtSoTK);
            this.groupBox2.Controls.Add(this.txtTienNo);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtTenNXB);
            this.groupBox2.Controls.Add(this.BTSua);
            this.groupBox2.Controls.Add(this.BtThem);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(408, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 356);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhà xuất bản";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(103, 150);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(178, 20);
            this.txtSDT.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(105, 84);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(239, 20);
            this.txtDiaChi.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Danh sách Sách";
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(670, 93);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 5;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // txtSNoden
            // 
            this.txtSNoden.Location = new System.Drawing.Point(626, 43);
            this.txtSNoden.Name = "txtSNoden";
            this.txtSNoden.Size = new System.Drawing.Size(119, 20);
            this.txtSNoden.TabIndex = 4;
            this.txtSNoden.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đến";
            // 
            // txtSNotu
            // 
            this.txtSNotu.Location = new System.Drawing.Point(501, 43);
            this.txtSNotu.Name = "txtSNotu";
            this.txtSNotu.Size = new System.Drawing.Size(119, 20);
            this.txtSNotu.TabIndex = 1;
            this.txtSNotu.Text = "0";
            // 
            // txtSTenNXB
            // 
            this.txtSTenNXB.Location = new System.Drawing.Point(6, 87);
            this.txtSTenNXB.Name = "txtSTenNXB";
            this.txtSTenNXB.Size = new System.Drawing.Size(393, 20);
            this.txtSTenNXB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhà xuất bản";
            // 
            // GVNXB
            // 
            this.GVNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNXB,
            this.Tensach});
            this.GVNXB.Location = new System.Drawing.Point(12, 162);
            this.GVNXB.Name = "GVNXB";
            this.GVNXB.Size = new System.Drawing.Size(390, 357);
            this.GVNXB.TabIndex = 5;
            this.GVNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVNXB_CellClick);
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.Name = "MaNXB";
            // 
            // Tensach
            // 
            this.Tensach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tensach.DataPropertyName = "TenNXB";
            this.Tensach.HeaderText = "Tên Nhà xuất bản";
            this.Tensach.Name = "Tensach";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSDuong);
            this.groupBox1.Controls.Add(this.txtSQuan);
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Controls.Add(this.txtSNoden);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSNotu);
            this.groupBox1.Controls.Add(this.txtSTenNXB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 122);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quận";
            // 
            // txtSDuong
            // 
            this.txtSDuong.Location = new System.Drawing.Point(238, 43);
            this.txtSDuong.Name = "txtSDuong";
            this.txtSDuong.Size = new System.Drawing.Size(225, 20);
            this.txtSDuong.TabIndex = 6;
            // 
            // txtSQuan
            // 
            this.txtSQuan.Location = new System.Drawing.Point(9, 43);
            this.txtSQuan.Name = "txtSQuan";
            this.txtSQuan.Size = new System.Drawing.Size(187, 20);
            this.txtSQuan.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nợ từ";
            // 
            // FrmNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GVNXB);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNhaXuatBan";
            this.Text = "Nhập thông tin nhà xuất bản";
            this.Load += new System.EventHandler(this.FrmNhaXuatBan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVNXB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoTK;
        private System.Windows.Forms.TextBox txtTienNo;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.Button BTSua;
        private System.Windows.Forms.Button BtThem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtSNoden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSNotu;
        private System.Windows.Forms.TextBox txtSTenNXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GVNXB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSQuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDuong;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
    }
}