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
                    long id;
                    if (long.TryParse(Request.QueryString["id"],out id))
                    {
                        ViewState["mId"] = id;
                    }
                    else
                    {
                        ViewState["mId"] = 0;
                    }
                }
                return Convert.ToInt64(ViewState["mId"]);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Util.CurrentStudent == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {

                BindView();
                if (mId > 0)
                {
                    AppToUi();
                }
            }
        }

        private void AppToUi()
        {
           var  mScore = SqlHelper.QueryStudentScore( mId,null).FirstOrDefault();
            ddlCourse.Enabled = false;
            ddlStudent.Enabled = false;
            if (mScore != null)
            {
                ddlCourse.Text = mScore.Course;
                ddlStudent.Text = mScore.Student.Name;
                txtScore.Text = mScore.Score;
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
            var StudentId = Convert.ToInt64(ddlStudent.SelectedValue);
            var Course = ddlCourse.Text;
            var Score = txtScore.Text;
            if (mId > 0)
            {
                string sql = "update StudentScore set Score='" + txtScore.Text + "' where Id='" + mId + "'";
                SqlHelper.Execute(sql);
                HHWeb.Alert(this,"save succeed");
            }
            else
            {
                string sql = "insert into StudentScore (StudentId,Course,Score) values ('"+ StudentId + "','"+ Course + "','"+ Score + "')";
                SqlHelper.Execute(sql);
                HHWeb.Alert(this, "save succeed");
            }
        }
    }
}