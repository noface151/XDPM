using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSach
    {
        public string Tensach;
        public string Masach;
        public string MaNXB;
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
                SachSelected.GiaNhap = sach.GiaNhap;
                model.SaveChanges();
                return true;
            }
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
            List<Sach> List = new List<Sach>(); 
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var sach = from p in model.Sach
                       select p;
            return List=sach.ToList(); ;
        }
        public static List<SearchSach>LaySachTheoTimKiem(SearchSach Search)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<SearchSach> ListSearch=new List<SearchSach>();
            var DSSach = (from p in model.Sach
                          select p);
            if(Search.Masach!="")
            {
                DSSach = DSSach.Where(q => q.Masach.Trim().Equals(Search.Masach));
            }
            if(Search.MaNXB!="")
            {
                DSSach = DSSach.Where(q => q.MaNXB.Trim().Equals(Search.MaNXB));
            }
            if(Search.MaTheLoai!="")
            {
                DSSach = DSSach.Where(q => q.MaTheLoai.Trim().Equals(Search.MaTheLoai));
            }
            //giá bán
            if (Search.giatu != 0 && Search.giaden != 0)
            {
                DSSach = DSSach.Where(q => q.GiaBan >= Search.giatu && q.GiaBan <= Search.giaden);
            }
            if (Search.giatu != 0 && Search.giaden == 0)
            {
                DSSach = DSSach.Where(q => q.GiaBan >= Search.giatu);
            }
            if (Search.giatu == 0 && Search.giaden != 0)
            {
                DSSach = DSSach.Where(q => q.GiaBan <= Search.giaden);
            }
            //giá nhập
            if (Search.gianhaptu != 0 && Search.gianhapden != 0)
            {
                DSSach = DSSach.Where(q => q.GiaNhap >= Search.gianhaptu && q.GiaNhap <= Search.gianhapden);
            }
            if (Search.gianhaptu != 0 && Search.gianhapden == 0)
            {
                DSSach = DSSach.Where(q => q.GiaNhap >= Search.gianhaptu);
            }
            if (Search.gianhaptu == 0 && Search.gianhapden != 0)
            {
                DSSach = DSSach.Where(q => q.GiaNhap <= Search.gianhapden);
            }
           foreach(var row in DSSach)
           {
               SearchSach _SearchSach = new SearchSach();
               _SearchSach.Masach = row.Masach;
               _SearchSach.Tensach = row.Tensach;
               ListSearch.Add(_SearchSach);
           }
           return ListSearch;
        }
        public static List<String> laytensach()
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<String> ListTenSach = new List<String>();
            var tensach = from p in model.Sach
                          select p.Tensach;
            foreach(var row in tensach)
            {
                ListTenSach.Add(row);
            }
            return ListTenSach;
        }
    }
}
