using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALThongKeDoanhThu
    {
        public static List<DSCT> ListSachChi(DateTime tungay,DateTime denngay)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<DSCT> List=new List<DSCT>();
            var _sachchi = from p in model.PhieuchiNXB
                           from q in model.CTphieuchiNXB
                           where p.Ngay >= tungay && p.Ngay <= denngay
                           where q.Maphieuchi.Equals(p.Maphieuchi)
                           group q by q.Masach into g
                           select new
                           {
                               Masach = g.Key,
                               Tensach = (from p in model.Sach
                                          where p.Masach.Equals(g.Key)
                                          select p.Tensach).FirstOrDefault(),
                               Tienchi = g.Sum(x => x.Tienchi)
                           };
            foreach(var row in _sachchi)
            {
                DSCT _dsct = new DSCT();
                _dsct.Tensach = row.Tensach;
                _dsct.Tienchi = row.Tienchi;
                List.Add(_dsct);
            }
            return List;
        }
        public static List<DSCT> ListSachthu(DateTime tungay,DateTime denngay)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<DSCT> List = new List<DSCT>();
            var _sachthu = from p in model.Phieuthusach
                           from q in model.TTbansachDL
                           where p.Ngaythu >= tungay && p.Ngaythu <= denngay
                           where q.Maphieuthu.Equals(p.Maphieuthu)
                           group q by q.Masach into g
                           select new
                           {
                               Masach = g.Key,
                               Tensach = (from p in model.Sach
                                          where p.Masach.Equals(g.Key)
                                          select p.Tensach).FirstOrDefault(),
                               Tienthu = g.Sum(x => x.Tienthu)
                           };
            foreach (var row in _sachthu)
            {
                DSCT _dsct = new DSCT();
                _dsct.Tensach = row.Tensach;
                _dsct.Tienthu = row.Tienthu;
                List.Add(_dsct);
            }
            return List;
        }
    }
}
