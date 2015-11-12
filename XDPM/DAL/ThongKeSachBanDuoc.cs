using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeSachBanDuoc
    {
        public string MaDaiLy { get; set; }
        public string MaNXB { get; set; }
        private DateTime? tungay = null;

        public DateTime? Tungay
        {
            get { return tungay; }
            set { tungay = value; }
        }
        private DateTime? dengay = null;

        public DateTime? Dengay
        {
            get { return dengay; }
            set { dengay = value; }
        }
        public string Tensach { get; set; }
        public int soluong { get; set; }
    }
}
