﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dapper;

namespace StudentScoreManagement
{
    public partial class Regist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber.Text.Trim()))
            {
                HHWeb.Alert(this, "Number can not empty");
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                HHWeb.Alert(this,"Name can not empty");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                HHWeb.Alert(this,"Password can not empty");
                return;
            }
            var sql = "insert into Student (Name,Password,Number) values ('" + txtName.Text.Trim() + "','" + txtPassword.Text.Trim() + "','"+txtNumber.Text+"' )";
            SqlHelper.Execute(sql);
            HHWeb.Alert(this, "register succeed");
        }
    }
}