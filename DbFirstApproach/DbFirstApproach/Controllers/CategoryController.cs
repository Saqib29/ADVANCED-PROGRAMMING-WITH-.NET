using DbFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DbFirstApproach.Controllers
{
    public class CategoryController : Controller
    {
        InventoryDbContext context = new InventoryDbContext();
        public ActionResult Index()
        {
            return View(context.Categories.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var categoryToEdit = context.Categories.Find(id);
            return View(categoryToEdit);
        }
        [HttpPost]
        public ActionResult Edit(int id, Category category)
        {
            category.CategoryId = id;
            var categoryToEdit = context.Categories.Find(id);
            categoryToEdit.CategoryName = category.CategoryName;
            context.SaveChanges();

            //context.Entry(category).State = System.Data.Entity.EntityState.Modified;

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var categoryToDelete = context.Categories.Find(id);
            return View(categoryToDelete);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            context.Categories.Remove(context.Categories.Find(id));
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var categoryOfDetails = context.Categories.Find(id);
            return View(categoryOfDetails);
        }
    }
}