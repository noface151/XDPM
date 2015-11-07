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
    public partial class FrmNhapThongTinSach : Form
    {
        Sach sach = new Sach();
        string masach="";
        SearchSach _Search = new SearchSach();
        public FrmNhapThongTinSach()
        {
            InitializeComponent();
        }
        public void load()
        {
            GVSach.DataSource = DALSach.LayDSSach();           
        }
        
        public void ReSet()
        {
            txtGia.Text = "";
            txtSoLuong.Text = "";
            txtTacGia.Text = "";
            txtTensach.Text = "";
        }
        public void ganProperties()
        {
            sach.MaNXB = cbTenNXB.SelectedValue.ToString();
            sach.MaTheLoai = cbTenTheLoai.SelectedValue.ToString();
            sach.Tacgia = txtTacGia.Text;
            sach.Tensach = txtTensach.Text;
            sach.GiaBan = Convert.ToInt64(txtGia.Text);
        }
        private void FrmNhapThongTinSach_Load(object sender, EventArgs e)
        {
            GVSach.AutoGenerateColumns = false;
            load();
            //load combobox để thểm,sửa
            cbTenNXB.DataSource = DALNXB.loadNXB();
            cbTenNXB.DisplayMember = "TenNXB";
            cbTenNXB.ValueMember = "MaNXB";
            cbTenTheLoai.DataSource = DALTheLoai.DsTheLoai();
            cbTenTheLoai.DisplayMember = "TenTheLoai";
            cbTenTheLoai.ValueMember = "MaTheLoai";
            //load combobox để Tìm
            cbSNXB.DataSource = DALNXB.loadNXB();
            cbSNXB.DisplayMember = "TenNXB";
            cbSNXB.ValueMember = "MaNXB";
            cbSTheLoai.DataSource = DALTheLoai.DsTheLoai();
            cbSTheLoai.DisplayMember = "TenTheLoai";
            cbSTheLoai.ValueMember = "MaTheLoai";       
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string maNXB = "", maTheloai = "";
            if (cbSNXB.Text != "Chọn nhà xuất bản")
            {
                maNXB = cbSNXB.SelectedValue.ToString();
            }
            if (cbSTheLoai.Text != "Chọn thể loại")
            {
                maTheloai = cbSTheLoai.SelectedValue.ToString();
            }
            _Search.MaNXB = maNXB;
            _Search.MaTheLoai = maTheloai;
            _Search.giatu = Convert.ToInt64(txtSgianhaptu.Text);
            _Search.giaden = Convert.ToInt64(txtSgianhapden.Text);
            _Search.Tensach = txtSTenSach.Text;
            BUSSach busSach = new BUSSach(_Search);
            GVSach.DataSource = busSach.timkiemSach();
            txtSgianhapden.Text = "0";
            txtSgianhaptu.Text = "0";
            cbSNXB.Text = "Chọn nhà xuất bản";
            cbSTheLoai.Text = "Chọn thể loại";
            txtSTenSach.Text = "";
        }

        private void GVSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = GVSach.Rows[e.RowIndex];
                masach = row.Cells[0].Value.ToString();
            }
            var Sach = DALSach.LaySachTheoMa(masach);
            txtTensach.Text = Sach.Tensach;
            txtTacGia.Text = Sach.Tacgia;
            txtGia.Text = Sach.GiaBan.ToString();
            txtSoLuong.Text = Sach.SoLuong.ToString();
            cbTenNXB.Text = DALNXB.LayNXBtheoma(Sach.MaNXB).TenNXB;
            cbTenTheLoai.Text = DALTheLoai.LayTheLoaiTheoMa(Sach.MaTheLoai).TenTheLoai;
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            BUSSach bussach=new BUSSach();
            if(txtTensach.Text==""||txtTacGia.Text==""||txtGia.Text=="")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            else
            {
                sach.Masach = bussach.MaSachTuDong();
                ganProperties();
                bool result = DALSach.AddSach(sach);
                if(result==true)
                {
                    MessageBox.Show("Thêm thành công");
                    load();
                    ReSet();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    ReSet();
                }
            }
        }

        private void BTSua_Click(object sender, EventArgs e)
        {
            if (masach == "")
            {
                MessageBox.Show("Chưa chọn sách cần sửa");
            }
            else
            {
                sach.Masach = masach;
                ganProperties();
                bool result = DALSach.UpdateSach(sach);
                if (result == true)
                {
                    MessageBox.Show("Sửa thành công");
                    load();
                    ReSet();
                    masach = "";
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    ReSet();
                }
            }
        }
    }
}
