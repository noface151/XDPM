namespace XDPM
{
    partial class FrmChiNXB
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtRefresh = new System.Windows.Forms.Button();
            this.BTlammoi = new System.Windows.Forms.Button();
            this.BtXoa = new System.Windows.Forms.Button();
            this.BTSua = new System.Windows.Forms.Button();
            this.BtGhichitiet = new System.Windows.Forms.Button();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTThem = new System.Windows.Forms.Button();
            this.GVphieuchi = new System.Windows.Forms.DataGridView();
            this.MaPhieuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateNgaylap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNXB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaphieuchi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxthoigian = new System.Windows.Forms.CheckBox();
            this.checkBoxtinhtrang = new System.Windows.Forms.CheckBox();
            this.checkBoxNXB = new System.Windows.Forms.CheckBox();
            this.BtTimKiem = new System.Windows.Forms.Button();
            this.txtSTienchiden = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSTienchitu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateDenngay = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTungay = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.CBSTinhtrang = new System.Windows.Forms.ComboBox();
            this.CBSNXB = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVphieuchi)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtRefresh);
            this.groupBox2.Controls.Add(this.BTlammoi);
            this.groupBox2.Controls.Add(this.BtXoa);
            this.groupBox2.Controls.Add(this.BTSua);
            this.groupBox2.Controls.Add(this.BtGhichitiet);
            this.groupBox2.Controls.Add(this.cbTrangThai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BTThem);
            this.groupBox2.Controls.Add(this.GVphieuchi);
            this.groupBox2.Controls.Add(this.txtTongtien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateNgaylap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbNXB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtmaphieuchi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 392);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu chi nhà xuất bản";
            // 
            // BtRefresh
            // 
            this.BtRefresh.Location = new System.Drawing.Point(232, 363);
            this.BtRefresh.Name = "BtRefresh";
            this.BtRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtRefresh.TabIndex = 15;
            this.BtRefresh.Text = "Refresh";
            this.BtRefresh.UseVisualStyleBackColor = true;
            this.BtRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // BTlammoi
            // 
            this.BTlammoi.Location = new System.Drawing.Point(724, 36);
            this.BTlammoi.Name = "BTlammoi";
            this.BTlammoi.Size = new System.Drawing.Size(75, 23);
            this.BTlammoi.TabIndex = 14;
            this.BTlammoi.Text = "Làm mới DS";
            this.BTlammoi.UseVisualStyleBackColor = true;
            this.BTlammoi.Click += new System.EventHandler(this.BTlammoi_Click);
            // 
            // BtXoa
            // 
            this.BtXoa.Location = new System.Drawing.Point(211, 313);
            this.BtXoa.Name = "BtXoa";
            this.BtXoa.Size = new System.Drawing.Size(96, 23);
            this.BtXoa.TabIndex = 13;
            this.BtXoa.Text = "Xóa phiếu chi";
            this.BtXoa.UseVisualStyleBackColor = true;
            this.BtXoa.Click += new System.EventHandler(this.BtXoa_Click);
            // 
            // BTSua
            // 
            this.BTSua.Location = new System.Drawing.Point(110, 313);
            this.BTSua.Name = "BTSua";
            this.BTSua.Size = new System.Drawing.Size(96, 23);
            this.BTSua.TabIndex = 13;
            this.BTSua.Text = "Sửa phiếu chi";
            this.BTSua.UseVisualStyleBackColor = true;
            this.BTSua.Click += new System.EventHandler(this.BTSua_Click);
            // 
            // BtGhichitiet
            // 
            this.BtGhichitiet.Location = new System.Drawing.Point(295, 28);
            this.BtGhichitiet.Name = "BtGhichitiet";
            this.BtGhichitiet.Size = new System.Drawing.Size(114, 23);
            this.BtGhichitiet.TabIndex = 12;
            this.BtGhichitiet.Text = "Chi tiết phiếu chi";
            this.BtGhichitiet.UseVisualStyleBackColor = true;
            this.BtGhichitiet.Click += new System.EventHandler(this.BtGhichitiet_Click);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Đang chờ",
            "Đã nhận"});
            this.cbTrangThai.Location = new System.Drawing.Point(110, 260);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(134, 21);
            this.cbTrangThai.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trạng thái";
            // 
            // BTThem
            // 
            this.BTThem.Location = new System.Drawing.Point(6, 313);
            this.BTThem.Name = "BTThem";
            this.BTThem.Size = new System.Drawing.Size(96, 23);
            this.BTThem.TabIndex = 9;
            this.BTThem.Text = "Thêm phiếu chi";
            this.BTThem.UseVisualStyleBackColor = true;
            this.BTThem.Click += new System.EventHandler(this.BTThem_Click);
            // 
            // GVphieuchi
            // 
            this.GVphieuchi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVphieuchi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuChi,
            this.Ngay,
            this.Tongtien,
            this.TrangThai});
            this.GVphieuchi.Location = new System.Drawing.Point(313, 65);
            this.GVphieuchi.Name = "GVphieuchi";
            this.GVphieuchi.Size = new System.Drawing.Size(486, 308);
            this.GVphieuchi.TabIndex = 8;
            this.GVphieuchi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVphieuchi_CellClick);
            // 
            // MaPhieuChi
            // 
            this.MaPhieuChi.DataPropertyName = "Maphieuchi";
            this.MaPhieuChi.HeaderText = "Mã Phiếu Chi";
            this.MaPhieuChi.Name = "MaPhieuChi";
            this.MaPhieuChi.Visible = false;
            // 
            // Ngay
            // 
            this.Ngay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày lập";
            this.Ngay.Name = "Ngay";
            // 
            // Tongtien
            // 
            this.Tongtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tongtien.DataPropertyName = "Tongtien";
            this.Tongtien.HeaderText = "Tổng tiền";
            this.Tongtien.Name = "Tongtien";
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(110, 202);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(134, 20);
            this.txtTongtien.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng tiền";
            // 
            // dateNgaylap
            // 
            this.dateNgaylap.CustomFormat = "MM/yyyy";
            this.dateNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaylap.Location = new System.Drawing.Point(110, 141);
            this.dateNgaylap.Name = "dateNgaylap";
            this.dateNgaylap.Size = new System.Drawing.Size(134, 20);
            this.dateNgaylap.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày lập";
            // 
            // cbNXB
            // 
            this.cbNXB.FormattingEnabled = true;
            this.cbNXB.Location = new System.Drawing.Point(110, 30);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(179, 21);
            this.cbNXB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn nhà xuất bản";
            // 
            // txtmaphieuchi
            // 
            this.txtmaphieuchi.Location = new System.Drawing.Point(110, 82);
            this.txtmaphieuchi.Name = "txtmaphieuchi";
            this.txtmaphieuchi.ReadOnly = true;
            this.txtmaphieuchi.Size = new System.Drawing.Size(134, 20);
            this.txtmaphieuchi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu chi";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxthoigian);
            this.groupBox4.Controls.Add(this.checkBoxtinhtrang);
            this.groupBox4.Controls.Add(this.checkBoxNXB);
            this.groupBox4.Controls.Add(this.BtTimKiem);
            this.groupBox4.Controls.Add(this.txtSTienchiden);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtSTienchitu);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.dateDenngay);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.dateTungay);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.CBSTinhtrang);
            this.groupBox4.Controls.Add(this.CBSNXB);
            this.groupBox4.Location = new System.Drawing.Point(25, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(792, 157);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm phiếu chi";
            // 
            // checkBoxthoigian
            // 
            this.checkBoxthoigian.AutoSize = true;
            this.checkBoxthoigian.Location = new System.Drawing.Point(183, 137);
            this.checkBoxthoigian.Name = "checkBoxthoigian";
            this.checkBoxthoigian.Size = new System.Drawing.Size(135, 17);
            this.checkBoxthoigian.TabIndex = 13;
            this.checkBoxthoigian.Text = "Tìm kiếm theo thời gian";
            this.checkBoxthoigian.UseVisualStyleBackColor = true;
            // 
            // checkBoxtinhtrang
            // 
            this.checkBoxtinhtrang.AutoSize = true;
            this.checkBoxtinhtrang.Location = new System.Drawing.Point(407, 27);
            this.checkBoxtinhtrang.Name = "checkBoxtinhtrang";
            this.checkBoxtinhtrang.Size = new System.Drawing.Size(74, 17);
            this.checkBoxtinhtrang.TabIndex = 12;
            this.checkBoxtinhtrang.Text = "Trạng thái";
            this.checkBoxtinhtrang.UseVisualStyleBackColor = true;
            // 
            // checkBoxNXB
            // 
            this.checkBoxNXB.AutoSize = true;
            this.checkBoxNXB.Location = new System.Drawing.Point(5, 27);
            this.checkBoxNXB.Name = "checkBoxNXB";
            this.checkBoxNXB.Size = new System.Drawing.Size(90, 17);
            this.checkBoxNXB.TabIndex = 12;
            this.checkBoxNXB.Text = "Nhà xuất bản";
            this.checkBoxNXB.UseVisualStyleBackColor = true;
            // 
            // BtTimKiem
            // 
            this.BtTimKiem.Location = new System.Drawing.Point(711, 128);
            this.BtTimKiem.Name = "BtTimKiem";
            this.BtTimKiem.Size = new System.Drawing.Size(75, 23);
            this.BtTimKiem.TabIndex = 11;
            this.BtTimKiem.Text = "Tìm kiếm";
            this.BtTimKiem.UseVisualStyleBackColor = true;
            this.BtTimKiem.Click += new System.EventHandler(this.BtTimKiem_Click);
            // 
            // txtSTienchiden
            // 
            this.txtSTienchiden.Location = new System.Drawing.Point(564, 111);
            this.txtSTienchiden.Name = "txtSTienchiden";
            this.txtSTienchiden.Size = new System.Drawing.Size(127, 20);
            this.txtSTienchiden.TabIndex = 10;
            this.txtSTienchiden.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(561, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Đến";
            // 
            // txtSTienchitu
            // 
            this.txtSTienchitu.Location = new System.Drawing.Point(407, 111);
            this.txtSTienchitu.Name = "txtSTienchitu";
            this.txtSTienchitu.Size = new System.Drawing.Size(127, 20);
            this.txtSTienchitu.TabIndex = 8;
            this.txtSTienchitu.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(404, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tiền chi từ";
            // 
            // dateDenngay
            // 
            this.dateDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDenngay.Location = new System.Drawing.Point(183, 111);
            this.dateDenngay.Name = "dateDenngay";
            this.dateDenngay.Size = new System.Drawing.Size(131, 20);
            this.dateDenngay.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Đến";
            // 
            // dateTungay
            // 
            this.dateTungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTungay.Location = new System.Drawing.Point(9, 111);
            this.dateTungay.Name = "dateTungay";
            this.dateTungay.Size = new System.Drawing.Size(129, 20);
            this.dateTungay.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ngày lập từ";
            // 
            // CBSTinhtrang
            // 
            this.CBSTinhtrang.FormattingEnabled = true;
            this.CBSTinhtrang.Items.AddRange(new object[] {
            "Đang chờ",
            "Đã nhận"});
            this.CBSTinhtrang.Location = new System.Drawing.Point(407, 50);
            this.CBSTinhtrang.Name = "CBSTinhtrang";
            this.CBSTinhtrang.Size = new System.Drawing.Size(213, 21);
            this.CBSTinhtrang.TabIndex = 1;
            // 
            // CBSNXB
            // 
            this.CBSNXB.FormattingEnabled = true;
            this.CBSNXB.Location = new System.Drawing.Point(5, 50);
            this.CBSNXB.Name = "CBSNXB";
            this.CBSNXB.Size = new System.Drawing.Size(248, 21);
            this.CBSNXB.TabIndex = 1;
            this.CBSNXB.Text = "Chọn nhà xuất bản";
            // 
            // FrmChiNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 612);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmChiNXB";
            this.Text = "Phiếu chi nhà xuất bản";
            this.Load += new System.EventHandler(this.FrmChiNXB_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVphieuchi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateNgaylap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaphieuchi;
        private System.Windows.Forms.DataGridView GVphieuchi;
        private System.Windows.Forms.Button BTThem;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtGhichitiet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxthoigian;
        private System.Windows.Forms.CheckBox checkBoxtinhtrang;
        private System.Windows.Forms.CheckBox checkBoxNXB;
        private System.Windows.Forms.Button BtTimKiem;
        private System.Windows.Forms.TextBox txtSTienchiden;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSTienchitu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateDenngay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTungay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CBSTinhtrang;
        private System.Windows.Forms.ComboBox CBSNXB;
        private System.Windows.Forms.Button BtXoa;
        private System.Windows.Forms.Button BTSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Button BTlammoi;
        private System.Windows.Forms.Button BtRefresh;

    }
}