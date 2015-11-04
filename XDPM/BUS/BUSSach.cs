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
        public string MaSachTuDong()
        {
            int tongSoluong = DALSach.layTongSLSach()+1;
            string Masach="SA"+tongSoluong.ToString();           
            return Masach;
        }
        public string ConvertString(string text)
        {
            for (int i = 33; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 58; i < 65; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 91; i < 97; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 123; i < 127; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");

            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);

            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public List<Sach> timkiemSach(string Tensach,string MaNXB, string MaTheLoai, long giatu, long giaden)
        {
            string SearchText = ConvertString(Tensach).ToLower();
            List<Sach> ListSearch;
            if(Tensach!="")
            {
                ListSearch = DALSach.LaySachTheoTimKiem(MaNXB, MaTheLoai, giatu, giaden).FindAll(delegate(Sach sach)
                {
                    if (ConvertString(sach.Tensach).ToLower().Contains(SearchText))
                        return true;
                    else return false;
                });
            }
            else
            {
                ListSearch = DALSach.LaySachTheoTimKiem(MaNXB, MaTheLoai, giatu, giaden);
            }
            return ListSearch;
        }
    }
}
