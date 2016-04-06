using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreManagement.Models;

namespace StudentScoreManagement
{
    public partial class ScoreEdit : System.Web.UI.Page
    {
        
        private long mId {
            get
            {
                if (ViewState["mId"] == null)
                {
                    
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindView();
            }
        }

        private void BindView()
        {
            var students= SqlHelper.Query<Student>("select * from Student where Name<>'admin' order by Name");
            foreach (Student student in students)
            {
                ddlStudent.Items.Add(new ListItem(student.Name,student.Id.ToString()));
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}