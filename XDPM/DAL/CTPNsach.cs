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
    
    public partial class CTPNsach
    {
        public string MaPN { get; set; }
        public string Masach { get; set; }
        public int Soluong { get; set; }
        public long Gia { get; set; }
    
        public virtual PNsach PNsach { get; set; }
        public virtual Sach Sach { get; set; }
    }
}