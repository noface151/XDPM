namespace XDPM
{
    partial class FrmCTPhieuchiNXB
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
            this.GVsachbanduoc = new System.Windows.Forms.DataGridView();
            this.txtmaPhieuchi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GVCTPhieuchi = new System.Windows.Forms.DataGridView();
            this.Masachx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensachx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluongx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tienchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVsachbanduoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVCTPhieuchi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GVsachbanduoc);
            this.groupBox1.Location = new System.Drawing.Point(16, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 402);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số sách bán được";
            // 
            // GVsachbanduoc
            // 
            this.GVsachbanduoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVsachbanduoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masach,
            this.Tensach,
            this.Soluong});
            this.GVsachbanduoc.Location = new System.Drawing.Point(6, 31);
            this.GVsachbanduoc.Name = "GVsachbanduoc";
            this.GVsachbanduoc.Size = new System.Drawing.Size(389, 356);
            this.GVsachbanduoc.TabIndex = 4;
            this.GVsachbanduoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVsachbanduoc_CellClick);
            // 
            // txtmaPhieuchi
            // 
            this.txtmaPhieuchi.Location = new System.Drawing.Point(87, 10);
            this.txtmaPhieuchi.Name = "txtmaPhieuchi";
            this.txtmaPhieuchi.ReadOnly = true;
            this.txtmaPhieuchi.Size = new System.Drawing.Size(108, 20);
            this.txtmaPhieuchi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã phiếu chi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.txtmasach);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.GVCTPhieuchi);
            this.groupBox2.Location = new System.Drawing.Point(423, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 402);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu chi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lưu chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(64, 354);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.ReadOnly = true;
            this.txtsoluong.Size = new System.Drawing.Size(200, 20);
            this.txtsoluong.TabIndex = 2;
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(64, 321);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.ReadOnly = true;
            this.txtmasach.Size = new System.Drawing.Size(200, 20);
            this.txtmasach.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sách";
            // 
            // GVCTPhieuchi
            // 
            this.GVCTPhieuchi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCTPhieuchi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masachx,
            this.Tensachx,
            this.Soluongx,
            this.Tienchi});
            this.GVCTPhieuchi.Location = new System.Drawing.Point(6, 19);
            this.GVCTPhieuchi.Name = "GVCTPhieuchi";
            this.GVCTPhieuchi.Size = new System.Drawing.Size(454, 271);
            this.GVCTPhieuchi.TabIndex = 0;
            // 
            // Masachx
            // 
            this.Masachx.DataPropertyName = "Masach";
            this.Masachx.HeaderText = "Mã sách";
            this.Masachx.Name = "Masachx";
            this.Masachx.Visible = false;
            // 
            // Tensachx
            // 
            this.Tensachx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tensachx.DataPropertyName = "Tensach";
            this.Tensachx.HeaderText = "Tên sách";
            this.Tensachx.Name = "Tensachx";
            // 
            // Soluongx
            // 
            this.Soluongx.DataPropertyName = "soluong";
            this.Soluongx.HeaderText = "Số lượng";
            this.Soluongx.Name = "Soluongx";
            // 
            // Tienchi
            // 
            this.Tienchi.DataPropertyName = "Tienchi";
            this.Tienchi.HeaderText = "Tiền chi";
            this.Tienchi.Name = "Tienchi";
            // 
            // Masach
            // 
            this.Masach.DataPropertyName = "Masach";
            this.Masach.FillWeight = 50F;
            this.Masach.HeaderText = "Mã sách";
            this.Masach.Name = "Masach";
            this.Masach.Width = 50;
            // 
            // Tensach
            // 
            this.Tensach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tensach.DataPropertyName = "Tensach";
            this.Tensach.HeaderText = "Tên sách";
            this.Tensach.Name = "Tensach";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            // 
            // FrmCTPhieuchiNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaPhieuchi);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCTPhieuchiNXB";
            this.Text = "FrmCTPhieuchiNXB";
            this.Load += new System.EventHandler(this.FrmCTPhieuchiNXB_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVsachbanduoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVCTPhieuchi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GVsachbanduoc;
        private System.Windows.Forms.TextBox txtmaPhieuchi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GVCTPhieuchi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masachx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensachx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluongx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tienchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
    }
}