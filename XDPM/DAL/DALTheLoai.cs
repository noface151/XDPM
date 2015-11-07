using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DALTheLoai
    {
      public static List<TheLoai> DsTheLoai()
       {
           DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
          List<TheLoai> List=new List<TheLoai>();
          var _theloai = from p in model.TheLoai
                         select p;
          List = _theloai.ToList();
          return List;
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
