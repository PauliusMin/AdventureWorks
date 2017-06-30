using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorks.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is exciting story of brave young man Paulius Minkevičius adventures going into the deep & dark forest of SQL in the dangerous MVC valley.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "To simply wake up every morning a better person than when I went to bed. Sidney Poitier.";

            return View();
        }
    }
}