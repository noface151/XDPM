using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALThongKeTonKho
    {
        public static PNsach layngaydau()
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var x = (from p in model.PNsach
                     select p).FirstOrDefault();
            return x;
        }
        public static List<DSCT> ThongKe(DateTime tungay, DateTime denngay)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<DSCT> List = new List<DSCT>();
            
            var _Soluongsachnhap = from p in model.PNsach
                                   from q in model.CTPNsach
                                   where p.Ngaynhap >= tungay && p.Ngaynhap <= denngay && q.MaPN.Equals(p.MaPN)
                                   group q by q.Masach into g
                                   select new
                                   {
                                       Masach = g.Key,
                                       soluong = g.Sum(q => q.Soluong),
                                       Tensach = (from x in model.Sach
                                                  where x.Masach.Equals(g.Key)
                                                  select x.Tensach).FirstOrDefault()
                                   };
            var _Soluongsachxuat = from p in model.PXsach
                                   from q in model.CTPXsach
                                   where p.Ngayxuat >= tungay && p.Ngayxuat <= denngay && q.MaPX.Equals(p.MaPX)
                                   group q by q.Masach into g
                                   select new
                                   {
                                       Masach = g.Key,
                                       soluong = g.Sum(q => q.Soluong),
                                       Tensach = (from x in model.Sach
                                                  where x.Masach.Equals(g.Key)
                                                  select x.Tensach).FirstOrDefault()
                                   };       
                var _Soluongcon = from p in _Soluongsachnhap
                                  from q in _Soluongsachxuat
                                  where p.Masach.Equals(q.Masach)
                                  select new
                                  {
                                      p.Masach,
                                      soluong = p.soluong - q.soluong,
                                      Tensach = (from x in model.Sach
                                                 where x.Masach.Equals(p.Masach)
                                                 select x.Tensach).FirstOrDefault()
                                  };
                var _Soluongchuaxuat = from p in _Soluongsachnhap
                                       where !_Soluongsachxuat.Any(x => (x.Masach == p.Masach))
                                       select new
                                       {
                                           p.Masach,
                                           soluong = p.soluong,
                                           Tensach = (from q in model.Sach
                                                      where q.Masach.Equals(p.Masach)
                                                      select q.Tensach).FirstOrDefault()
                                       };
                foreach (var row in _Soluongcon)
                {
                    DSCT _dsct = new DSCT();
                    _dsct.Masach = row.Masach;
                    _dsct.Tensach = row.Tensach;
                    _dsct.soluong = row.soluong;
                    List.Add(_dsct);
                }
                    foreach (var row in _Soluongchuaxuat)
                    {
                        DSCT _dsct = new DSCT();
                        _dsct.Masach = row.Masach;
                        _dsct.Tensach = row.Tensach;
                        _dsct.soluong = row.soluong;
                        List.Add(_dsct);
                    }               
                     
            return List;
        }
    }
}
