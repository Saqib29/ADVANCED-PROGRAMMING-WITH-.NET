using IMS_with_Repository_Pattern_Db_First.Models;
using IMS_with_Repository_Pattern_Db_First.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMS_with_Repository_Pattern_Db_First.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository productRepository = new ProductRepository();
        CategoryRepository categoryRepository = new CategoryRepository();
        public ActionResult Index()
        {
            return View(productRepository.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.categories = categoryRepository.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            productRepository.Insert(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.categories = categoryRepository.GetAll();
            return View(productRepository.Get(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            productRepository.Update(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(productRepository.Get(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            productRepository.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(productRepository.Get(id));
        }
    }
}