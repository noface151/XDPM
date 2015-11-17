using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDaiLy
    {
        public static Daily Laydailytheoma(string maDaily)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var DaiLySelected = (from p in model.Daily
                               where p.Madaily.Trim().Equals(maDaily)
                               select p).FirstOrDefault();
            return DaiLySelected;
        }
        public static List<Daily> loadDaily()
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<Daily> List = new List<Daily>();
            var daily = from p in model.Daily
                      select p;
            return List = daily.ToList();
        }
        public static bool AddDaily(Daily daily)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            try
            {
                model.Daily.Add(daily);
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool UpdateDaily(Daily daily)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var _daily = (from p in model.Daily
                        where p.Madaily.Trim().Equals(daily.Madaily)
                        select p).FirstOrDefault();
            if (_daily == null)
                return false;
            else
            {
                _daily.Tendaily = daily.Tendaily;
                _daily.Diachi = daily.Diachi;
                _daily.SDT = daily.SDT;
                model.SaveChanges();
                return true;
            }
        }
        public static int SoluongDaily()
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            var count = (from p in model.Daily
                         select p).Count();
            return count;
        }
        public static List<SearchDaily> LayDaiLytheoTimKiem(SearchDaily serach)
        {
            DBQLPhatHanhSachEntities model = new DBQLPhatHanhSachEntities();
            List<SearchDaily> ListSearch = new List<SearchDaily>();
            var _daily = (from p in model.Daily
                        select p);
            if(serach.Madaily!="")
            {
                _daily = _daily.Where(q => q.Madaily.Trim().Equals(serach.Madaily));
            }
            if (serach.notu != 0 && serach.noden != 0)
            {
                _daily = _daily.Where(q => q.No >= serach.notu && q.No <= serach.noden);
            }
            else if (serach.notu != 0 && serach.noden == 0)
            {
                _daily = _daily.Where(q => q.No >= serach.notu);
            }
            else if (serach.notu == 0 && serach.noden != 0)
            {
                _daily = _daily.Where(q => q.No <= serach.noden);
            }
            foreach (var row in _daily)
            {
                SearchDaily _Search = new SearchDaily();
                _Search.Tendaily = row.Tendaily.Trim();
                _Search.Madaily = row.Madaily.Trim();
                _Search.Duong = row.Diachi.Trim();
                _Search.Quan = row.Diachi.Trim();
                ListSearch.Add(_Search);
            }
            return ListSearch;
        }
    }
}
