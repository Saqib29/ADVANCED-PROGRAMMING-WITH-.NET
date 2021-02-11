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
        public ActionResult Index(Person person, Product product)
        {
            //return Content(Request["name"]);
            //return Content(name + " -> " + salary);
            //return Content(collection["name"] + " -> " + collection["salary"]);

            return Content(person.Name + " -> " + person.Salary + " | " + product.ProductName + " -> " + product.Price);
        }

        public ActionResult Another()
        {
            return Content("It works!!");
        }
    }
}