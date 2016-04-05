﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StudentScoreManagement.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-top: 100px;"></div>
        <div class="container form-horizontal">

            <div class="form-group row">
                <label class="control-label col-md-4">Name</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtName" CssClass="form-control text-box single-line" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="form-group row">
                <label class="control-label col-md-4">Password</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtPassword"  CssClass="form-control text-box single-line" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label class="control-label col-md-4"></label>
                <div class="col-md-4">
                    <asp:Button ID="btnLogin" CssClass="btn btn-info" runat="server" Text="Login" OnClick="btnLogin_Click"  />
                </div>
            </div>

        </div>
    </form>
</body>
</html>