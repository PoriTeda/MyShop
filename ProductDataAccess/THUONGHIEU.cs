//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class THUONGHIEU
    {
        public THUONGHIEU()
        {
            this.MATHANGs = new HashSet<MATHANG>();
        }
    
        public int MaTH { get; set; }
        public string TenTH { get; set; }
        public string Diachi { get; set; }
        public string DienThoai { get; set; }
    
        public virtual ICollection<MATHANG> MATHANGs { get; set; }
    }
}
