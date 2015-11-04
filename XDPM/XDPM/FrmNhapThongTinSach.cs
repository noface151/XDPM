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
        public FrmNhapThongTinSach()
        {
            InitializeComponent();
        }
        public void load()
        {
            GVSach.DataSource = DALSach.LayDSSach();           
        }
        public void DGVDisable()
        {
            GVSach.Columns[1].Visible = false;
            GVSach.Columns[2].Visible = false;
            GVSach.Columns[4].Visible = false;
            GVSach.Columns[5].Visible = false;
            GVSach.Columns[6].Visible = false;
            GVSach.Columns[7].Visible = false;
            GVSach.Columns[8].Visible = false;
            GVSach.Columns[9].Visible = false;
            GVSach.Columns[10].Visible = false;
            GVSach.Columns[11].Visible = false;
            GVSach.Columns[12].Visible = false;
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
            sach.MaNXB = DALNXB.LayNXBtheoten(cbTenNXB.Text).MaNXB;
            sach.MaTheLoai = DALTheLoai.LayTheLoaiTheoTen(cbTenTheLoai.Text).MaTheLoai;
            sach.Tacgia = txtTacGia.Text;
            sach.Tensach = txtTensach.Text;
            sach.GiaBan = Convert.ToInt64(txtGia.Text);
        }
        private void FrmNhapThongTinSach_Load(object sender, EventArgs e)
        {
            load();
            DGVDisable();
            cbTenNXB.DataSource = DALNXB.layTenNXB();
            cbTenTheLoai.DataSource = DALTheLoai.layTenTheLoai();
            cbSNXB.Items.Add("Chọn nhà xuất bản");
            foreach(var item in DALNXB.layTenNXB())
            {
                cbSNXB.Items.Add(item);
            }
            cbSTheLoai.Items.Add("Chọn thể loại");
            foreach(var item in DALTheLoai.layTenTheLoai())
            {
                cbSTheLoai.Items.Add(item);
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            BUSSach busSach = new BUSSach();
              string maNXB="",maTheloai="";
              if (DALNXB.LayNXBtheoten(cbSNXB.Text)!=null)
              {
                  maNXB = (DALNXB.LayNXBtheoten(cbSNXB.Text)).MaNXB;
              }
              if (DALTheLoai.LayTheLoaiTheoTen(cbSTheLoai.Text)!=null)
              {
                  maTheloai = DALTheLoai.LayTheLoaiTheoTen(cbSTheLoai.Text).MaTheLoai;
              }
            GVSach.DataSource = busSach.timkiemSach(txtSTenSach.Text,maNXB,maTheloai, Convert.ToInt64(txtSgianhaptu.Text), Convert.ToInt64(txtSgianhapden.Text));
            txtSgianhapden.Text = "0";
            txtSgianhaptu.Text = "0";
            cbSNXB.Text = "Chọn nhà xuất bản";
            cbSTheLoai.Text="Chọn thể loại";
            DGVDisable();
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
                    DGVDisable();
                    ReSet();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
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
                    DGVDisable();
                    ReSet();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }
    }
}
