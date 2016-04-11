using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentScoreManagement
{
    public partial class Top : System.Web.UI.Page
    {
        public string StudentName { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentName = Util.CurrentStudent.Name;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Util.CurrentStudent.Name = null;
            Response.Redirect("Login.aspx");
        }
    }
}