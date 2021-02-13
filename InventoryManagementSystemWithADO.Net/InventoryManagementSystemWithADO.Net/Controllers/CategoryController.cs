using InventoryManagementSystemWithADO.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystemWithADO.Net.Controllers
{
    public class CategoryController : Controller
    {
        CategoryModel categoryModel = new CategoryModel();
        public ActionResult Index()
        {
            return View(categoryModel.GetCategories());
        }
    }
}