//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sach
    {
        public Sach()
        {
            this.CTPNsach = new HashSet<CTPNsach>();
            this.CTPXsach = new HashSet<CTPXsach>();
            this.CTphieuchiNXB = new HashSet<CTphieuchiNXB>();
            this.TTbansachDL = new HashSet<TTbansachDL>();
            this.CTPhieuDat = new HashSet<CTPhieuDat>();
        }
    
        public string Masach { get; set; }
        public string MaNXB { get; set; }
        public string MaTheLoai { get; set; }
        public string Tensach { get; set; }
        public string Tacgia { get; set; }
        public long GiaBan { get; set; }
        public int SoLuong { get; set; }
        public long GiaNhap { get; set; }
    
        public virtual ICollection<CTPNsach> CTPNsach { get; set; }
        public virtual ICollection<CTPXsach> CTPXsach { get; set; }
        public virtual ICollection<CTphieuchiNXB> CTphieuchiNXB { get; set; }
        public virtual Nhaxuatban Nhaxuatban { get; set; }
        public virtual TheLoai TheLoai { get; set; }
        public virtual ICollection<TTbansachDL> TTbansachDL { get; set; }
        public virtual ICollection<CTPhieuDat> CTPhieuDat { get; set; }
    }
}
