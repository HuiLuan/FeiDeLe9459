<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScoreList.aspx.cs" Inherits="StudentScoreManagement.ScoreList" %>

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
    <div class="container">
    <div class="row">
        
        <asp:Panel ID="panelSearch" runat="server">
             Student:<asp:DropDownList ID="ddlStudent" runat="server"></asp:DropDownList>
        <asp:Button ID="btnSearch" CssClass="btn btn-info" runat="server" Text="Search" OnClick="btnSearch_Click" />
        </asp:Panel>
       
    </div>
    <div class="row" style="margin-top: 20px;">
        <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView1_RowDeleting">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="Name" HeaderText="Student" />
                <asp:BoundField DataField="Course" HeaderText="Course" />
                <asp:BoundField DataField="Score" HeaderText="Score" />
                <asp:HyperLinkField DataNavigateUrlFields="Id" HeaderText="Edit" NavigateUrl="~/ScoreEdit.aspx?id={0}"  Text="Edit" />
                <asp:TemplateField ShowHeader="False" HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" OnClientClick="return confirm('confirm delete?')" Text="删除"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
    </div>
    </form>
</body>
</html>
