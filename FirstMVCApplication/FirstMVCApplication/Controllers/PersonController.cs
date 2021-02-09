using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class PersonController : Controller
    {
        public string Index()
        {
            return "Hello, from Index of Person Controller";
        }

        public string MyMethod()
        {
            return "Hello, From MyMethod of Person Controller";
        }
    }
}