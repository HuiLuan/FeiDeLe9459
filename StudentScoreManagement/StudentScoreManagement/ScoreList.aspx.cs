﻿using System;
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
            if (Util.CurrentStudent == null)
            {
                Response.Write("<script> window.parent.location.href='Login.aspx'</script>");
                return;
            }

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
            if (Util.CurrentStudent.Name == "admin")
            {
                if (ddlStudent.SelectedValue == "")
                {
                    GridView1.DataSource = SqlHelper.QueryStudentScore(null, null); 
                }
                else
                {
                    GridView1.DataSource = SqlHelper.QueryStudentScore(null, Convert.ToInt64(ddlStudent.SelectedValue)); 
                }
            }
            else
            {
                GridView1.DataSource = SqlHelper.QueryStudentScore(null, Util.CurrentStudent.Id);
                GridView1.Columns[5].Visible = false;
                GridView1.Columns[6].Visible = false;
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
            BindGridView();
        }
    }
}