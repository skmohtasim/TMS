using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssetTrackingApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name)
        {

            return View();
        }

        public ActionResult JqueryWorkout()
        {
            
            return View();
        }

        public JsonResult Ajax()
        {
            return Json(new { id = 1, value = "new" },JsonRequestBehavior.AllowGet);
        }
    }
}