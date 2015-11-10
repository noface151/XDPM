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
        public static CTPNsach layCTPN(CTPNsach ctpn)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var CTphieunhap = (from p in model.CTPNsach
                               where p.MaPN.Equals(ctpn.MaPN) && p.Masach.Equals(ctpn.Masach)
                               select p).FirstOrDefault();
            return CTphieunhap;
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
        public static bool ThemCTPNSach(CTPNsach ctpn)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            try
            {
                model.CTPNsach.Add(ctpn);
                model.SaveChanges();             
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool CapNhatKhiThemchitiet(CTPNsach ctpn)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var Phieunhap = (from p in model.PNsach
                             where p.MaPN.Equals(ctpn.MaPN)
                             select p).FirstOrDefault();
            var CTphieunhap = (from p in model.CTPNsach
                               where p.MaPN.Equals(ctpn.MaPN) && p.Masach.Equals(ctpn.Masach)
                               select p).FirstOrDefault();
            var _Sach = (from p in model.Sach
                        where p.Masach.Equals(ctpn.Masach)
                        select p).FirstOrDefault();
            try
            {
                Phieunhap.Tongtien = Phieunhap.Tongtien + CTphieunhap.Gia;
                _Sach.SoLuong = _Sach.SoLuong + CTphieunhap.Soluong;
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }       
        public static bool CapNhatKhiSuachitiet(CTPNsach ctpn,long giatam,int soluongtam)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var Phieunhap = (from p in model.PNsach
                             where p.MaPN.Equals(ctpn.MaPN)
                             select p).FirstOrDefault();
            var CTphieunhap = (from p in model.CTPNsach
                               where p.MaPN.Equals(ctpn.MaPN) && p.Masach.Equals(ctpn.Masach)
                               select p).FirstOrDefault();
            var _Sach = (from p in model.Sach
                        where p.Masach.Equals(ctpn.Masach)
                        select p).FirstOrDefault();
            try
            {
                CTphieunhap.Soluong = ctpn.Soluong;
                CTphieunhap.Gia = ctpn.Gia;
                Phieunhap.Tongtien = giatam + CTphieunhap.Gia;
                _Sach.SoLuong = soluongtam + CTphieunhap.Soluong;
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool CapNhatKhiXoachitiet(CTPNsach ctpn)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var Phieunhap = (from p in model.PNsach
                             where p.MaPN.Equals(ctpn.MaPN)
                             select p).FirstOrDefault();
            var CTphieunhap = (from p in model.CTPNsach
                               where p.MaPN.Equals(ctpn.MaPN) && p.Masach.Equals(ctpn.Masach)
                               select p).FirstOrDefault();
            var _Sach = (from p in model.Sach
                         where p.Masach.Equals(ctpn.Masach)
                         select p).FirstOrDefault();
            try
            {
                Phieunhap.Tongtien = Phieunhap.Tongtien - CTphieunhap.Gia;
                _Sach.SoLuong = _Sach.SoLuong - CTphieunhap.Soluong;
                model.CTPNsach.Remove(CTphieunhap);             
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<DSCT> LayDSCT(string maPN)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<DSCT> List = new List<DSCT>();
            var DSCT = from p in model.CTPNsach
                       where p.MaPN.Trim().Equals(maPN)
                       select new { p.Masach,Tensach=(from q in model.Sach
                                                          where q.Masach.Trim().Equals(p.Masach)
                                                          select q.Tensach).FirstOrDefault(),p.Soluong,p.Gia};
            foreach(var row in DSCT)
            {
                DSCT _dsct = new DSCT();
                _dsct.Masach = row.Masach;
                _dsct.Tensach = row.Tensach;
                _dsct.soluong = row.Soluong;
                _dsct.Gia = row.Gia;
                List.Add(_dsct);
            }
            return List;
        }
    }
}
