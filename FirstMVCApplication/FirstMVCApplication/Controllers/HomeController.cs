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
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // Retrieve the value from the request
        // 1. Request
        // 2. Using parameters
        // 3. FormCollection
        // 4. Model binding
        
        [HttpPost]
        //public ActionResult Index(string name, double salary)
        public ActionResult Index(Person person)
        {
            //return Content(Request["name"]);
            //return Content(name + " -> " + salary);
            //return Content(collection["name"] + " -> " + collection["salary"]);

            return Content(person.Name + " -> " + person.Salary);
        }

        public ActionResult Another()
        {
            return Content("It works!!");
        }
    }
}