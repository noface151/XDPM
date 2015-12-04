namespace XDPM
{
    partial class FrmThongKeDoanhThu
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
            this.dateTungay = new System.Windows.Forms.DateTimePicker();
            this.dateDenngay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdoanhthu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTienthu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienchi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GVthu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVchi = new System.Windows.Forms.DataGridView();
            this.Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tienthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.labelmota = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.labelLoaiBaoCao = new System.Windows.Forms.Label();
            this.cbLoaibaocao = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVchi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // dateTungay
            // 
            this.dateTungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTungay.Location = new System.Drawing.Point(65, 22);
            this.dateTungay.Name = "dateTungay";
            this.dateTungay.Size = new System.Drawing.Size(90, 20);
            this.dateTungay.TabIndex = 1;
            // 
            // dateDenngay
            // 
            this.dateDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDenngay.Location = new System.Drawing.Point(239, 22);
            this.dateDenngay.Name = "dateDenngay";
            this.dateDenngay.Size = new System.Drawing.Size(90, 20);
            this.dateDenngay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLoaibaocao);
            this.groupBox1.Controls.Add(this.labelLoaiBaoCao);
            this.groupBox1.Controls.Add(this.txtmota);
            this.groupBox1.Controls.Add(this.labelmota);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtdoanhthu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTienthu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTienchi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.GVthu);
            this.groupBox1.Controls.Add(this.GVchi);
            this.groupBox1.Controls.Add(this.dateDenngay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTungay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 585);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê doanh thu";
            // 
            // txtdoanhthu
            // 
            this.txtdoanhthu.Location = new System.Drawing.Point(425, 195);
            this.txtdoanhthu.Name = "txtdoanhthu";
            this.txtdoanhthu.ReadOnly = true;
            this.txtdoanhthu.Size = new System.Drawing.Size(128, 20);
            this.txtdoanhthu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doanh thu";
            // 
            // txtTienthu
            // 
            this.txtTienthu.Location = new System.Drawing.Point(425, 130);
            this.txtTienthu.Name = "txtTienthu";
            this.txtTienthu.ReadOnly = true;
            this.txtTienthu.Size = new System.Drawing.Size(128, 20);
            this.txtTienthu.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng tiền thu";
            // 
            // txtTienchi
            // 
            this.txtTienchi.Location = new System.Drawing.Point(425, 71);
            this.txtTienchi.Name = "txtTienchi";
            this.txtTienchi.ReadOnly = true;
            this.txtTienchi.Size = new System.Drawing.Size(128, 20);
            this.txtTienchi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tổng tiền chi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GVthu
            // 
            this.GVthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.GVthu.Location = new System.Drawing.Point(13, 321);
            this.GVthu.Name = "GVthu";
            this.GVthu.Size = new System.Drawing.Size(403, 246);
            this.GVthu.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tensach";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sách bán được";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tienthu";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tiền thu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // GVchi
            // 
            this.GVchi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVchi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sach,
            this.Tienthu});
            this.GVchi.Location = new System.Drawing.Point(13, 55);
            this.GVchi.Name = "GVchi";
            this.GVchi.Size = new System.Drawing.Size(403, 246);
            this.GVchi.TabIndex = 6;
            // 
            // Sach
            // 
            this.Sach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sach.DataPropertyName = "Tensach";
            this.Sach.HeaderText = "Sách nhập";
            this.Sach.Name = "Sach";
            // 
            // Tienthu
            // 
            this.Tienthu.DataPropertyName = "Tienchi";
            this.Tienthu.HeaderText = "Tiền chi";
            this.Tienthu.Name = "Tienthu";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Viết báo cáo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelmota
            // 
            this.labelmota.AutoSize = true;
            this.labelmota.Location = new System.Drawing.Point(431, 317);
            this.labelmota.Name = "labelmota";
            this.labelmota.Size = new System.Drawing.Size(50, 13);
            this.labelmota.TabIndex = 12;
            this.labelmota.Text = "Mô tả file";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(425, 338);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(263, 20);
            this.txtmota.TabIndex = 13;
            // 
            // labelLoaiBaoCao
            // 
            this.labelLoaiBaoCao.AutoSize = true;
            this.labelLoaiBaoCao.Location = new System.Drawing.Point(428, 261);
            this.labelLoaiBaoCao.Name = "labelLoaiBaoCao";
            this.labelLoaiBaoCao.Size = new System.Drawing.Size(69, 13);
            this.labelLoaiBaoCao.TabIndex = 14;
            this.labelLoaiBaoCao.Text = "Loại báo cáo";
            // 
            // cbLoaibaocao
            // 
            this.cbLoaibaocao.FormattingEnabled = true;
            this.cbLoaibaocao.Items.AddRange(new object[] {
            "Thống kê chi",
            "Thông kê thu"});
            this.cbLoaibaocao.Location = new System.Drawing.Point(431, 279);
            this.cbLoaibaocao.Name = "cbLoaibaocao";
            this.cbLoaibaocao.Size = new System.Drawing.Size(254, 21);
            this.cbLoaibaocao.TabIndex = 15;
            // 
            // FrmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 612);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmThongKeDoanhThu";
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.FrmThongKeDoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVchi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTungay;
        private System.Windows.Forms.DateTimePicker dateDenngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GVchi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GVthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tienthu;
        private System.Windows.Forms.TextBox txtdoanhthu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTienthu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTienchi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label labelmota;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbLoaibaocao;
        private System.Windows.Forms.Label labelLoaiBaoCao;
    }
}