namespace XDPM
{
    partial class FrmThongKeSachBanDuoc
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
            this.datetungay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDaily = new System.Windows.Forms.ComboBox();
            this.checkBoxthoigian = new System.Windows.Forms.CheckBox();
            this.checkBoxdaily = new System.Windows.Forms.CheckBox();
            this.datedenngay = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtThongKe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtThongKe);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.datedenngay);
            this.groupBox1.Controls.Add(this.datetungay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDaily);
            this.groupBox1.Controls.Add(this.checkBoxthoigian);
            this.groupBox1.Controls.Add(this.checkBoxdaily);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê sách bán được";
            // 
            // datetungay
            // 
            this.datetungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetungay.Location = new System.Drawing.Point(226, 52);
            this.datetungay.Name = "datetungay";
            this.datetungay.Size = new System.Drawing.Size(91, 20);
            this.datetungay.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ";
            // 
            // cbDaily
            // 
            this.cbDaily.FormattingEnabled = true;
            this.cbDaily.Location = new System.Drawing.Point(6, 52);
            this.cbDaily.Name = "cbDaily";
            this.cbDaily.Size = new System.Drawing.Size(195, 21);
            this.cbDaily.TabIndex = 1;
            // 
            // checkBoxthoigian
            // 
            this.checkBoxthoigian.AutoSize = true;
            this.checkBoxthoigian.Location = new System.Drawing.Point(229, 19);
            this.checkBoxthoigian.Name = "checkBoxthoigian";
            this.checkBoxthoigian.Size = new System.Drawing.Size(94, 17);
            this.checkBoxthoigian.TabIndex = 0;
            this.checkBoxthoigian.Text = "Theo thời gian";
            this.checkBoxthoigian.UseVisualStyleBackColor = true;
            // 
            // checkBoxdaily
            // 
            this.checkBoxdaily.AutoSize = true;
            this.checkBoxdaily.Location = new System.Drawing.Point(6, 29);
            this.checkBoxdaily.Name = "checkBoxdaily";
            this.checkBoxdaily.Size = new System.Drawing.Size(84, 17);
            this.checkBoxdaily.TabIndex = 0;
            this.checkBoxdaily.Text = "Theo Đại Lý";
            this.checkBoxdaily.UseVisualStyleBackColor = true;
            // 
            // datedenngay
            // 
            this.datedenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedenngay.Location = new System.Drawing.Point(343, 53);
            this.datedenngay.Name = "datedenngay";
            this.datedenngay.Size = new System.Drawing.Size(91, 20);
            this.datedenngay.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tensach,
            this.SoLuong});
            this.dataGridView1.Location = new System.Drawing.Point(10, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 270);
            this.dataGridView1.TabIndex = 5;
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
            this.SoLuong.HeaderText = "Số lượng bán";
            this.SoLuong.Name = "SoLuong";
            // 
            // BtThongKe
            // 
            this.BtThongKe.Location = new System.Drawing.Point(359, 79);
            this.BtThongKe.Name = "BtThongKe";
            this.BtThongKe.Size = new System.Drawing.Size(75, 23);
            this.BtThongKe.TabIndex = 6;
            this.BtThongKe.Text = "Thống kê";
            this.BtThongKe.UseVisualStyleBackColor = true;
            this.BtThongKe.Click += new System.EventHandler(this.BtThongKe_Click);
            // 
            // FrmThongKeSachBanDuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 427);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmThongKeSachBanDuoc";
            this.Text = "Thống kê sách bán được";
            this.Load += new System.EventHandler(this.FrmThongKeSachBanDuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datetungay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDaily;
        private System.Windows.Forms.CheckBox checkBoxthoigian;
        private System.Windows.Forms.CheckBox checkBoxdaily;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker datedenngay;
        private System.Windows.Forms.Button BtThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}