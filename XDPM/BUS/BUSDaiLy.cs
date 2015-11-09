using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSDaiLy
    {
        SearchDaily Search;
        public BUSDaiLy(SearchDaily Search) { this.Search = Search; }
        public BUSDaiLy() { }
        public string MaDaiLy()
        {
            return "DL" + (DALDaiLy.SoluongDaily() + 1).ToString();
        }
        public List<SearchDaily> timkiemNXB()
        {
            HotroTimKiemTheoTen convert = new HotroTimKiemTheoTen();
            string SearchTenDaily = convert.ConvertString(Search.Tendaily).ToLower();
            string SearchDuong = convert.ConvertString(Search.Duong).ToLower();
            string SearchQuan = convert.ConvertString(Search.Quan).ToLower();
            List<SearchDaily> ListSearch = DALDaiLy.LayDaiLytheoTimKiem(Search);
            if (Search.Tendaily != "")
            {
                ListSearch = ListSearch.FindAll(delegate(SearchDaily daily)
                {
                    if (convert.ConvertString(daily.Tendaily).ToLower().Contains(SearchTenDaily))
                        return true;
                    else return false;
                });
            }
            if (Search.Duong != "")
            {
                ListSearch = ListSearch.FindAll(delegate(SearchDaily daily)
                {
                    if (convert.ConvertString(daily.Duong).ToLower().Contains(SearchDuong))
                        return true;
                    else return false;
                });
            }
            if (Search.Quan != "")
            {
                ListSearch = ListSearch.FindAll(delegate(SearchDaily daily)
                {
                    if (convert.ConvertString(daily.Duong).ToLower().Contains(SearchQuan))
                        return true;
                    else return false;
                });
            }
            return ListSearch;
        }
    }
}
