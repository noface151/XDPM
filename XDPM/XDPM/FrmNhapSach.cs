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
                txtMaPN.Text = _busnhapsach.MaPNtudong();
                GanProperties();
                bool result = DALPhieuNhap.ThemPhieuNhap(_pnsach);
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

        private void BtSua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            _pnsach.MaPN = txtMaPN.Text;
            GanProperties();
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
                                MessageBox.Show("Sửa thành công");
                                load();
                                reset();
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại");
                                reset();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa nhà cung cấp này vì ràng buộc dữ liệu");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Phiếu này đã xử lý xong, không thể sửa hoặc xóa");
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
        }

        private void BtXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            _pnsach.MaPN = txtMaPN.Text;
            if (DALPhieuNhap.LayPNtheoma(_pnsach.MaPN).TinhTrang != "Đã xong")
            {
                dialog = MessageBox.Show("Xóa Phiếu nhập sẽ xóa toàn bị chi tiết của phiếu. Có muốn xóa?", "Xóa phiếu nhập", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    bool result = DALPhieuNhap.XoaPhieuNhap(_pnsach,_pnsach.MaPN);
                    if (result == true)
                    {
                        MessageBox.Show("Xóa thành công");
                        load();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                        reset();
                    }
                }
            }
            else
            {
                MessageBox.Show("Phiếu này có tình trạng là Đã xong, không thể sửa hoặc xóa");
            }
        }
    }
}
