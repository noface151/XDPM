using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSNhapsach
    {
        PNsach phieunhap;
        public BUSNhapsach(PNsach phieunhap) { this.phieunhap = phieunhap; }
        public BUSNhapsach() { }
        public string MaPNtudong()
        {
            string maPN="";
            int i = 1;
            while(i!=0)
            {
                maPN = "PNS" + (DALPhieuNhap.TongSLPhieuNhap() + i).ToString();
                if(DALPhieuNhap.LayPNtheoma(maPN)==null)
                {
                    break;
                }
                else
                {
                    i++;
                }
            }
            return maPN;
        }
        public bool KiemTraSuaPhieuNhap()
        {
            if (phieunhap.MaNXB != DALPhieuNhap.LayPNtheoma(phieunhap.MaPN).MaNXB)
            {
                if (DALCTPN.layCTPNtheoma(phieunhap.MaPN) != null)
                    return false;
                else return true;
            }
            else return true;
        }
        public bool KiemTraTinhTrang()
        {
            if (phieunhap.TinhTrang == "Đã xong")
                return true;
            else return false;
        }
    }
}
