using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentScoreManagement.Models
{
    public class Student
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }
    }
}