using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index(int? id)
        //{
        //    return RedirectToAction("Another", new { id });
        //}
        //public ActionResult Another(int? id)
        //{
        //    //return Content("From another method: " + id);
        //    return RedirectToAction("MyMethod", "Person");
        //}

        // Data passing technique from controler to view
        //1. Session
        //2. ViewData
        //3. ViewBag
        //4. TempData
        //5. Model(ViewModel/DataModel)

        public ActionResult Index()
        {
            //Session["name"] = "Saqib";
            //Session["rank"] = 1;

            //ViewData["name"] = "Saqib Aminul";

            //ViewBag.name = "Aminul Islam Saqib";
            //ViewBag.id = "17-34879-2";

            TempData["name"] = "Saqib";

            //return View();
            return RedirectToAction("Another");
        }

        public ActionResult Another()
        {
            //return View("Index");
            return RedirectToAction("Another2");
        }

        public ActionResult Another2()
        {
            return View("Index");
        }
    }
}