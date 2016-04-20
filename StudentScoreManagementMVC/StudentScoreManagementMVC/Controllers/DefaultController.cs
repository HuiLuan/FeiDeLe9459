using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using StudentScoreManagementMVC.Models;

namespace StudentScoreManagementMVC.Controllers
{
    public class DefaultController : Controller
    {
        AppDbContext db=new AppDbContext();
        // GET: Default

        //        public ActionResult Index()
        //        {
        //            return View();
        //        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(Student student)
        {
            
            return RedirectToAction("Index", "StudentScore");
        }



        [AllowAnonymous]
        public ActionResult Signup()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Signup(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return View();
        }

        [AllowAnonymous]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Default");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}