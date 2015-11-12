using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPhieuChiNXB
    {
        public static bool ThemPhieuChi(PhieuchiNXB phieuchi)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            try
            {
                model.PhieuchiNXB.Add(phieuchi);
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<PhieuchiNXB> DSphieuchi()
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<PhieuchiNXB> List = new List<PhieuchiNXB>();
            var phieuchi = from p in model.PhieuchiNXB
                           select p;
            return List = phieuchi.ToList();
        }
        public static int Soluongphieuchi()
        {
            DBQLPhatHanhSachEntities moddel = new DBQLPhatHanhSachEntities();
            var count = (from p in moddel.PhieuchiNXB
                         select p).Count();
            return count;
        }
        public static PhieuchiNXB layphieuchitheoma(string maphieuchi)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var _phieuchi = (from p in model.PhieuchiNXB
                             where p.Maphieuchi.Equals(maphieuchi)
                             select p).FirstOrDefault();
            return _phieuchi;
        }
        public static bool suaphieuchi(PhieuchiNXB phieuchi)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var _phieuchi = (from p in model.PhieuchiNXB
                             where p.Maphieuchi.Equals(phieuchi.Maphieuchi)
                             select p).FirstOrDefault();
            if (_phieuchi == null)
                return false;
            else
            {
                _phieuchi.MaNXB = phieuchi.MaNXB;
                _phieuchi.Ngay = phieuchi.Ngay;
                _phieuchi.TrangThai = phieuchi.TrangThai;
                model.SaveChanges();
                return true;
            }
        }
        public static bool xoaphieuchi(PhieuchiNXB phieuchi)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var _phieuchi = (from p in model.PhieuchiNXB
                             where p.Maphieuchi.Equals(phieuchi.Maphieuchi)
                             select p).FirstOrDefault();
            var _ctphieuchi = from p in model.CTphieuchiNXB
                              where p.Maphieuchi.Equals(phieuchi.Maphieuchi)
                              select p;
            try
            {
                foreach (var row in _ctphieuchi)
                {
                    model.CTphieuchiNXB.Remove(row);
                }
                model.PhieuchiNXB.Remove(_phieuchi);
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<SearchPhieuNhapPhieuChi> LayPhieuchitheoTimkiem(SearchPhieuNhapPhieuChi Search)
        {
            List<SearchPhieuNhapPhieuChi> ListSearch = new List<SearchPhieuNhapPhieuChi>();
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var DSPhieuchi = (from p in model.PhieuchiNXB
                        select p);
            if (Search.MaNXB != "")
            {
                DSPhieuchi = DSPhieuchi.Where(q => q.MaNXB.Trim().Equals(Search.MaNXB));
            }
            if (Search.TinhTrang != "")
            {
                DSPhieuchi = DSPhieuchi.Where(q => q.TrangThai.Trim().Equals(Search.TinhTrang));
            }
            if (Search.Ngaytu != null && Search.Ngayden != null)
            {
                if (Search.Ngaytu.ToString() != Search.Ngayden.ToString())
                    DSPhieuchi = DSPhieuchi.Where(q => q.Ngay >= Search.Ngaytu && q.Ngay <= Search.Ngayden);
                else DSPhieuchi = DSPhieuchi.Where(q => q.Ngay == Search.Ngaytu);
            }
            if (Search.tiennhaptu != 0 && Search.tiennhapden != 0)
            {
                DSPhieuchi = DSPhieuchi.Where(q => q.Tongtien >= Search.tiennhaptu && q.Tongtien <= Search.tiennhapden);
            }
            if (Search.tiennhaptu != 0 && Search.tiennhapden == 0)
            {
                DSPhieuchi = DSPhieuchi.Where(q => q.Tongtien >= Search.tiennhaptu);
            }
            if (Search.tiennhaptu == 0 && Search.tiennhapden != 0)
            {
                DSPhieuchi = DSPhieuchi.Where(q => q.Tongtien <= Search.tiennhapden);
            }
            if (Search.tiennhaptu == Search.tiennhapden && Search.tiennhaptu != 0 && Search.tiennhapden != 0)
            {
                DSPhieuchi = DSPhieuchi.Where(q => q.Tongtien == Search.tiennhaptu);
            }
            foreach (var row in DSPhieuchi)
            {
                SearchPhieuNhapPhieuChi _search = new SearchPhieuNhapPhieuChi();
                _search.Ngay = row.Ngay;
                _search.TrangThai = row.TrangThai;
                _search.Tongtien = row.Tongtien;
                _search.Maphieuchi = row.Maphieuchi;
                ListSearch.Add(_search);
            }
            return ListSearch;
        }
    }
}
