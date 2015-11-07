using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DALNXB
    {
 
       public static Nhaxuatban LayNXBtheoma(string maNXB)
       {
           DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
           var NXBSelected = (from p in model.Nhaxuatban
                              where p.MaNXB.Trim().Equals(maNXB)
                              select p).FirstOrDefault();
           return NXBSelected;
       }
       public static List<Nhaxuatban> loadNXB()
       {
           DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
           List<Nhaxuatban> List = new List<Nhaxuatban>();
           var nxb = from p in model.Nhaxuatban
                     select p;
           return List =nxb.ToList();
       }
    }
}
