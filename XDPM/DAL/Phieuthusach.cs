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
    
    public partial class Phieuthusach
    {
        public Phieuthusach()
        {
            this.TTbansachDL = new HashSet<TTbansachDL>();
        }
    
        public string Maphieuthu { get; set; }
        public string Madaily { get; set; }
        public System.DateTime Ngaythu { get; set; }
        public long Tongtien { get; set; }
    
        public virtual Daily Daily { get; set; }
        public virtual ICollection<TTbansachDL> TTbansachDL { get; set; }
    }
}
