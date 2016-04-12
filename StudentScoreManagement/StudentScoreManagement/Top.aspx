<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Top.aspx.cs" Inherits="StudentScoreManagement.Top" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color: #0E97E6">
    <form id="form1" runat="server">
    <div style="float: right">
    <% =StudentName  %>
        <a href="Login.aspx" target="_parent">Logout</a>
<%--          <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>--%>
    </div>
    </form>
</body>
</html>
