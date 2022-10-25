using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorViewV1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            ViewBag.Message = "This view is loaded from database!";
            var x = Request.QueryString["id"]?.ToString();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [OutputCache(Location = System.Web.UI.OutputCacheLocation.Server, Duration = 3600)]
        public ActionResult ClearCache()
        {
            ViewBag.Message = "Your application description page.";

            return Json("Cleared Cache", JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}