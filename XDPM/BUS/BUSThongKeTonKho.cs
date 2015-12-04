using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace BUS
{
    public class BUSThongKeTonKho
    {
        string mota;

        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }
        DateTime tungay;

        public DateTime Tungay
        {
            get { return tungay; }
            set { tungay = value; }
        }
        DateTime denngay;

        public DateTime Denngay
        {
            get { return denngay; }
            set { denngay = value; }
        }
        public BUSThongKeTonKho() { }
        public string VietBaoCao()
        {
            ReportDocument rd = new ReportDocument();
            string path = Directory.GetCurrentDirectory() + @"\Thống kê tồn kho";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            try
            {
                rd.Load(Directory.GetCurrentDirectory() + @"\REPORT\CrystalReportThongKeTonKho.rpt");
                rd.SetDataSource(DALThongKeTonKho.ThongKe(Tungay, Denngay));
                path = path + @"\" + Mota + ".pdf";
                rd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path);
                return path;
            }
            catch
            {
                return path = "";
            }
        }
    }
}
