using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPhieuNhap
    {
        public static bool ThemPhieuNhap(PNsach pnsach)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            try
            {
                model.PNsach.Add(pnsach);
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool SuaPhieuNhap(PNsach pnsach)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var _pnsach = (from p in model.PNsach
                           where p.MaPN.Trim().Equals(pnsach.MaPN.Trim())
                           select p).FirstOrDefault();
            if (_pnsach == null)
                return false;
            else
            {
                _pnsach.MaNXB = pnsach.MaNXB;
                _pnsach.Ngaynhap = pnsach.Ngaynhap;
                _pnsach.Nguoigiao = pnsach.Nguoigiao;                
                _pnsach.TinhTrang = pnsach.TinhTrang;
                model.SaveChanges();
                return true;
            }
        }
        public static bool XoaPhieuNhap(PNsach pnsach,string MaPN)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var _pnsach = (from p in model.PNsach
                           where p.MaPN.Trim().Equals(pnsach.MaPN)
                           select p).FirstOrDefault();
            var _ctpn = from p in model.CTPNsach
                         where p.MaPN.Trim().Equals(pnsach.MaPN)
                         select p;
            try
            {
                foreach(var row in _ctpn)
                {
                    model.CTPNsach.Remove(row);                  
                }
                model.PNsach.Remove(_pnsach);
                model.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public static PNsach LayPNtheoma(string maPN)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var _phieunhap = (from p in model.PNsach
                              where p.MaPN.Trim().Equals(maPN.Trim())
                              select p).FirstOrDefault();
            return _phieunhap;
        }
        public static int TongSLPhieuNhap()
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var count = (from p in model.PNsach
                         select p).Count();
            return count;
        }
        public static List<PNsach> LoadDSPN()
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<PNsach> List = new List<PNsach>();
            var DSPN = from p in model.PNsach
                       select p;
             return List = DSPN.ToList();
        }
        public static List<SearchPhieuNhap>LayPNtheoTimkiem(SearchPhieuNhap Search)
        {
            List<SearchPhieuNhap> ListSearch=new List<SearchPhieuNhap>();
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var DSPN = (from p in model.PNsach
                        select p);
            if(Search.MaNXB!="")
            {
                DSPN = DSPN.Where(q => q.MaNXB.Trim().Equals(Search.MaNXB));
            }
            if(Search.TinhTrang!="")
            {
                DSPN = DSPN.Where(q => q.TinhTrang.Trim().Equals(Search.TinhTrang));
            }
            if(Search.Ngaynhaptu!=null&&Search.Ngaynhapden!=null)
            {
                DateTime newngaynhaptu = Search.Ngaynhaptu.Value.AddDays(-1);
                if (Search.Ngaynhaptu.ToString() != Search.Ngaynhapden.ToString())
                    DSPN = DSPN.Where(q => q.Ngaynhap >= Search.Ngaynhaptu && q.Ngaynhap <= Search.Ngaynhapden);
                else DSPN = DSPN.Where(q => q.Ngaynhap == Search.Ngaynhaptu);
            }
            if(Search.tiennhaptu!=0&&Search.tiennhapden!=0)
            {
                DSPN = DSPN.Where(q => q.Tongtien >= Search.tiennhaptu && q.Tongtien <= Search.tiennhapden);
            }
            if(Search.tiennhaptu!=0&&Search.tiennhapden==0)
            {
                DSPN = DSPN.Where(q => q.Tongtien >= Search.tiennhaptu);
            }
            if(Search.tiennhaptu==0&&Search.tiennhapden!=0)
            {
                DSPN = DSPN.Where(q => q.Tongtien <= Search.tiennhapden);
            }
            if(Search.tiennhaptu==Search.tiennhapden)
            {
                DSPN = DSPN.Where(q => q.Tongtien == Search.tiennhaptu);
            }
            foreach(var row in DSPN)
            {
                SearchPhieuNhap _search = new SearchPhieuNhap();
                _search.Ngaynhap = row.Ngaynhap;
                _search.TinhTrang = row.TinhTrang;
                _search.Tongtien = row.Tongtien;
                _search.MaPN = row.MaPN;
                ListSearch.Add(_search);
            }
            return ListSearch;
        }
    }
}
