using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSNXB
    {
        SearchNXB Search;
        public BUSNXB(SearchNXB Search)
        {
            this.Search = Search;
        }
        public BUSNXB() { }
        public string MaNXBtudong()
        {
            string MANXB = "NXB" + (DALNXB.SoluongNXB() + 1).ToString();
            return MANXB;
        }
        public List<SearchNXB> timkiemNXB()
        {
            HotroTimKiemTheoTen convert = new HotroTimKiemTheoTen();
            string SearchTenNXB = convert.ConvertString(Search.TenNXB).ToLower();
            string SearchDuong = convert.ConvertString(Search.Duong).ToLower();
            string SearchQuan = convert.ConvertString(Search.Quan).ToLower();
            List<SearchNXB> ListSearch=DALNXB.LayNXBtheoTimKiem(Search);
            if(Search.TenNXB!="")
            {
                ListSearch = ListSearch.FindAll(delegate(SearchNXB NXB)
                {
                    if (convert.ConvertString(NXB.TenNXB).ToLower().Contains(SearchTenNXB))
                        return true;
                    else return false;
                });
            }
            if(Search.Duong!="")
            {
                ListSearch = ListSearch.FindAll(delegate(SearchNXB NXB)
                {
                    if (convert.ConvertString(NXB.Duong).ToLower().Contains(SearchDuong))
                        return true;
                    else return false;
                });
            }
            if(Search.Quan!="")
            {
                ListSearch = ListSearch.FindAll(delegate(SearchNXB NXB)
                {
                    if (convert.ConvertString(NXB.Duong).ToLower().Contains(SearchQuan))
                        return true;
                    else return false;
                });
            }
            return ListSearch;
        }
    }
}
