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
    
    public partial class XUHUONG
    {
        public XUHUONG()
        {
            this.MATHANGs = new HashSet<MATHANG>();
        }
    
        public int XuHuongId { get; set; }
        public string XuHuongNam { get; set; }
    
        public virtual ICollection<MATHANG> MATHANGs { get; set; }
    }
}