using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorViewV1.Controllers
{
    public class RenderRazorController : Controller
    {
        // GET: RenderRazor
        public ActionResult Index()
        {



            return View();
        }
        public ActionResult ContactUs()
        {
            //Guid guid = new Guid(id);

            //ViewBag.Message = "This view is loaded from database!";
            
            return View();
        }
        public JsonResult JsonReq()
        {
            //Guid guid = new Guid(id);

            //ViewBag.Message = "This view is loaded from database!";

            return Json(new {Value = 1}, JsonRequestBehavior.AllowGet);
        }
    }
}