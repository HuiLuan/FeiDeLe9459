<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScoreEdit.aspx.cs" Inherits="StudentScoreManagement.ScoreEdit" %>

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
    <div class="container form-horizontal">
        <div style="margin-top: 100px;"></div>
     <div class="form-group row">
                <label class="control-label col-md-4">Student Name</label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlStudent" CssClass="form-control valid" runat="server"></asp:DropDownList>
                </div>
            </div>
        
             <div class="form-group row">
                <label class="control-label col-md-4">Course</label>
                <div class="col-md-4">
                      <asp:DropDownList ID="ddlCourse" CssClass="form-control valid" runat="server">
                          <asp:ListItem>information system</asp:ListItem>
                          <asp:ListItem>computer science</asp:ListItem>
                          <asp:ListItem>computer game design</asp:ListItem>
                          <asp:ListItem>computer system security</asp:ListItem>
                      </asp:DropDownList>
                </div>
            </div>
        
               <div class="form-group row">
                <label class="control-label col-md-4">Score</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtScore" CssClass="form-control text-box single-line" runat="server"></asp:TextBox>
                </div>
            </div>
        
             <div class="form-group row">
                <label class="control-label col-md-4"></label>
                <div class="col-md-4">
                    <asp:Button ID="btnSave" runat="server" CssClass="btn btn-info" Text="Save" OnClick="btnSave_Click" />
                </div>
            </div>

    </div>
    </form>
</body>
</html>
