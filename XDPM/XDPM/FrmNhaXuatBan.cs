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
    public partial class FrmNhaXuatBan : Form
    {
        Nhaxuatban _NXB = new Nhaxuatban();
        string _MaNXB = "";
        SearchNXB _Search = new SearchNXB();
        public FrmNhaXuatBan()
        {
            InitializeComponent();
        }
        public void load()
        {
            GVNXB.DataSource = DALNXB.loadNXB();
        }
        public void reset()
        {
            txtTenNXB.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTienNo.Text = "";
            txtSoTK.Text = "";
        }
        public void GanPropserties()
        {
            _NXB.TenNXB = txtTenNXB.Text;
            _NXB.Diachi = txtDiaChi.Text;
            _NXB.SDT = txtSoTK.Text;
            _NXB.Sotaikhoan = txtSoTK.Text;
        }
        private void FrmNhaXuatBan_Load(object sender, EventArgs e)
        {
            GVNXB.AutoGenerateColumns = false;
            load();
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            BUSNXB _busNXB = new BUSNXB();
            if(txtTenNXB.Text==""||txtDiaChi.Text==""||txtDiaChi.Text==""||txtSDT.Text=="")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            else
            {
                _NXB.MaNXB = _busNXB.MaNXBtudong();
                GanPropserties();
                bool result=DALNXB.AddNXB(_NXB);
                if(result==true)
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

        private void GVNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = GVNXB.Rows[e.RowIndex];
                _MaNXB = row.Cells[0].Value.ToString();
            }
            var NXBSelected = DALNXB.LayNXBtheoma(_MaNXB);
            txtTenNXB.Text = NXBSelected.TenNXB;
            txtDiaChi.Text = NXBSelected.Diachi;
            txtSDT.Text = NXBSelected.SDT;
            txtTienNo.Text =NXBSelected.No.ToString();
            txtSoTK.Text = NXBSelected.Sotaikhoan;
        }

        private void BTSua_Click(object sender, EventArgs e)
        {
            if(_MaNXB=="")
            {
                MessageBox.Show("Chưa chọn nhà xuất bản cần xóa");
            }
            else
            {
                _NXB.MaNXB = _MaNXB;
                GanPropserties();
                bool result = DALNXB.UpdateNXB(_NXB);
                if(result==true)
                {
                    MessageBox.Show("Sửa thành công");
                    load();
                    reset();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    load();
                    reset();
                }
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            _Search.MaNXB = txtSMaNXB.Text;
            _Search.TenNXB = txtSTenNXB.Text.Trim();
            _Search.Duong = txtSDuong.Text.Trim();
            _Search.Quan = txtSQuan.Text.Trim();
            _Search.notu = Convert.ToInt64(txtSNotu.Text);
            _Search.noden = Convert.ToInt64(txtSNoden.Text);
            BUSNXB _busNXB = new BUSNXB(_Search);
            GVNXB.DataSource = _busNXB.timkiemNXB();
            txtSDuong.Text = "";
            txtSNoden.Text = "0";
            txtSNotu.Text = "0";
            txtSQuan.Text = "";
            txtSTenNXB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
