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
    public class BUSThongKeSachBan
    {
        string motafile;
        DateTime? tungay;
        DateTime? denngay;
        string madaily;

        public string Madaily
        {
            get { return madaily; }
            set { madaily = value; }
        }

        public DateTime? Denngay
        {
            get { return denngay; }
            set { denngay = value; }
        }

        public DateTime? Tungay
        {
            get { return tungay; }
            set { tungay = value; }
        }

        public string Motafile
        {
            get { return motafile; }
            set { motafile = value; }
        }
        public BUSThongKeSachBan() { }
        public string ThongKeSachBan()
        {
            ReportDocument rd = new ReportDocument();
            string path = Directory.GetCurrentDirectory() + @"\Thống kê sách bán được";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            try
            {
                rd.Load(Directory.GetCurrentDirectory() + @"\REPORT\CrystalReportThongKeBanDuoc.rpt");
                rd.SetDataSource(DALThongKeSachBanDuoc.ThongKe(Madaily, Tungay, Denngay));
                path = path + @"\" + Motafile + ".pdf";
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
