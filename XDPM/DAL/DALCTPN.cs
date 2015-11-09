using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCTPN
    {
        public static CTPNsach layCTPNtheoma(string MaPN)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var _CTPN = (from p in model.CTPNsach
                         where p.MaPN.Trim().Equals(MaPN)
                         select p).FirstOrDefault();
            return _CTPN;
        }
        public static bool XoaCTPNSach(CTPNsach ctpn)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var _CTPN = (from p in model.CTPNsach
                         where p.MaPN.Trim().Equals(ctpn.MaPN)
                         where p.Masach.Trim().Equals(ctpn.Masach)
                         select p).FirstOrDefault();
            try { model.CTPNsach.Remove(_CTPN); model.SaveChanges(); return true; }
            catch { return false; }
        }
    }
}
