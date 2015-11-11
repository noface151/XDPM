using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSPhieuChiNXB
    {
        PhieuchiNXB phieuchi;
        public BUSPhieuChiNXB(PhieuchiNXB phieuchi) { this.phieuchi = phieuchi; }
        public BUSPhieuChiNXB() { }
        public string maphieuchitudong()
        {
            string maphieuchi="";
            int i = 1;
            while(i!=0)
            {
                maphieuchi ="Pchi"+(DALPhieuChiNXB.Soluongphieuchi() + i).ToString();
                if(DALPhieuChiNXB.layphieuchitheoma(maphieuchi)==null)
                {
                    break;
                }
                else
                {
                    i++;
                }
            }
            return maphieuchi;
        }
        public bool KiemTraSuaPhieuChi()
        {
            if (phieuchi.MaNXB != DALPhieuChiNXB.layphieuchitheoma(phieuchi.Maphieuchi).MaNXB)
            {
                if (DALCTPhieuChi.layCTPhieuchiTheoma(phieuchi.Maphieuchi) != null)
                    return false;
                else return true;
            }
            else return true;
        }

        public bool KiemTraTinhTrang()
        {
            if (phieuchi.TrangThai == "Đã nhận")
                return true;
            else return false;
        }
    }
}
