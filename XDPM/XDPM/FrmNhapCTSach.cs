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
using BUS;

namespace XDPM
{
    public partial class FrmNhapCTSach : Form
    {
        private string _message;
        private string _maNXB;
        long giacu = 0;
        int soluongcu = 0;
        DTOSach _search = new DTOSach();
        CTPNsach _ctPN = new CTPNsach();
        PNsach _pnsach = new PNsach();
        public FrmNhapCTSach()
        {
            InitializeComponent();
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        public string MaNXB
        {
            get { return _maNXB; }
            set { _maNXB = value; }
        }
        public void PropertiesSearch()
        {
            _search.MaNXB = MaNXB;
            _search.MaTheLoai = "";
            _search.giatu = 0;
            _search.giaden = 0;
            _search.gianhapden = 0;
            _search.gianhaptu = 0;
        }
        public void load()
        {
            GVCTPN.DataSource = DALCTPN.LayDSCT(txtMaPN.Text);
        }
        private void FrmNhapCTSach_Load(object sender, EventArgs e)
        {
            GVSach.AutoGenerateColumns = false;
            GVCTPN.AutoGenerateColumns = false;
            txtMaPN.Text = _message;
            PropertiesSearch();
            _search.Tensach = "";
            BUSSach bussach = new BUSSach(_search);
            GVSach.DataSource = bussach.timkiemSach();
            load();
            if (DALPhieuNhap.LayPNtheoma(txtMaPN.Text).TinhTrang == "Đã xong")
            {
                BTLuu.Enabled = false;
                BTSua.Enabled = false;
                BTXoa.Enabled = false;
            }
        }

        private void GVSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GVSach.Rows[e.RowIndex];
                txtMasach.Text = row.Cells[0].Value.ToString();
            }

        }

        private void GVCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = GVCTPN.Rows[e.RowIndex];
                txtMasach.Text = row.Cells[0].Value.ToString();
                txtSoluong.Text = row.Cells[2].Value.ToString();
                giacu = Convert.ToInt64(row.Cells[3].Value);
                soluongcu =Convert.ToInt16(txtSoluong.Text);
            }
        }

        private void BTLuu_Click(object sender, EventArgs e)
        {
            if (txtMasach.Text == "" || txtSoluong.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            else
            {
                _ctPN.Masach = txtMasach.Text;
                _ctPN.MaPN = txtMaPN.Text;
                _ctPN.Soluong = Convert.ToInt16(txtSoluong.Text);
                _ctPN.Gia = _ctPN.Soluong * DALSach.LaySachTheoMa(_ctPN.Masach).GiaNhap;
                bool result = DALCTPN.ThemCTPNSach(_ctPN);
                if (result == true)
                {
                    MessageBox.Show("Thêm thành công");
                    DALCTPN.CapNhatKhiThemchitiet(_ctPN);
                    load();
                    txtMasach.Text = "";
                    txtSoluong.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    txtMasach.Text = "";
                    txtSoluong.Text = "";
                }
            }
        }

        private void BTSua_Click(object sender, EventArgs e)
        {
            if(txtMasach.Text=="")
            {
                MessageBox.Show("Chưa chọn chi tiết cần sửa");
            }
            else
            {
                _ctPN.MaPN = txtMaPN.Text;
                _ctPN.Masach = txtMasach.Text;
                _ctPN.Soluong =Convert.ToInt16(txtSoluong.Text);
                _ctPN.Gia = _ctPN.Soluong * DALSach.LaySachTheoMa(_ctPN.Masach).GiaNhap;
                long giahientai = DALPhieuNhap.LayPNtheoma(_ctPN.MaPN).Tongtien;
                long giatam = giahientai - giacu;
                int Soluonghientai = DALSach.LaySachTheoMa(_ctPN.Masach).SoLuong;
                int soluongtam = Soluonghientai-soluongcu;
                bool result = DALCTPN.CapNhatKhiSuachitiet(_ctPN, giatam, soluongtam);
                if(result==true)
                {
                    MessageBox.Show("Sửa thành công");
                    GVCTPN.DataSource = DALCTPN.LayDSCT(txtMaPN.Text);
                    giacu = DALCTPN.layCTPN(_ctPN).Gia;
                    soluongcu = DALCTPN.layCTPN(_ctPN).Soluong;
                    txtMasach.Text = "";
                    txtSoluong.Text = "";
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    txtMasach.Text = "";
                    txtSoluong.Text = "";
                }
            }
        }

        private void BTXoa_Click(object sender, EventArgs e)
        {
            if(txtMasach.Text=="")
            {
                MessageBox.Show("Chưa chọn chi tiết cần xóa");
            }
            else
            {
                _ctPN.MaPN = txtMaPN.Text;
                _ctPN.Masach = txtMasach.Text;
                bool result = DALCTPN.CapNhatKhiXoachitiet(_ctPN);
                if(result==true)
                {
                    MessageBox.Show("Xóa thành công");
                    GVCTPN.DataSource = DALCTPN.LayDSCT(txtMaPN.Text);
                    txtMasach.Text = "";
                    txtSoluong.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    txtMasach.Text = "";
                    txtSoluong.Text = "";
                }
            }
        }

        private void txtSTensach_TextChanged(object sender, EventArgs e)
        {
            PropertiesSearch();
            _search.Tensach = txtSTensach.Text;
            BUSSach bussach = new BUSSach(_search);
            GVSach.DataSource = bussach.timkiemSach();
            foreach(var row in bussach.timkiemSach())
            {
                txtMasach.Text = row.Masach.ToString();
            }
        }

        private void BtThongTinSach_Click(object sender, EventArgs e)
        {
            if(txtMasach.Text=="")
            {
                MessageBox.Show("Không tồn tại sách cần xem");
            }
            else
            {
                FrmTTSach ttsach = new FrmTTSach();
                ttsach.Masach = txtMasach.Text;
                ttsach.Show();
            }
        }
       
    }
}
