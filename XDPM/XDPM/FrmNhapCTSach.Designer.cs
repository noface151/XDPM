namespace XDPM
{
    partial class FrmNhapCTSach
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GVSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSTensach = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTSua = new System.Windows.Forms.Button();
            this.GVCTPN = new System.Windows.Forms.DataGridView();
            this.Masachx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTXoa = new System.Windows.Forms.Button();
            this.BTLuu = new System.Windows.Forms.Button();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.BtThongTinSach = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVCTPN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.GVSach);
            this.groupBox3.Controls.Add(this.txtSTensach);
            this.groupBox3.Location = new System.Drawing.Point(12, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 336);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nhập tên sách";
            // 
            // GVSach
            // 
            this.GVSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach});
            this.GVSach.Location = new System.Drawing.Point(9, 72);
            this.GVSach.Name = "GVSach";
            this.GVSach.Size = new System.Drawing.Size(383, 252);
            this.GVSach.TabIndex = 0;
            this.GVSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVSach_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "Masach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSach.DataPropertyName = "Tensach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            // 
            // txtSTensach
            // 
            this.txtSTensach.Location = new System.Drawing.Point(89, 30);
            this.txtSTensach.Name = "txtSTensach";
            this.txtSTensach.Size = new System.Drawing.Size(215, 20);
            this.txtSTensach.TabIndex = 2;
            this.txtSTensach.TextChanged += new System.EventHandler(this.txtSTensach_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtThongTinSach);
            this.groupBox2.Controls.Add(this.BTSua);
            this.groupBox2.Controls.Add(this.GVCTPN);
            this.groupBox2.Controls.Add(this.BTXoa);
            this.groupBox2.Controls.Add(this.BTLuu);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMasach);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(426, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 336);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhập";
            // 
            // BTSua
            // 
            this.BTSua.Location = new System.Drawing.Point(176, 307);
            this.BTSua.Name = "BTSua";
            this.BTSua.Size = new System.Drawing.Size(75, 23);
            this.BTSua.TabIndex = 10;
            this.BTSua.Text = "Sửa chi tiết";
            this.BTSua.UseVisualStyleBackColor = true;
            this.BTSua.Click += new System.EventHandler(this.BTSua_Click);
            // 
            // GVCTPN
            // 
            this.GVCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masachx,
            this.Tensach1,
            this.SoLuong,
            this.Gia});
            this.GVCTPN.Location = new System.Drawing.Point(6, 19);
            this.GVCTPN.Name = "GVCTPN";
            this.GVCTPN.Size = new System.Drawing.Size(452, 225);
            this.GVCTPN.TabIndex = 9;
            this.GVCTPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVCTPN_CellClick);
            // 
            // Masachx
            // 
            this.Masachx.DataPropertyName = "Masach";
            this.Masachx.HeaderText = "Mã sách";
            this.Masachx.Name = "Masachx";
            this.Masachx.Visible = false;
            // 
            // Tensach1
            // 
            this.Tensach1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tensach1.DataPropertyName = "Tensach";
            this.Tensach1.HeaderText = "Tên sách";
            this.Tensach1.Name = "Tensach1";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "Soluong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // BTXoa
            // 
            this.BTXoa.Location = new System.Drawing.Point(257, 307);
            this.BTXoa.Name = "BTXoa";
            this.BTXoa.Size = new System.Drawing.Size(75, 23);
            this.BTXoa.TabIndex = 8;
            this.BTXoa.Text = "Xóa chi tiết";
            this.BTXoa.UseVisualStyleBackColor = true;
            this.BTXoa.Click += new System.EventHandler(this.BTXoa_Click);
            // 
            // BTLuu
            // 
            this.BTLuu.Location = new System.Drawing.Point(95, 307);
            this.BTLuu.Name = "BTLuu";
            this.BTLuu.Size = new System.Drawing.Size(75, 23);
            this.BTLuu.TabIndex = 7;
            this.BTLuu.Text = "Lưu chi tiết";
            this.BTLuu.UseVisualStyleBackColor = true;
            this.BTLuu.Click += new System.EventHandler(this.BTLuu_Click);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(144, 277);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(122, 20);
            this.txtSoluong.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số lượng";
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(144, 250);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.ReadOnly = true;
            this.txtMasach.Size = new System.Drawing.Size(122, 20);
            this.txtMasach.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(102, 17);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.ReadOnly = true;
            this.txtMaPN.Size = new System.Drawing.Size(150, 20);
            this.txtMaPN.TabIndex = 7;
            // 
            // BtThongTinSach
            // 
            this.BtThongTinSach.Location = new System.Drawing.Point(272, 248);
            this.BtThongTinSach.Name = "BtThongTinSach";
            this.BtThongTinSach.Size = new System.Drawing.Size(118, 23);
            this.BtThongTinSach.TabIndex = 11;
            this.BtThongTinSach.Text = "Thông tin sách";
            this.BtThongTinSach.UseVisualStyleBackColor = true;
            this.BtThongTinSach.Click += new System.EventHandler(this.BtThongTinSach_Click);
            // 
            // FrmNhapCTSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 404);
            this.Controls.Add(this.txtMaPN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmNhapCTSach";
            this.Text = "Nhập chi tiết phiếu nhập sách";
            this.Load += new System.EventHandler(this.FrmNhapCTSach_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVCTPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView GVSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.TextBox txtSTensach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GVCTPN;
        private System.Windows.Forms.Button BTXoa;
        private System.Windows.Forms.Button BTLuu;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Button BTSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masachx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.Button BtThongTinSach;
    }
}