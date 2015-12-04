namespace XDPM
{
    partial class FrmThongKeTonKho
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
            this.BtXemtonkho = new System.Windows.Forms.Button();
            this.GVthongke = new System.Windows.Forms.DataGridView();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.labelmota = new System.Windows.Forms.Label();
            this.BtVietBaoCao = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVthongke)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.BtVietBaoCao);
            this.groupBox1.Controls.Add(this.labelmota);
            this.groupBox1.Controls.Add(this.BtXemtonkho);
            this.groupBox1.Controls.Add(this.GVthongke);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 430);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo thời gian";
            // 
            // BtXemtonkho
            // 
            this.BtXemtonkho.Location = new System.Drawing.Point(206, 26);
            this.BtXemtonkho.Name = "BtXemtonkho";
            this.BtXemtonkho.Size = new System.Drawing.Size(75, 23);
            this.BtXemtonkho.TabIndex = 5;
            this.BtXemtonkho.Text = "Xem tồn kho";
            this.BtXemtonkho.UseVisualStyleBackColor = true;
            this.BtXemtonkho.Click += new System.EventHandler(this.BtXemtonkho_Click);
            // 
            // GVthongke
            // 
            this.GVthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVthongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tensach,
            this.SoLuong});
            this.GVthongke.Location = new System.Drawing.Point(9, 68);
            this.GVthongke.Name = "GVthongke";
            this.GVthongke.Size = new System.Drawing.Size(505, 356);
            this.GVthongke.TabIndex = 4;
            // 
            // Tensach
            // 
            this.Tensach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tensach.DataPropertyName = "Tensach";
            this.Tensach.HeaderText = "Tên sách";
            this.Tensach.Name = "Tensach";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "soluong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(88, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xem đến ngày";
            // 
            // labelmota
            // 
            this.labelmota.AutoSize = true;
            this.labelmota.Location = new System.Drawing.Point(374, 31);
            this.labelmota.Name = "labelmota";
            this.labelmota.Size = new System.Drawing.Size(50, 13);
            this.labelmota.TabIndex = 6;
            this.labelmota.Text = "Mô tả file";
            // 
            // BtVietBaoCao
            // 
            this.BtVietBaoCao.Location = new System.Drawing.Point(287, 26);
            this.BtVietBaoCao.Name = "BtVietBaoCao";
            this.BtVietBaoCao.Size = new System.Drawing.Size(75, 23);
            this.BtVietBaoCao.TabIndex = 7;
            this.BtVietBaoCao.Text = "Viết báo cáo";
            this.BtVietBaoCao.UseVisualStyleBackColor = true;
            this.BtVietBaoCao.Click += new System.EventHandler(this.BtVietBaoCao_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(430, 28);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(261, 20);
            this.txtMoTa.TabIndex = 8;
            // 
            // FrmThongKeTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 455);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmThongKeTonKho";
            this.Text = "Thống kê tồn kho";
            this.Load += new System.EventHandler(this.FrmThongKeTonKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVthongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtXemtonkho;
        private System.Windows.Forms.DataGridView GVthongke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button BtVietBaoCao;
        private System.Windows.Forms.Label labelmota;
    }
}