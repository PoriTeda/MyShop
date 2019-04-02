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

        public ActionResult Index()
        {
            
            Session["Username"] = user;
            return View();
            
        }

        

    }
}
