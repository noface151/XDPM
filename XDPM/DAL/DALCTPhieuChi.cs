using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCTPhieuChi
    {
        public static CTphieuchiNXB layCTPhieuchiTheoma(string maphieuchi)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var _CTphieuchi = (from p in model.CTphieuchiNXB
                               where p.Maphieuchi.Equals(maphieuchi)
                               select p).FirstOrDefault();
            return _CTphieuchi;
        }
        public static List<DSCT> DSsachbanduoctheoNXB(string manxb)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<DSCT> List = new List<DSCT>();
            var _sachbanduoc = (from p in model.Phieuthusach
                               from q in model.TTbansachDL
                               where q.Maphieuthu.Equals(p.Maphieuthu)&&q.TinhTrang.Trim()!="Đã trả nợ"
                               group q by q.Masach into g
                               select new
                               {
                                   Masach = g.Key,
                                   Soluong = g.Sum(q => q.Soluong),
                                   MaNXB=(from p in model.Sach
                                              where p.Masach.Equals(g.Key)
                                              select p.MaNXB).FirstOrDefault(),
                                              Tensach=(from p in model.Sach
                                                           where p.Masach.Equals(g.Key)
                                                           select p.Tensach).FirstOrDefault()
                               });
            _sachbanduoc = _sachbanduoc.Where(q => q.MaNXB.Equals(manxb));
            foreach(var row in _sachbanduoc)
            {
                DSCT _dsct = new DSCT();
                _dsct.Masach = row.Masach;
                _dsct.Tensach = row.Tensach;
                _dsct.soluong = row.Soluong;
                List.Add(_dsct);
            }
            return List;
        }
        public static bool ThemCTphieuchi(CTphieuchiNXB ctphieuchi)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            try
            {
                model.CTphieuchiNXB.Add(ctphieuchi);
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool CapNhatKhiThemCT(CTphieuchiNXB ctphieuchi)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var _phieuchi = (from p in model.PhieuchiNXB
                             where p.Maphieuchi.Equals(ctphieuchi.Maphieuchi)
                             select p).FirstOrDefault();
            var _TTbansach = from p in model.TTbansachDL
                             where p.Masach.Equals(ctphieuchi.Masach)
                             select p;
            try
            {
                foreach(var row in _TTbansach)
                {
                    row.TinhTrang = "Đã trả nợ";
                }
                _phieuchi.Tongtien = _phieuchi.Tongtien + ctphieuchi.Tienchi;
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<DSCT> layDSCT(string maphieuchi)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<DSCT> List=new List<DSCT>();
            var DSCT = from p in model.CTphieuchiNXB
                       where p.Maphieuchi.Equals(maphieuchi)
                       select new { p.Masach,p.Tienchi,p.Soluong,Tensach=(from q in model.Sach
                                                                              where q.Masach.Equals(p.Masach)
                                                                              select q.Tensach).FirstOrDefault()};
            foreach(var row in DSCT)
            {
                DSCT _dsct = new DSCT();
                _dsct.Masach = row.Masach;
                _dsct.Tensach = row.Tensach;
                _dsct.soluong = row.Soluong;
                _dsct.Tienchi = row.Tienchi;
                List.Add(_dsct);
            }
            return List;
        }
       
    }
}
