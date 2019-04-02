using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    [Serializable]
    public class Product
    {
        public string ProId { get; set; }
        public string ProName { get; set; }
        public string CateId { get; set; }
    }
}