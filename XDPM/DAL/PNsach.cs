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
    
    public partial class PNsach
    {
        public PNsach()
        {
            this.CTPNsach = new HashSet<CTPNsach>();
        }
    
        public string MaPN { get; set; }
        public string MaNXB { get; set; }
        public System.DateTime Ngaynhap { get; set; }
        public string Nguoigiao { get; set; }
        public long Tongtien { get; set; }
    
        public virtual ICollection<CTPNsach> CTPNsach { get; set; }
        public virtual Nhaxuatban Nhaxuatban { get; set; }
    }
}