using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductDataAccess;
using System.Threading;

namespace MyShop.Controllers
{
    public class HomeController : Controller
    {
        private ShopDBEntities db = new ShopDBEntities();
        public ActionResult Index()
        {
            return View();   
        }

        public PartialViewResult GetAll()
        {
            System.Threading.Thread.Sleep(1000);
            List<MATHANG> model = db.MATHANGs.OrderByDescending(x => x.Ngaycapnhat).Skip(8).Take(10).ToList();
            return PartialView("_Products", model);
        }

        public PartialViewResult GetWomen()
        {
            System.Threading.Thread.Sleep(1000);
            List<MATHANG> model = db.MATHANGs.Where(x=>x.MaLoai==2 ||x.MaLoai==4).OrderByDescending(x => x.Ngaycapnhat).ToList();
            return PartialView("_Products", model);
        }

        public PartialViewResult GetMen()
        {
            System.Threading.Thread.Sleep(1000);
            List<MATHANG> model = db.MATHANGs.Where(x => x.MaLoai == 1 || x.MaLoai == 3).OrderByDescending(x => x.Ngaycapnhat).ToList();
            return PartialView("_Products", model);
        }

        

        [HttpPost]
        public PartialViewResult GetAll(string searchTerm)
        {
            List<MATHANG> products;
            if (string.IsNullOrEmpty(searchTerm))
            {
                products = db.MATHANGs.ToList();
            }
            else
            {
                products = db.MATHANGs.Where(x => x.TenHang.StartsWith(searchTerm)).ToList();
            }
            return PartialView("_Products", products);
        }

        public JsonResult GetProducts(string term)
        {
            List<string> products = db.MATHANGs.Where(s => s.TenHang.StartsWith(term))
                .Select(x => x.TenHang).ToList();
            return Json(products, JsonRequestBehavior.AllowGet);
        }
        

    }
}
