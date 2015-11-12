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
    public partial class FrmChiNXB : Form
    {
        public FrmChiNXB()
        {
            InitializeComponent();
        }
        PhieuchiNXB _phieuchi = new PhieuchiNXB();
        SearchPhieuNhapPhieuChi _search = new SearchPhieuNhapPhieuChi();
        Nhaxuatban _nxb = new Nhaxuatban();
        public void load()
        {
            GVphieuchi.DataSource = DALPhieuChiNXB.DSphieuchi();
        }
        public void GanProperties()
        {
            _phieuchi.MaNXB = cbNXB.SelectedValue.ToString();
            _phieuchi.Ngay = Convert.ToDateTime(dateNgaylap.Text);
            _phieuchi.TrangThai = cbTrangThai.Text;
        }
        public void reset()
        {
            txtmaphieuchi.Text = "";
            txtTongtien.Text = "";
        }
        private void FrmChiNXB_Load(object sender, EventArgs e)
        {
            GVphieuchi.AutoGenerateColumns = false;
            load();
            cbNXB.DataSource = DALNXB.loadNXBCoNo();
            cbNXB.DisplayMember = "TenNXB";
            cbNXB.ValueMember = "MaNXB";
            CBSNXB.DataSource = DALNXB.loadNXB();
            CBSNXB.DisplayMember = "TenNXB";
            CBSNXB.ValueMember = "MaNXB";

        }

        private void BTThem_Click(object sender, EventArgs e)
        {
            if (cbTrangThai.Text != "Đang chờ")
            {
                MessageBox.Show("Thêm phiếu chi trạng thái phải là ĐANG CHỜ");
            }
            else if (txtmaphieuchi.Text != "")
            {
                MessageBox.Show("Không thể thêm");
            }
            else
            {
                BUSPhieuChiNXB busphieuchi = new BUSPhieuChiNXB();
                _phieuchi.Maphieuchi = busphieuchi.maphieuchitudong();
                GanProperties();
                bool result = DALPhieuChiNXB.ThemPhieuChi(_phieuchi);
                if (result == true)
                {
                    MessageBox.Show("Thêm thành công");
                    load();
                    reset();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    reset();
                }
            }
        }

        private void GVphieuchi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = GVphieuchi.Rows[e.RowIndex];
                txtmaphieuchi.Text = row.Cells[0].Value.ToString();
            }
            var phieuchi = DALPhieuChiNXB.layphieuchitheoma(txtmaphieuchi.Text);
            dateNgaylap.Text = phieuchi.Ngay.ToString();
            txtTongtien.Text = phieuchi.Tongtien.ToString();
            cbTrangThai.Text = phieuchi.TrangThai;
            cbNXB.Text = DALNXB.LayNXBtheoma(phieuchi.MaNXB).TenNXB;
        }

        private void BTSua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            _phieuchi.Maphieuchi = txtmaphieuchi.Text;
            GanProperties();
            if (_phieuchi.Maphieuchi == "")
            { MessageBox.Show("Chưa chọn phiếu cần sửa"); }
            else
            {
                BUSPhieuChiNXB _busphieuchi = new BUSPhieuChiNXB(_phieuchi);
                bool result1 = _busphieuchi.KiemTraSuaPhieuChi();
                bool result = _busphieuchi.KiemTraTinhTrang();
                if (DALPhieuChiNXB.layphieuchitheoma(_phieuchi.Maphieuchi).TrangThai.Trim()!= "Đã nhận")
                {
                    if (result == true)
                    {
                        dialog = MessageBox.Show("Trạng thái là ĐÃ NHẬN thì phiếu chi này sẽ không thể SỬA hoặc XÓA. Có muốn thay đổi?", "Sửa tình trạng", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            if (result1 == true)
                            {
                                bool result2 = DALPhieuChiNXB.suaphieuchi(_phieuchi);
                                if (result2 == true)
                                {
                                    _nxb.MaNXB = _phieuchi.MaNXB;
                                    _nxb.No = DALPhieuChiNXB.layphieuchitheoma(_phieuchi.Maphieuchi).Tongtien;
                                    DALNXB.UpdateNoNXBKhiTra(_nxb);
                                    MessageBox.Show("Sửa thành công");
                                    load();
                                    reset();
                                    txtmaphieuchi.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("Sửa thất bại");
                                    reset();
                                    txtmaphieuchi.Text = "";
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
                            bool result2 = DALPhieuChiNXB.suaphieuchi(_phieuchi);
                            if (result2 == true)
                            {
                                MessageBox.Show("Sửa thành công");
                                load();
                                reset();
                                txtmaphieuchi.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Sửa thất bại");
                                reset();
                                txtmaphieuchi.Text = "";
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

        private void BtXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            _phieuchi.Maphieuchi = txtmaphieuchi.Text;
            if (_phieuchi.Maphieuchi == "")
            { MessageBox.Show("Chưa chọn phiếu cần xóa"); }
            else
            {
                if (DALPhieuChiNXB.layphieuchitheoma(_phieuchi.Maphieuchi).TrangThai != "Đã nhận")
                {
                    dialog = MessageBox.Show("Xóa Phiếu chi sẽ xóa toàn bị chi tiết của phiếu. Có muốn xóa?", "Xóa phiếu chi", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        bool result = DALPhieuChiNXB.xoaphieuchi(_phieuchi);
                        if (result == true)
                        {
                            MessageBox.Show("Xóa thành công");
                            load();
                            reset();
                            txtmaphieuchi.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                            reset();
                            txtmaphieuchi.Text = "";
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
            _search.tiennhaptu = Convert.ToInt64(txtSTienchitu.Text);
            _search.tiennhapden = Convert.ToInt64(txtSTienchiden.Text);
            GVphieuchi.DataSource = DALPhieuChiNXB.LayPhieuchitheoTimkiem(_search);
            txtSTienchitu.Text = "0";
            txtSTienchiden.Text = "0";
            _search.Ngaytu = null;
            _search.Ngayden = null;
        }

        private void BtGhichitiet_Click(object sender, EventArgs e)
        {
            if(txtmaphieuchi.Text=="")
            {
                MessageBox.Show("Chưa chọn phiếu chi");
            }
            else if(DALPhieuChiNXB.layphieuchitheoma(txtmaphieuchi.Text).TrangThai!="Đã nhận")
            {
                FrmCTPhieuchiNXB ctphieuchi = new FrmCTPhieuchiNXB();
                ctphieuchi.MaNXB = cbNXB.SelectedValue.ToString();
                ctphieuchi.Maphieuchi = txtmaphieuchi.Text;
                ctphieuchi.ShowDialog();
            }
            else
            {
                MessageBox.Show("Phiếu chi có trạng thái là ĐÃ NHẬN, không thể ghi thêm chi tiết");
            }
        }

        private void BTlammoi_Click(object sender, EventArgs e)
        {
            load();
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            reset();
        }

    }
}
