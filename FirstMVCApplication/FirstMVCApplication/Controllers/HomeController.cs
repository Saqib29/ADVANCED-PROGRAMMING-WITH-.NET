using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            Person person = new Person() { Name = "Saqib Aminul", Id = "17-34879-2" };

            //person.Name = "Saqib Aminul Islam";
            //person.Id = "17-34879-2";

            return View(person);
            //return RedirectToAction("Another");
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