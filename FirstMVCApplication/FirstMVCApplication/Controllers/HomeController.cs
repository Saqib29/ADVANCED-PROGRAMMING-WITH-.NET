using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(Request.HttpMethod == "GET")
            {
                return View();
            }
            return Content(Request["name"]);
        }

        public ActionResult Another()
        {
            return Content("It works!!");
        }
    }
}