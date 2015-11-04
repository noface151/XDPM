using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DALTheLoai
    {
       public static TheLoai LayTheLoaiTheoTen(string TenTheLoai)
       {
           DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
           var TheLoaiSelected = (from p in model.TheLoai
                                  where p.TenTheLoai.Trim().Equals(TenTheLoai)
                                  select p).FirstOrDefault();
           return TheLoaiSelected;
       }
       public static List<String> layTenTheLoai()
       {
           DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
           List<String> tentheloai;
           var ten = from p in model.TheLoai
                     select p.TenTheLoai;
           return tentheloai = ten.ToList();
       }
       public static TheLoai LayTheLoaiTheoMa(string MaTheLoai)
       {
           DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
           var TheLoaiSelected = (from p in model.TheLoai
                                  where p.MaTheLoai.Trim().Equals(MaTheLoai)
                                  select p).FirstOrDefault();
           return TheLoaiSelected;
       }
    }
}
