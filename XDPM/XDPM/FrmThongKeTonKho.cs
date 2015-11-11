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
        }
    }
}
