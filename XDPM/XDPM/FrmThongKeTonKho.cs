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
    public partial class FrmThongKeTonKho : Form
    {
        public FrmThongKeTonKho()
        {
            InitializeComponent();
        }

        private void BtXemtonkho_Click(object sender, EventArgs e)
        {

            GVthongke.DataSource = DALThongKeTonKho.ThongKe(DALThongKeTonKho.layngaydau().Ngaynhap, Convert.ToDateTime(dateTimePicker2.Text));
        }

        private void FrmThongKeTonKho_Load(object sender, EventArgs e)
        {
            GVthongke.AutoGenerateColumns = false;
            labelmota.Hide();
            txtMoTa.Hide();
        }

        private void BtVietBaoCao_Click(object sender, EventArgs e)
        {
            labelmota.Show();
            txtMoTa.Show();
            if(txtMoTa.Text=="")
            {
                MessageBox.Show("Mời nhập mô tả cho file");
            }
            else
            {
                BUSThongKeTonKho thongke = new BUSThongKeTonKho();
                thongke.Mota = txtMoTa.Text;
                thongke.Tungay = DALThongKeTonKho.layngaydau().Ngaynhap;
                thongke.Denngay = Convert.ToDateTime(dateTimePicker2.Text);
                string path=thongke.VietBaoCao();
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
        }
    }
}
