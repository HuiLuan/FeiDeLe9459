using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentScoreManagementMVC.Controllers
{
    public class StudentScoreController : Controller
    {
        // GET: StudentScore
        public ActionResult Index()
        {
            return View();
        }
    }
}