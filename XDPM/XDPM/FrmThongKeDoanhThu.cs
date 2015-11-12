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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long tongtienthu=0,tongtienchi=0;
            List<DSCT> tienthu= DALThongKeDoanhThu.ListSachthu(Convert.ToDateTime(dateTungay.Text), Convert.ToDateTime(dateDenngay.Text));
            GVthu.DataSource = tienthu;
            List<DSCT> tienchi = DALThongKeDoanhThu.ListSachChi(Convert.ToDateTime(dateTungay.Text), Convert.ToDateTime(dateDenngay.Text));
            GVchi.DataSource = tienchi;
            foreach(var i in tienthu)
            {
                tongtienthu= tongtienthu + i.Tienthu;
            }
            foreach(var i in tienchi)
            {
                tongtienchi = tongtienchi + i.Tienchi;
            }
            txtTienchi.Text = tongtienchi.ToString();
            txtTienthu.Text = tongtienthu.ToString();
            txtdoanhthu.Text = (tongtienthu - tongtienchi).ToString();
        }
    }
}
