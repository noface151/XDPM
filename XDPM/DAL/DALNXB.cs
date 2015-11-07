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
       public static bool AddNXB(Nhaxuatban nxb)
       {
           DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
           try
           {
               model.Nhaxuatban.Add(nxb);
               model.SaveChanges();
               return true;
           }
           catch
           {
               return false;
           }
       }
       public static bool UpdateNXB(Nhaxuatban nxb)
       {
           DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
           var _nxb = (from p in model.Nhaxuatban
                       where p.MaNXB.Trim().Equals(nxb.MaNXB)
                       select p).FirstOrDefault();
           if (_nxb == null)
               return false;
           else
           {
               _nxb.TenNXB = nxb.TenNXB;
               _nxb.Diachi = nxb.Diachi;
               _nxb.SDT = nxb.SDT;
               _nxb.Sotaikhoan = _nxb.Sotaikhoan;
               model.SaveChanges();
               return true;
           }
       }
       public static int SoluongNXB()
       {
           DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
           var count = (from p in model.Nhaxuatban
                        select p).Count();
           return count;
       }
       public static List<SearchNXB> LayNXBtheoTimKiem(SearchNXB serach)
       {
           DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
           List<SearchNXB> ListSearch = new List<SearchNXB>();
           var _NXB = (from p in model.Nhaxuatban
                      select p);
           if(serach.notu!=0&&serach.noden!=0)
           {
               _NXB = _NXB.Where(q => q.No >= serach.notu && q.No <= serach.noden);
           }
           else if(serach.notu!=0&&serach.noden==0)
           {
               _NXB = _NXB.Where(q => q.No >= serach.notu );
           }
           else if (serach.notu == 0 && serach.noden != 0)
           {
               _NXB = _NXB.Where(q => q.No <= serach.noden);
           }
           foreach (var row in _NXB)
           {
               SearchNXB _Search = new SearchNXB();
               _Search.TenNXB = row.TenNXB.Trim();
               _Search.MaNXB = row.MaNXB.Trim();
               _Search.Duong = row.Diachi.Trim();
               _Search.Quan = row.Diachi.Trim();
               ListSearch.Add(_Search);
           }
           return ListSearch;
       }
    }
}
