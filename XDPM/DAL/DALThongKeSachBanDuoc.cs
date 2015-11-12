using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALThongKeSachBanDuoc
    {
        public static List<ThongKeSachBanDuoc> ThongKe(ThongKeSachBanDuoc tk)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<ThongKeSachBanDuoc> List=new List<ThongKeSachBanDuoc>();
            if (tk.Tungay != null && tk.Dengay != null&&tk.MaDaiLy==null)
            {
                var sachbanduoc = (from p in model.Phieuthusach
                               from q in model.TTbansachDL
                               where p.Ngaythu >= tk.Tungay && p.Ngaythu <= tk.Dengay
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
                    ThongKeSachBanDuoc _tk = new ThongKeSachBanDuoc();
                    _tk.Tensach = row.Tensach;
                    _tk.soluong = row.soluong;
                    List.Add(_tk);
                }
            }
            else if(tk.MaDaiLy!=null&&tk.Tungay==null&&tk.Dengay==null)
            {
                var sachbanduoc = (from p in model.Phieuthusach
                                   from q in model.TTbansachDL
                                   where p.Madaily.Equals(tk.MaDaiLy)
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
                    ThongKeSachBanDuoc _tk = new ThongKeSachBanDuoc();
                    _tk.Tensach = row.Tensach;
                    _tk.soluong = row.soluong;
                    List.Add(_tk);
                }
            }
            else if(tk.MaDaiLy!=null&&tk.Tungay!=null&&tk.Dengay!=null)
            {
                var sachbanduoc = (from p in model.Phieuthusach
                                   from q in model.TTbansachDL
                                   where p.Madaily.Equals(tk.MaDaiLy)
                                   where p.Ngaythu >= tk.Tungay && p.Ngaythu <= tk.Dengay
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
                    ThongKeSachBanDuoc _tk = new ThongKeSachBanDuoc();
                    _tk.Tensach = row.Tensach;
                    _tk.soluong = row.soluong;
                    List.Add(_tk);
                }
            }
            return List;
        }
    }
}
