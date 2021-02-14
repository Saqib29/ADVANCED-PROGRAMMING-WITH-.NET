using InventoryManagementSystemWithADO.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystemWithADO.Net.Controllers
{
    public class ProductController : Controller
    {
        ProductModel productModel = new ProductModel();
        public ActionResult Index()
        {
            return View(productModel.GetProducts());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            productModel.Insert(product);
            return RedirectToAction("Index", "Product");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(productModel.getProduct(id));
        }
        [HttpPost]
        public ActionResult Edit(int id,Product product)
        {
            product.ProductId = id;
            productModel.Update(product);
            return RedirectToAction("Index", "Product");
            //return Content(product.ProductName +"   "+product.ProductId);

        }
        public ActionResult Delete(int id)
        {
            productModel.Delete(id);
            return RedirectToAction("Index", "Product");
        }
    }
}