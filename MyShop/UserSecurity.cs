using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductDataAccess;

namespace MyShop
{
    public class UserSecurity
    {
        public static bool Login(string username,string password)
        {
            using (ShopDBEntities db = new ShopDBEntities())
            {
                
                return db.KHACHHANGs.Any(x=>x.Taikhoan.Equals(username,StringComparison.OrdinalIgnoreCase) &&
                 x.Matkhau==password);
            }
        }
    }
}