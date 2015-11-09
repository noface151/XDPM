namespace XDPM
{
    partial class FrmNhapSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtXoa = new System.Windows.Forms.Button();
            this.BtCTPN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtSua = new System.Windows.Forms.Button();
            this.GVPN = new System.Windows.Forms.DataGridView();
            this.BtThem = new System.Windows.Forms.Button();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.txtNguoiGiao = new System.Windows.Forms.TextBox();
            this.dateNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.CbNXB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtTimKiem = new System.Windows.Forms.Button();
            this.txtSTiennhapden = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSTiennhaptu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateDenngay = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTungay = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CBSTinhtrang = new System.Windows.Forms.ComboBox();
            this.CBSNXB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MaPn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVPN)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtXoa);
            this.groupBox1.Controls.Add(this.BtCTPN);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtSua);
            this.groupBox1.Controls.Add(this.GVPN);
            this.groupBox1.Controls.Add(this.BtThem);
            this.groupBox1.Controls.Add(this.txtTongtien);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Controls.Add(this.txtNguoiGiao);
            this.groupBox1.Controls.Add(this.dateNgaynhap);
            this.groupBox1.Controls.Add(this.cbTinhTrang);
            this.groupBox1.Controls.Add(this.CbNXB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập sách";
            // 
            // BtXoa
            // 
            this.BtXoa.Location = new System.Drawing.Point(239, 342);
            this.BtXoa.Name = "BtXoa";
            this.BtXoa.Size = new System.Drawing.Size(75, 23);
            this.BtXoa.TabIndex = 7;
            this.BtXoa.Text = "Xóa phiếu";
            this.BtXoa.UseVisualStyleBackColor = true;
            this.BtXoa.Click += new System.EventHandler(this.BtXoa_Click);
            // 
            // BtCTPN
            // 
            this.BtCTPN.Location = new System.Drawing.Point(299, 17);
            this.BtCTPN.Name = "BtCTPN";
            this.BtCTPN.Size = new System.Drawing.Size(142, 23);
            this.BtCTPN.TabIndex = 6;
            this.BtCTPN.Text = "Nhập chi tiết phiếu nhập";
            this.BtCTPN.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã phiếu nhập";
            // 
            // BtSua
            // 
            this.BtSua.Location = new System.Drawing.Point(127, 342);
            this.BtSua.Name = "BtSua";
            this.BtSua.Size = new System.Drawing.Size(106, 23);
            this.BtSua.TabIndex = 4;
            this.BtSua.Text = "Sửa phiếu nhập";
            this.BtSua.UseVisualStyleBackColor = true;
            this.BtSua.Click += new System.EventHandler(this.BtSua_Click);
            // 
            // GVPN
            // 
            this.GVPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPn,
            this.NgayNhap,
            this.Tongtien,
            this.TinhTrang});
            this.GVPN.Location = new System.Drawing.Point(327, 66);
            this.GVPN.Name = "GVPN";
            this.GVPN.Size = new System.Drawing.Size(435, 299);
            this.GVPN.TabIndex = 2;
            this.GVPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVPN_CellClick);
            // 
            // BtThem
            // 
            this.BtThem.Location = new System.Drawing.Point(6, 342);
            this.BtThem.Name = "BtThem";
            this.BtThem.Size = new System.Drawing.Size(113, 23);
            this.BtThem.TabIndex = 4;
            this.BtThem.Text = "Thêm phiếu";
            this.BtThem.UseVisualStyleBackColor = true;
            this.BtThem.Click += new System.EventHandler(this.BtThem_Click);
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(110, 234);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(171, 20);
            this.txtTongtien.TabIndex = 3;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(110, 19);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.ReadOnly = true;
            this.txtMaPN.Size = new System.Drawing.Size(171, 20);
            this.txtMaPN.TabIndex = 3;
            // 
            // txtNguoiGiao
            // 
            this.txtNguoiGiao.Location = new System.Drawing.Point(110, 171);
            this.txtNguoiGiao.Name = "txtNguoiGiao";
            this.txtNguoiGiao.Size = new System.Drawing.Size(171, 20);
            this.txtNguoiGiao.TabIndex = 3;
            // 
            // dateNgaynhap
            // 
            this.dateNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaynhap.Location = new System.Drawing.Point(110, 110);
            this.dateNgaynhap.Name = "dateNgaynhap";
            this.dateNgaynhap.Size = new System.Drawing.Size(171, 20);
            this.dateNgaynhap.TabIndex = 2;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Đang xử lý",
            "Đã xong"});
            this.cbTinhTrang.Location = new System.Drawing.Point(110, 297);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(211, 21);
            this.cbTinhTrang.TabIndex = 1;
            // 
            // CbNXB
            // 
            this.CbNXB.FormattingEnabled = true;
            this.CbNXB.Location = new System.Drawing.Point(110, 66);
            this.CbNXB.Name = "CbNXB";
            this.CbNXB.Size = new System.Drawing.Size(211, 21);
            this.CbNXB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Người giao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn nhà xuất bản";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtTimKiem);
            this.groupBox4.Controls.Add(this.txtSTiennhapden);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtSTiennhaptu);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.dateDenngay);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.dateTungay);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.CBSTinhtrang);
            this.groupBox4.Controls.Add(this.CBSNXB);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(792, 157);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm phiếu nhập";
            // 
            // BtTimKiem
            // 
            this.BtTimKiem.Location = new System.Drawing.Point(707, 112);
            this.BtTimKiem.Name = "BtTimKiem";
            this.BtTimKiem.Size = new System.Drawing.Size(75, 23);
            this.BtTimKiem.TabIndex = 11;
            this.BtTimKiem.Text = "Tìm kiếm";
            this.BtTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtSTiennhapden
            // 
            this.txtSTiennhapden.Location = new System.Drawing.Point(655, 72);
            this.txtSTiennhapden.Name = "txtSTiennhapden";
            this.txtSTiennhapden.Size = new System.Drawing.Size(127, 20);
            this.txtSTiennhapden.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(622, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Đến";
            // 
            // txtSTiennhaptu
            // 
            this.txtSTiennhaptu.Location = new System.Drawing.Point(478, 74);
            this.txtSTiennhaptu.Name = "txtSTiennhaptu";
            this.txtSTiennhaptu.Size = new System.Drawing.Size(127, 20);
            this.txtSTiennhaptu.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(404, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tiền nhập từ";
            // 
            // dateDenngay
            // 
            this.dateDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDenngay.Location = new System.Drawing.Point(239, 74);
            this.dateDenngay.Name = "dateDenngay";
            this.dateDenngay.Size = new System.Drawing.Size(110, 20);
            this.dateDenngay.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(206, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Đến";
            // 
            // dateTungay
            // 
            this.dateTungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTungay.Location = new System.Drawing.Point(83, 76);
            this.dateTungay.Name = "dateTungay";
            this.dateTungay.Size = new System.Drawing.Size(110, 20);
            this.dateTungay.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ngày nhập từ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tình Trạng";
            // 
            // CBSTinhtrang
            // 
            this.CBSTinhtrang.FormattingEnabled = true;
            this.CBSTinhtrang.Location = new System.Drawing.Point(478, 26);
            this.CBSTinhtrang.Name = "CBSTinhtrang";
            this.CBSTinhtrang.Size = new System.Drawing.Size(213, 21);
            this.CBSTinhtrang.TabIndex = 1;
            // 
            // CBSNXB
            // 
            this.CBSNXB.FormattingEnabled = true;
            this.CBSNXB.Location = new System.Drawing.Point(84, 26);
            this.CBSNXB.Name = "CBSNXB";
            this.CBSNXB.Size = new System.Drawing.Size(265, 21);
            this.CBSNXB.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nhà xuất bản";
            // 
            // MaPn
            // 
            this.MaPn.DataPropertyName = "MaPN";
            this.MaPn.HeaderText = "Mã phiếu nhập";
            this.MaPn.Name = "MaPn";
            this.MaPn.Visible = false;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "Ngaynhap";
            this.NgayNhap.FillWeight = 150F;
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // Tongtien
            // 
            this.Tongtien.DataPropertyName = "Tongtien";
            this.Tongtien.HeaderText = "Tổng tiền";
            this.Tongtien.Name = "Tongtien";
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // FrmNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 591);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNhapSach";
            this.Text = "Nhập sách";
            this.Load += new System.EventHandler(this.FrmNhapSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVPN)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtSua;
        private System.Windows.Forms.Button BtThem;
        private System.Windows.Forms.TextBox txtNguoiGiao;
        private System.Windows.Forms.DateTimePicker dateNgaynhap;
        private System.Windows.Forms.ComboBox CbNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GVPN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtTimKiem;
        private System.Windows.Forms.TextBox txtSTiennhapden;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSTiennhaptu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateDenngay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTungay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CBSTinhtrang;
        private System.Windows.Forms.ComboBox CBSNXB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtCTPN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Button BtXoa;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}