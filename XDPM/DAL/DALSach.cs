using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSach
    {
        public static bool AddSach(Sach sach)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            try
            {
                model.Sach.Add(sach);
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool UpdateSach(Sach sach)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var SachSelected = (from p in model.Sach
                                where p.Masach.Trim().Equals(sach.Masach.Trim())
                                select p).FirstOrDefault();
            if (SachSelected == null)
                return false;
            else
            {
                SachSelected.MaNXB = sach.MaNXB;
                SachSelected.MaTheLoai = sach.MaTheLoai;
                SachSelected.Tensach = sach.Tensach;
                SachSelected.Tacgia = sach.Tacgia;
                SachSelected.GiaBan = sach.GiaBan;
                model.SaveChanges();
                return true;
            }
        }
        public static Sach LaySachTheoTen(string tensach)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var SachSelected = (from p in model.Sach
                                where p.Tensach.Trim().Equals(tensach)
                                select p).FirstOrDefault();
            return SachSelected;
        }
        public static Sach LaySachTheoMa(string masach)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var SachSelected = (from p in model.Sach
                                where p.Masach.Trim().Equals(masach)
                                select p).FirstOrDefault();
            return SachSelected;
        }
        public static int layTongSLSach()
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var count = (from p in model.Sach
                         select p).Count();
            return count;
        }
        public static List<Sach> LayDSSach()
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<Sach> ListSach;
            var DSSach = from p in model.Sach
                         select p;
            return  ListSach = DSSach.ToList();
        }
        public static List<Sach>LaySachTheoTimKiem(string MaNXB,string MaTheLoai,long giatu,long giaden)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<Sach> ListSearch;
            var DSSach = (from p in model.Sach
                          select p);
            if(MaNXB!="")
            {
                DSSach = DSSach.Where(q => q.MaNXB.Trim().Equals(MaNXB));
            }
            if(MaTheLoai!="")
            {
                DSSach = DSSach.Where(q => q.MaTheLoai.Trim().Equals(MaTheLoai));
            }
            if(giatu!=0&&giaden!=0)
            {
                DSSach = DSSach.Where(q => q.GiaBan >= giatu && q.GiaBan <= giaden);
            }
            if(giatu!=0&&giaden==0)
            {
                DSSach = DSSach.Where(q => q.GiaBan >= giatu);
            }
            if(giatu==0&&giaden!=0)
            {
                DSSach = DSSach.Where(q => q.GiaBan <= giaden);
            }
            ListSearch = DSSach.ToList();
            return ListSearch;
        }
        
    }
}
