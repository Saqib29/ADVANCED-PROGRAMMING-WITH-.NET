using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? id)
        {
            return RedirectToAction("Another", new { id });
        }
        public ActionResult Another(int? id)
        {
            //return Content("From another method: " + id);
            return RedirectToAction("MyMethod", "Person");
        }
    }
}