using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreManagement.Models;

namespace StudentScoreManagement
{
    public partial class ScoreList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Util.CurrentStudent.Name.ToLower() != "admin")
            {
                panelSearch.Visible = false;
            }
            else
            {
                panelSearch.Visible = true;
            }
            if (!IsPostBack)
            {
                BindGridView();

                ddlStudent.Items.Add(new ListItem("",""));
               var students = SqlHelper.Query<Student>("select * from Student where Name<>'admin' order by Name");
                foreach (Student student in students)
                {
                    ddlStudent.Items.Add(new ListItem(student.Name, student.Id.ToString()));
                }
            }

        }

        private void BindGridView()
        {

            if (ddlStudent.SelectedItem.Value == "")
            {
                GridView1.DataSource = SqlHelper.QueryStudentScore(null); ;
            }
            else
            {
                GridView1.DataSource = SqlHelper.QueryStudentScore(Convert.ToInt64(ddlStudent.SelectedItem.Value)); ;
            }
          
            GridView1.DataKeyNames=new string[] {"Id"};
           GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            var id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            var sql = "delete from StudentScore where Id='" + id + "'";
            SqlHelper.Execute(sql);
            BindGridView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (ddlStudent.SelectedValue != "")
            {

            }
        }
    }
}