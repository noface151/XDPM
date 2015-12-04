using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALThongKeSachBanDuoc
    {
        public static List<DTOSach> ThongKe(string MaDaiLy,DateTime? Tungay,DateTime? Dengay)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<DTOSach> List=new List<DTOSach>();
            if (Tungay != null && Dengay != null&& MaDaiLy=="")
            {
                var sachbanduoc = (from p in model.Phieuthusach
                               from q in model.TTbansachDL
                               where p.Ngaythu >= Tungay && p.Ngaythu <= Dengay
                               where q.Maphieuthu.Equals(p.Maphieuthu)
                               group q by q.Masach into g
                               select new
                               {
                                   Masach = g.Key,
                                   Tensach = (from p in model.Sach
                                              where p.Masach.Equals(g.Key)
                                              select p.Tensach).FirstOrDefault(),
                                   soluong = g.Sum(x => x.Soluong)
                               });
                foreach(var row in sachbanduoc)
                {
                    DTOSach _tk = new DTOSach();
                    _tk.Tensach = row.Tensach;
                    _tk.soluong = row.soluong;
                    List.Add(_tk);
                }
            }
            else if(MaDaiLy!=null&&Tungay==null&&Dengay==null)
            {
                var sachbanduoc = (from p in model.Phieuthusach
                                   from q in model.TTbansachDL
                                   where p.Madaily.Equals(MaDaiLy)
                                   where q.Maphieuthu.Equals(p.Maphieuthu)
                                   group q by q.Masach into g
                                   select new
                                   {
                                       Masach = g.Key,
                                       Tensach = (from p in model.Sach
                                                  where p.Masach.Equals(g.Key)
                                                  select p.Tensach).FirstOrDefault(),
                                       soluong = g.Sum(x => x.Soluong)
                                   });
                foreach (var row in sachbanduoc)
                {
                    DTOSach _tk = new DTOSach();
                    _tk.Tensach = row.Tensach;
                    _tk.soluong = row.soluong;
                    List.Add(_tk);
                }
            }
            else if(MaDaiLy!=null&&Tungay!=null&&Dengay!=null)
            {
                var sachbanduoc = (from p in model.Phieuthusach
                                   from q in model.TTbansachDL
                                   where p.Madaily.Equals(MaDaiLy)
                                   where p.Ngaythu >= Tungay && p.Ngaythu <= Dengay
                                   where q.Maphieuthu.Equals(p.Maphieuthu)
                                   group q by q.Masach into g
                                   select new
                                   {
                                       Masach = g.Key,
                                       Tensach = (from p in model.Sach
                                                  where p.Masach.Equals(g.Key)
                                                  select p.Tensach).FirstOrDefault(),
                                       soluong = g.Sum(x => x.Soluong)
                                   });
                foreach (var row in sachbanduoc)
                {
                    DTOSach _tk = new DTOSach();
                    _tk.Tensach = row.Tensach;
                    _tk.soluong = row.soluong;
                    List.Add(_tk);
                }
            }
            return List;
        }
    }
}
