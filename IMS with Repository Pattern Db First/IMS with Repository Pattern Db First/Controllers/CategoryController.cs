using IMS_with_Repository_Pattern_Db_First.Models;
using IMS_with_Repository_Pattern_Db_First.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMS_with_Repository_Pattern_Db_First.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public ActionResult Index()
        {
            return View(categoryRepository.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryRepository.Insert(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var getCategory = categoryRepository.Get(id);
            return View(getCategory);
        }
        [HttpPost]
        public ActionResult Edit(int id, Category category)
        {
            
            //categoryRepository.Get(id).CategoryName = category.CategoryName;
            categoryRepository.Update(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var categoryToDelete = categoryRepository.Get(id);
            return View(categoryToDelete);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Confirm(int id)
        {
            categoryRepository.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var details = categoryRepository.Get(id);
            return View(details);
        }
    }
}