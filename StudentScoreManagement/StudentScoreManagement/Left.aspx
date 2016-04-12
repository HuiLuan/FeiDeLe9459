<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Left.aspx.cs" Inherits="StudentScoreManagement.Left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color: #507CD1">
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="HyperLink1" runat="server" Target="rightFrame" NavigateUrl="~/ScoreEdit.aspx">New StudentScore</asp:HyperLink>
        </div>
        <br/>
     <div>
        <asp:HyperLink ID="HyperLink2" runat="server" Target="rightFrame" NavigateUrl="~/ScoreList.aspx">View StudentScore</asp:HyperLink>
    </div>
    </form>
</body>
</html>
