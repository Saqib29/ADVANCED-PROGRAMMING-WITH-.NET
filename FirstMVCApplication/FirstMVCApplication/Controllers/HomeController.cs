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
            return RedirectToAction("Another");
        }
        public ActionResult Another()
        {
            return Content("From another method");
        }
    }
}