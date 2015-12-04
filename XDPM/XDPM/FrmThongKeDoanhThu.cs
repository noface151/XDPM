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
using System.Diagnostics;
using System.IO;
namespace XDPM
{
    public partial class FrmThongKeDoanhThu : Form
    {
        public FrmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void FrmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            GVchi.AutoGenerateColumns = false;
            GVthu.AutoGenerateColumns = false;
            txtmota.Hide();
            labelmota.Hide();
            labelLoaiBaoCao.Hide();
            cbLoaibaocao.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long tongtienthu = 0, tongtienchi = 0;
            int flag = 0;
            if (Convert.ToDateTime(dateTungay.Text) > Convert.ToDateTime(dateDenngay.Text))
            {
                flag = 1;
            }
            if (flag == 0)
            {
                List<DSCT> tienthu = DALThongKeDoanhThu.ListSachthu(Convert.ToDateTime(dateTungay.Text), Convert.ToDateTime(dateDenngay.Text));
                GVthu.DataSource = tienthu;
                List<DSCT> tienchi = DALThongKeDoanhThu.ListSachChi(Convert.ToDateTime(dateTungay.Text), Convert.ToDateTime(dateDenngay.Text));
                GVchi.DataSource = tienchi;
                foreach (var i in tienthu)
                {
                    tongtienthu = tongtienthu + i.Tienthu;
                }
                foreach (var i in tienchi)
                {
                    tongtienchi = tongtienchi + i.Tienchi;
                }
                txtTienchi.Text = tongtienchi.ToString();
                txtTienthu.Text = tongtienthu.ToString();
                txtdoanhthu.Text = (tongtienthu - tongtienchi).ToString();
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtmota.Show();
            labelmota.Show();
            labelLoaiBaoCao.Show();
            cbLoaibaocao.Show();
            int flag = 0;
            if (txtmota.Text == "")
            {
                MessageBox.Show("Mời nhập mô tả cho file");
            }
            else
            {
                if (Convert.ToDateTime(dateTungay.Text) > Convert.ToDateTime(dateDenngay.Text))
                {
                    flag = 1;
                }
                if (flag == 0)
                {
                    BUSThongKeDoanhThu thongke = new BUSThongKeDoanhThu();
                    thongke.Loaibaocao = cbLoaibaocao.Text;
                    thongke.Mota = txtmota.Text;
                    thongke.Tungay = Convert.ToDateTime(dateTungay.Text);
                    thongke.Denngay = Convert.ToDateTime(dateDenngay.Text);
                    string path = thongke.VietBaoCao();
                    if (path != "")
                    {
                        MessageBox.Show("Lưu báo cáo thành công");
                        DialogResult result = MessageBox.Show("Có muốn xem báo cáo vừa ghi ?", "Xem báo cáo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            ProcessStartInfo ps = new ProcessStartInfo();
                            ps.FileName = Path.GetFileName(path);
                            ps.WorkingDirectory = Path.GetDirectoryName(path);
                            Process.Start(ps);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại file, mời nhập lại mô tả");
                    }
                }
                else
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                }
            }
        }
    }
}
