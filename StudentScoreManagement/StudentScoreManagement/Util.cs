using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentScoreManagement.Models;

namespace StudentScoreManagement
{

    public class Util
    {
       // [ThreadStatic]
        static Student mCurrentStudent;
        public static Student CurrentStudent
        {
            get { return mCurrentStudent; }
            set { mCurrentStudent = value; }
        }

    }
}