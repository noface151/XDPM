using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Text.RegularExpressions;

namespace BUS
{
    public class BUSSach
    {
        SearchSach Search;
        public BUSSach(SearchSach Search)
        {
            this.Search = Search;
        }
        public BUSSach() { }
        public string MaSachTuDong()
        {
            int tongSoluong = DALSach.layTongSLSach()+1;
            string Masach="SA"+tongSoluong.ToString();           
            return Masach;
        }   
        public List<SearchSach> timkiemSach()
        {
            HotroTimKiemTheoTen convert = new HotroTimKiemTheoTen();
            string SearchText =convert.ConvertString(Search.Tensach).ToLower();
            List<SearchSach> ListSearch;
            if(Search.Tensach!="")
            {
                ListSearch = DALSach.LaySachTheoTimKiem(Search).FindAll(delegate(SearchSach sach)
                {
                    if (convert.ConvertString(sach.Tensach).ToLower().Contains(SearchText))
                        return true;
                    else return false;
                });
            }
            else
            {
                ListSearch = DALSach.LaySachTheoTimKiem(Search);
            }
            return ListSearch;
        }
    }
}
