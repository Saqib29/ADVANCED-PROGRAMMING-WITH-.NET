using classPerformance1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace classPerformance1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Form form)
        {
            if(form.Name == null)
            {
                TempData["name"] = "Please enter your full name";
                return RedirectToAction("Index");
            }
            if (form.Username == null)
            {
                TempData["username"] = "Please enter a username";
                return RedirectToAction("Index");
            }
            if(form.Password == null)
            {
                TempData["password"] = "Please Enter password";
                return RedirectToAction("Index");
            }
            if (form.ConfirmPassword == null)
            {
                TempData["confirmPassword"] = "Enter password again to confirm";
                return RedirectToAction("Index");
            }
            if(form.Password != form.ConfirmPassword)
            {
                TempData["password"] = "Password doesn't matched!";
                return RedirectToAction("Index");
            }
            if (form.DateOfBirth == null)
            {
                TempData["dateofbirth"] = "Date of birth required";
                return RedirectToAction("Index");
            }
            if (form.Gender == null)
            {
                TempData["gender"] = "Select gender";
                return RedirectToAction("Index");
            }
            if (form.BloodGroup == null)
            {
                TempData["bloodGroup"] = "Required Blood Group";
                return RedirectToAction("Index");
            }
            try
            {
                if(form.ProfilePicture.ContentLength > 0)
                {
                    
                    string path = Path.Combine(Server.MapPath("~/UploadedFiles/"), form.ProfilePicture.FileName);
                    form.ProfilePicture.SaveAs(path);
                }
            }
            catch
            {
                TempData["image"] = "File upload failed";
                return RedirectToAction("Index");
            }

            return View("Result", form);
        }
    }
}