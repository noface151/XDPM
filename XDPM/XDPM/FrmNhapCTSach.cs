using System;
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
        string _masach;
        long giacu = 0;
        int soluongcu = 0;
        SearchSach _search = new SearchSach();
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
            _search.MaNXB = _maNXB;
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
        }

        private void BtTim_Click(object sender, EventArgs e)
        {
            PropertiesSearch();
            _search.Tensach = txtSTensach.Text;
            BUSSach bussach = new BUSSach(_search);
            GVSach.DataSource = bussach.timkiemSach();
        }

        private void GVSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GVSach.Rows[e.RowIndex];
                _masach = row.Cells[0].Value.ToString();
                txtTensach.Text = row.Cells[1].Value.ToString();
            }

        }

        private void GVCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = GVCTPN.Rows[e.RowIndex];
                _masach = row.Cells[0].Value.ToString();
                txtTensach.Text = row.Cells[1].Value.ToString();
                txtSoluong.Text = row.Cells[2].Value.ToString();
                giacu = Convert.ToInt64(row.Cells[3].Value);
                soluongcu =Convert.ToInt16(txtSoluong.Text);
            }
        }

        private void BTLuu_Click(object sender, EventArgs e)
        {
            if (txtTensach.Text == "" || txtSoluong.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            else
            {
                _ctPN.Masach = _masach;
                _ctPN.MaPN = txtMaPN.Text;
                _ctPN.Soluong = Convert.ToInt16(txtSoluong.Text);
                _ctPN.Gia = _ctPN.Soluong * DALSach.LaySachTheoMa(_ctPN.Masach).GiaNhap;
                bool result = DALCTPN.ThemCTPNSach(_ctPN);
                if (result == true)
                {
                    MessageBox.Show("Thêm thành công");
                    DALCTPN.CapNhatKhiThemchitiet(_ctPN);
                    load();
                    _masach = "";
                    txtTensach.Text = "";
                    txtSoluong.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    _masach = "";
                    txtTensach.Text = "";
                    txtSoluong.Text = "";
                }
            }
        }

        private void BTSua_Click(object sender, EventArgs e)
        {
            if(_masach=="")
            {
                MessageBox.Show("Chưa chọn chi tiết cần sửa");
            }
            else
            {
                _ctPN.MaPN = txtMaPN.Text;
                _ctPN.Masach = _masach;
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
                    _masach = "";
                    txtTensach.Text = "";
                    txtSoluong.Text = "";
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    _masach = "";
                    txtTensach.Text = "";
                    txtSoluong.Text = "";
                }
            }
        }

        private void BTXoa_Click(object sender, EventArgs e)
        {
            if(_masach=="")
            {
                MessageBox.Show("Chưa chọn chi tiết cần xóa");
            }
            else
            {
                _ctPN.MaPN = txtMaPN.Text;
                _ctPN.Masach = _masach;
                bool result = DALCTPN.CapNhatKhiXoachitiet(_ctPN);
                if(result==true)
                {
                    MessageBox.Show("Xóa thành công");
                    GVCTPN.DataSource = DALCTPN.LayDSCT(txtMaPN.Text);
                    _masach = "";
                    txtTensach.Text = "";
                    txtSoluong.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    _masach = "";
                    txtTensach.Text = "";
                    txtSoluong.Text = "";
                }
            }
        }
    }
}
