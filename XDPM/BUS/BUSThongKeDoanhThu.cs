using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BUS
{
    public class BUSThongKeDoanhThu
    {
        string loaibaocao;

        public string Loaibaocao
        {
            get { return loaibaocao; }
            set { loaibaocao = value; }
        }
        string mota;
        DateTime tungay;
        DateTime denngay;

        public DateTime Denngay
        {
            get { return denngay; }
            set { denngay = value; }
        }
        public DateTime Tungay
        {
            get { return tungay; }
            set { tungay = value; }
        }
        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }
        public BUSThongKeDoanhThu() { }
        public string VietBaoCao()
        {
            ReportDocument rd = new ReportDocument();
            if (Loaibaocao == "Thống kê chi")
            {
                string path = Directory.GetCurrentDirectory() + @"\Thống kê chi";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                try
                {
                    rd.Load(Directory.GetCurrentDirectory()+ @"\CrystalReportThongKeDoanhThu.rpt");
                    rd.SetDataSource(DALThongKeDoanhThu.ListSachChi(Tungay, Denngay));
                    path = path + @"\" + Mota + ".pdf";
                    rd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path);
                    return path;
                }
                catch
                {
                    return path = "";
                }
            }
            else
            {
                string path = Directory.GetCurrentDirectory() + @"\Thống kê thu";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                try
                {
                    rd.Load(Directory.GetCurrentDirectory() + @"\REPORT\CrystalReportThongKeThu.rpt");
                    rd.SetDataSource(DALThongKeDoanhThu.ListSachthu(Tungay, Denngay));
                    path = path + @"\" + Mota + ".pdf";
                    rd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path);
                    return path;
                }
                catch { return path = ""; }
            }
        }
    }
}
