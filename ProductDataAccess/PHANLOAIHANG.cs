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
    
    public partial class PHANLOAIHANG
    {
        public PHANLOAIHANG()
        {
            this.MATHANGs = new HashSet<MATHANG>();
        }
    
        public int MaLoai { get; set; }
        public string TenLoaiHang { get; set; }
    
        public virtual ICollection<MATHANG> MATHANGs { get; set; }
    }
}