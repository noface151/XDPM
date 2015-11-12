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
            ThongKeSachBanDuoc tk=new ThongKeSachBanDuoc();
            if(checkBoxdaily.Checked==false&&checkBoxthoigian.Checked==false)
            {
                MessageBox.Show("Không có dữ liệu để thóng kê");
            }
            else
            {
                if(checkBoxdaily.Checked==true)
                {
                    tk.MaDaiLy=cbDaily.SelectedValue.ToString();
                }
                if(checkBoxthoigian.Checked==true)
                {
                    tk.Tungay=Convert.ToDateTime(datetungay.Text);
                    tk.Dengay=Convert.ToDateTime(datedenngay.Text);
                    if(tk.Tungay<tk.Dengay)
                    {
                        MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                        tk.Tungay = null;
                        tk.Dengay = null;
                    }
                }
                dataGridView1.DataSource = DALThongKeSachBanDuoc.ThongKe(tk);
            }
        }
        private void FrmThongKeSachBanDuoc_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            cbDaily.DataSource = DALDaiLy.loadDaily();
            cbDaily.DisplayMember = "Tendaily";
            cbDaily.ValueMember = "Madaily";
        }  
    }
}
