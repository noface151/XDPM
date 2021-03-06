﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace XDPM
{
    public partial class FrmCTPhieuchiNXB : Form
    {
        private string _maphieuchi;
        private string _maNXB;
        CTphieuchiNXB _ctphieuchi = new CTphieuchiNXB();
        public FrmCTPhieuchiNXB()
        {
            InitializeComponent();
        }
        public string Maphieuchi
        {
            get { return _maphieuchi; }
            set { _maphieuchi = value; }
        }
        public string MaNXB
        {
            get { return _maNXB; }
            set { _maNXB = value; }
        }
        public void load()
        {
            GVCTPhieuchi.DataSource = DALCTPhieuChi.layDSCT(txtmaPhieuchi.Text);
        }
        private void FrmCTPhieuchiNXB_Load(object sender, EventArgs e)
        {
            GVCTPhieuchi.AutoGenerateColumns = false;
            GVsachbanduoc.AutoGenerateColumns = false;
            txtmaPhieuchi.Text = _maphieuchi;
           GVsachbanduoc.DataSource=DALCTPhieuChi.DSsachbanduoctheoNXB(_maNXB);
           load();
           if (DALPhieuChiNXB.layphieuchitheoma(txtmaPhieuchi.Text).TrangThai == "Đã nhận")
           {
               button1.Enabled = false;
           }
        }

        private void GVsachbanduoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = GVsachbanduoc.Rows[e.RowIndex];
                txtmasach.Text = row.Cells[0].Value.ToString();
                txtsoluong.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtmasach.Text==""||txtsoluong.Text=="")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            else
            {
                _ctphieuchi.Masach = txtmasach.Text;
                _ctphieuchi.Maphieuchi = txtmaPhieuchi.Text;
                _ctphieuchi.Soluong = Convert.ToInt16(txtsoluong.Text);
                _ctphieuchi.Tienchi = _ctphieuchi.Soluong * DALSach.LaySachTheoMa(_ctphieuchi.Masach).GiaNhap;
                bool result = DALCTPhieuChi.ThemCTphieuchi(_ctphieuchi);
                if (result == true)
                {
                    MessageBox.Show("Thêm thành công");
                    DALCTPhieuChi.CapNhatKhiThemCT(_ctphieuchi);
                    load();
                    txtmasach.Text = "";
                    txtsoluong.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    txtmasach.Text = "";
                    txtsoluong.Text = "";
                }
            }
        }
    }
}
