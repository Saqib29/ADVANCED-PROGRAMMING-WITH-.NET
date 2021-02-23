using DbFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DbFirstApproach.Controllers
{
    public class ProductController : Controller
    {
        InventoryDbContext context = new InventoryDbContext();
        public ActionResult Index()
        {
            return View(context.Products.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.categories = context.Categories.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.categories = context.Categories.ToList();
            return View(context.Products.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            product.ProductId = id;
            context.Entry(product).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(context.Products.Find(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            context.Products.Remove(context.Products.Find(id));
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Top()
        {
            //var list = context.Products.OrderByDescending(x => x.Price).Take(2).ToList();
            var list = from item in context.Products orderby item.Price descending select item;
            return View(list.Take(2));
        }
    }
}