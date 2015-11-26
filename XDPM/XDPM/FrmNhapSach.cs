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
    public partial class FrmNhapSach : Form
    {
        public FrmNhapSach()
        {
            InitializeComponent();
        }
        PNsach _pnsach = new PNsach();
        SearchPhieuNhapPhieuChi _search = new SearchPhieuNhapPhieuChi();
        Nhaxuatban _nxb = new Nhaxuatban();
        public void load()
        {
            GVPN.DataSource = DALPhieuNhap.LoadDSPN();
        }
        public void GanProperties()
        {
            _pnsach.MaPN = txtMaPN.Text;
            _pnsach.MaNXB = CbNXB.SelectedValue.ToString();
            _pnsach.Ngaynhap = Convert.ToDateTime(dateNgaynhap.Text);
            _pnsach.Nguoigiao = txtNguoiGiao.Text;
            _pnsach.TinhTrang = cbTinhTrang.Text;
        }
        public void reset()
        {
            txtMaPN.Text = "";
            txtNguoiGiao.Text = "";
            txtTongtien.Text = "";
        }
        private void FrmNhapSach_Load(object sender, EventArgs e)
        {
            GVPN.AutoGenerateColumns = false;
            load();
            CbNXB.DataSource = DALNXB.loadNXB();
            CbNXB.DisplayMember = "TenNXB";
            CbNXB.ValueMember = "MaNXB";
            CBSNXB.DataSource = DALNXB.loadNXB();
            CBSNXB.DisplayMember = "TenNXB";
            CBSNXB.ValueMember = "MaNXB";
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            if (txtNguoiGiao.Text == "")
            {
                MessageBox.Show("Chưa nhập người giao sách");
            }
            else if (cbTinhTrang.Text.Trim() != "Đang xử lý")
            {
                MessageBox.Show("Thêm phiếu mới thì tình trạng phải là đang xử lý");
            }
            else
            {
                BUSNhapsach _busnhapsach = new BUSNhapsach();
                if (txtMaPN.Text != "")
                { MessageBox.Show("Không thể thêm"); }
                else
                {
                    txtMaPN.Text = _busnhapsach.MaPNtudong();
                    GanProperties();
                    bool result = DALPhieuNhap.ThemPhieuNhap(_pnsach);
                    if (result == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        load();

                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                        
                    }
                }
            }
        }

        private void BtSua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            _pnsach.MaPN = txtMaPN.Text;
            GanProperties();
            if (_pnsach.MaPN == "")
            { MessageBox.Show("Chưa chọn phiếu cần sửa"); }
            else
            {
                BUSNhapsach _busnhapsach = new BUSNhapsach(_pnsach);
                bool result1 = _busnhapsach.KiemTraSuaPhieuNhap();
                bool result = _busnhapsach.KiemTraTinhTrang();
                if (DALPhieuNhap.LayPNtheoma(_pnsach.MaPN).TinhTrang.Trim() != "Đã xong")
                {
                    if (result == true)
                    {
                        dialog = MessageBox.Show("Tình trạng là ĐÃ XONG thì phiếu nhập này sẽ không thể SỬA hoặc XÓA. Có muốn thay đổi?", "Sửa tình trạng", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            if (result1 == true)
                            {
                                bool result2 = DALPhieuNhap.SuaPhieuNhap(_pnsach);
                                if (result2 == true)
                                {
                                    _nxb.MaNXB = _pnsach.MaNXB;
                                    _nxb.No = DALPhieuNhap.LayPNtheoma(_pnsach.MaPN).Tongtien;
                                    DALNXB.UpdateNoNXBKhiNhap(_nxb);
                                    MessageBox.Show("Sửa thành công");
                                    load();
                                   
                                }
                                else
                                {
                                    MessageBox.Show("Sửa thất bại");
                                  
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không thể sửa nhà cung cấp này vì ràng buộc dữ liệu");
                            }
                        }
                    }
                    else
                    {
                        if (result1 == true)
                        {
                            bool result2 = DALPhieuNhap.SuaPhieuNhap(_pnsach);
                            if (result2 == true)
                            {
                                MessageBox.Show("Sửa thành công");
                                load();                               
                            }
                            else
                            {
                                MessageBox.Show("Sửa thất bại");                              
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa nhà cung cấp này vì ràng buộc dữ liệu");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Phiếu này đã xử lý xong, không thể sửa hoặc xóa");
                }
            }
        }
        private void GVPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GVPN.Rows[e.RowIndex];
                txtMaPN.Text = row.Cells[0].Value.ToString();
            }
            var PnSach = DALPhieuNhap.LayPNtheoma(txtMaPN.Text.Trim());
            dateNgaynhap.Text = PnSach.Ngaynhap.ToString();
            txtNguoiGiao.Text = PnSach.Nguoigiao;
            txtTongtien.Text = PnSach.Tongtien.ToString();
            cbTinhTrang.Text = PnSach.TinhTrang;
            CbNXB.Text = DALNXB.LayNXBtheoma(PnSach.MaNXB).TenNXB;
        }

        private void BtXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            _pnsach.MaPN = txtMaPN.Text;
            if (_pnsach.MaPN == "")
            { MessageBox.Show("Chưa chọn phiếu cần xóa"); }
            else
            {
                if (DALPhieuNhap.LayPNtheoma(_pnsach.MaPN).TinhTrang != "Đã xong")
                {
                    dialog = MessageBox.Show("Xóa Phiếu nhập sẽ xóa toàn bị chi tiết của phiếu. Có muốn xóa?", "Xóa phiếu nhập", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        bool result = DALPhieuNhap.XoaPhieuNhap(_pnsach);
                        if (result == true)
                        {
                            MessageBox.Show("Xóa thành công");
                            load();                           
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Phiếu này có tình trạng là Đã xong, không thể sửa hoặc xóa");
                }
            }
        }
        private void BtTimKiem_Click(object sender, EventArgs e)
        {
            _search.MaNXB = "";
            _search.TinhTrang = "";
            if (checkBoxNXB.Checked == true)
            {
                _search.MaNXB = CBSNXB.SelectedValue.ToString().Trim();
            }
            if (checkBoxtinhtrang.Checked == true)
            {
                _search.TinhTrang = CBSTinhtrang.Text.Trim();
            }
            if (checkBoxthoigian.Checked == true)
            {
                _search.Ngaytu = Convert.ToDateTime(dateTungay.Text);
                _search.Ngayden = Convert.ToDateTime(dateDenngay.Text);
                if (_search.Ngaytu > _search.Ngayden)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                    _search.Ngaytu = null;
                    _search.Ngayden = null;
                }
            }
            _search.MaPN = txtSmaPN.Text;
            _search.tiennhaptu = Convert.ToInt64(txtSTiennhaptu.Text);
            _search.tiennhapden = Convert.ToInt64(txtSTiennhapden.Text);
            GVPN.DataSource = DALPhieuNhap.LayPNtheoTimkiem(_search);
            txtSTiennhapden.Text = "0";
            txtSTiennhaptu.Text = "0";
            _search.Ngaytu = null;
            _search.Ngayden = null;
            checkBoxNXB.Checked = false;
            checkBoxtinhtrang.Checked = false;
            checkBoxthoigian.Checked = false;
        }

        private void BtCTPN_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text == "")
            {
                MessageBox.Show("Chưa chọn phiếu nhập");
            }
            else
            {

                FrmNhapCTSach nhapCT = new FrmNhapCTSach();
                nhapCT.Message = txtMaPN.Text;
                nhapCT.MaNXB = CbNXB.SelectedValue.ToString().Trim();
                nhapCT.ShowDialog();
            }
        }

        private void BtLamMoi_Click(object sender, EventArgs e)
        {
            load();
        }

        private void BtReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
