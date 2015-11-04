using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DALNXB
    {
       public static Nhaxuatban LayNXBtheoten(string tenNXB)
       {
           DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
           var NXBSelected = (from p in model.Nhaxuatban
                                  where p.TenNXB.Trim().Equals(tenNXB)
                                  select p).FirstOrDefault();
           return NXBSelected;
       }
       public static List<String> layTenNXB()
       {
           DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
           List<String> tenNXB;
           var ten = from p in model.Nhaxuatban
                     select p.TenNXB;
           return tenNXB = ten.ToList();
       }
       public static Nhaxuatban LayNXBtheoma(string maNXB)
       {
           DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
           var NXBSelected = (from p in model.Nhaxuatban
                              where p.MaNXB.Trim().Equals(maNXB)
                              select p).FirstOrDefault();
           return NXBSelected;
       }
    }
}
