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
    public partial class FrmDaiLy : Form
    {
        public FrmDaiLy()
        {
            InitializeComponent();
        }
        Daily _daily = new Daily();
        string _madaily="";
        SearchDaily _Search = new SearchDaily();
        public void load()
        {
            GVDaily.DataSource = DALDaiLy.loadDaily();
        }
        public void reset()
        {
            txtTenDaily.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtTienNo.Text = "";
        }
        public void GanProperties()
        {
            _daily.Tendaily = txtTenDaily.Text;
            _daily.Diachi = txtDiaChi.Text;
            _daily.SDT = txtSDT.Text;
        }
        private void FrmDaiLy_Load(object sender, EventArgs e)
        {
            GVDaily.AutoGenerateColumns = false;
            load();
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            BUSDaiLy _busdaily = new BUSDaiLy();
            if (txtTenDaily.Text== "" || txtDiaChi.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            else
            {
                _daily.Madaily = _busdaily.MaDaiLy();
                GanProperties();
                bool result = DALDaiLy.AddDaily(_daily);
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

        private void BTSua_Click(object sender, EventArgs e)
        {
            if (_madaily == "")
            {
                MessageBox.Show("Chưa chọn nhà xuất bản cần xóa");
            }
            else
            {
                _daily.Madaily = _madaily;
                GanProperties();
                bool result = DALDaiLy.UpdateDaily(_daily);
                if (result == true)
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

        private void GVDaily_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GVDaily.Rows[e.RowIndex];
                _madaily = row.Cells[0].Value.ToString();
            }
            var DailySelected = DALDaiLy.Laydailytheoma(_madaily);
            txtTenDaily.Text = DailySelected.Tendaily;
            txtDiaChi.Text = DailySelected.Diachi;
            txtSDT.Text = DailySelected.SDT;
            txtTienNo.Text = DailySelected.No.ToString();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            _Search.Madaily = txtmadaily.Text;
            _Search.Tendaily = txtSTenDaily.Text.Trim();
            _Search.Duong = txtSDuong.Text.Trim();
            _Search.Quan = txtSQuan.Text.Trim();
            _Search.notu = Convert.ToInt64(txtSNotu.Text);
            _Search.noden = Convert.ToInt64(txtSNoden.Text);
            BUSDaiLy _busdaily = new BUSDaiLy(_Search);
            GVDaily.DataSource = _busdaily.timkiemNXB();
            txtSDuong.Text = "";
            txtSNoden.Text = "0";
            txtSNotu.Text = "0";
            txtSQuan.Text = "";
            txtSTenDaily.Text = "";
            txtmadaily.Text = "";
        }
    }
}
