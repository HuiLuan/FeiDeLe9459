using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentScoreManagement
{
    public partial class Left : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Util.CurrentStudent.Name.ToLower() != "admin")
            {
                HyperLink1.Visible = false;
                HyperLink2.Visible = false;
            }
            else
            {
                HyperLink1.Visible = true;
                HyperLink2.Visible = true;
            }
        }
    }
}