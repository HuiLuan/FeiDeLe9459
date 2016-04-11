using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreManagement.Models;

namespace StudentScoreManagement
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var student = SqlHelper.Query<Student>("select * from Student where Name='"+txtName.Text+"' and Password='"+txtPassword.Text+"'").FirstOrDefault();
            if (student == null)
            {
                HHWeb.Alert(this, "Incorrect username or password.");
                return;
            }
            Util.CurrentStudent = student;

            Response.Redirect("Main.aspx");
//            if (student.Name.ToLower() == "admin")
//            {
//
//            }
//            else
//            {
//                
//            }

        }
    }
}