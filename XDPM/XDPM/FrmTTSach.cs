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
    public partial class FrmTTSach : Form
    {
        public FrmTTSach()
        {
            InitializeComponent();
        }
        private string masach;

        public string Masach
        {
            get { return masach; }
            set { masach = value; }
        }
        private void FrmTTSach_Load(object sender, EventArgs e)
        {
            var Sach = DALSach.LaySachTheoMa(Masach);
            textBox1.Text=Sach.Masach;
            textBox2.Text = DALNXB.LayNXBtheoma(Sach.MaNXB).TenNXB;
            textBox3.Text = DALTheLoai.LayTheLoaiTheoMa(Sach.MaTheLoai).TenTheLoai;
            textBox8.Text = Sach.Tensach;
            textBox4.Text = Sach.Tacgia;
            textBox5.Text = Sach.GiaBan.ToString();
            textBox6.Text = Sach.GiaNhap.ToString();
            textBox7.Text = Sach.SoLuong.ToString();
        }     
    }
}
