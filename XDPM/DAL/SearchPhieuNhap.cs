using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SearchPhieuNhap
    {
        public string MaNXB { get; set; }
        public string MaPN { get; set; }
        public string TinhTrang { get; set; }
        private DateTime? ngaynhaptu = null;

        public DateTime? Ngaynhaptu
        {
            get { return ngaynhaptu; }
            set { ngaynhaptu = value; }
        }
        private DateTime? ngaynhapden = null;

        public DateTime? Ngaynhapden
        {
            get { return ngaynhapden; }
            set { ngaynhapden = value; }
        }
        public DateTime Ngaynhap { get; set; }
        public long tiennhaptu { get; set; }
        public long tiennhapden { get; set; }
        public long Tongtien { get; set; }
    }
}
