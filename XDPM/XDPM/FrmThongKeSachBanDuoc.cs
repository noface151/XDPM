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
using CrystalDecisions.CrystalReports.Engine;

namespace XDPM
{
    public partial class FrmThongKeSachBanDuoc : Form
    {
        public FrmThongKeSachBanDuoc()
        {
            InitializeComponent();
        }

        private void BtThongKe_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string madaily = "";
            DateTime? tungay = null, denngay = null;
            if (checkBoxdaily.Checked == false && checkBoxthoigian.Checked == false)
            {
                MessageBox.Show("Không có dữ liệu để thóng kê");
            }
            else
            {
                if (checkBoxdaily.Checked == true)
                {
                    madaily = cbDaily.SelectedValue.ToString();
                }
                if (checkBoxthoigian.Checked == true)
                {
                    tungay = Convert.ToDateTime(datetungay.Text);
                    denngay = Convert.ToDateTime(datedenngay.Text);
                    if (tungay > denngay)
                    {
                        MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                        tungay = null;
                        denngay = null;
                        flag = 1;
                    }
                }
                if(flag==0)
               dataGridView1.DataSource = DALThongKeSachBanDuoc.ThongKe(madaily,tungay,denngay);
            }
        }
        private void FrmThongKeSachBanDuoc_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            cbDaily.DataSource = DALDaiLy.loadDaily();
            cbDaily.DisplayMember = "Tendaily";
            cbDaily.ValueMember = "Madaily";
            txtmota.Hide();
            labelmota.Hide();
        }

        private void BtVietbaocao_Click(object sender, EventArgs e)
        {
            int flag = 0;
            txtmota.Show();
            labelmota.Show();
            string madaily = "";
            DateTime? tungay = null,denngay=null;
            if (txtmota.Text == "")
            {
                MessageBox.Show("Hãy nhập mô tả cho file báo cáo");
            }
            else
            {
                if (checkBoxdaily.Checked == false && checkBoxthoigian.Checked == false)
                {
                    MessageBox.Show("Không có dữ liệu để thóng kê");
                }
                else
                {
                    if (checkBoxdaily.Checked == true)
                    {
                        madaily = cbDaily.SelectedValue.ToString();
                    }
                    if (checkBoxthoigian.Checked == true)
                    {
                       tungay = Convert.ToDateTime(datetungay.Text);
                       denngay = Convert.ToDateTime(datedenngay.Text);
                        if (tungay > denngay)
                        {
                            flag = 1;
                            MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                            tungay = null;
                            denngay = null;
                        }
                    }
                    if (flag == 0)
                    {
                        BUSThongKeSachBan thongke = new BUSThongKeSachBan();
                        thongke.Motafile = txtmota.Text;
                        thongke.Madaily = madaily;
                        thongke.Tungay = tungay;
                        thongke.Denngay = denngay;
                        string path = thongke.ThongKeSachBan();
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
    }
}


    


