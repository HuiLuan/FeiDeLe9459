using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentScoreManagement.Models;

namespace StudentScoreManagement
{

    public class Util
    {

        public static Student CurrentStudent
        {
            get { return HttpContext.Current.Session["CurrentStudent"] as Student; }
        }
    }
}