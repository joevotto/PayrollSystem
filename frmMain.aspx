<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <img src="images/CoolBiz_Productions_logo.JPG" align="middle" alt="Coolbiz" />
    <asp:LinkButton ID="btnCalcSalary" runat="server" 
        PostBackUrl="~/frmSalaryCalculator.aspx">Salary Calculator</asp:LinkButton>
     <asp:ImageButton ID="imgBtnCalculator" runat="server" 
        ImageUrl="~/images/Calculator.png" PostBackUrl="~/frmSalaryCalculator.aspx" 
        height="48px" width="48px" />
   <asp:LinkButton ID="btnAddEmp" runat="server" PostBackUrl="~/frmPersonnel.aspx" 
        Visible="False">Add New Employee</asp:LinkButton>
    <asp:ImageButton ID="imgBtnNewEmployee" runat="server" ImageUrl="images/plus.png" 
        height="48px" width="48px" PostBackUrl="~/frmPersonnel.aspx" 
        Visible="False" />
    <asp:LinkButton ID="lblBtnUserActivity" runat="server" 
        PostBackUrl="~/frmUserActivity.aspx"
        Visible="False">User Activity</asp:LinkButton>
    <asp:ImageButton ID="imgBtnUserActivity" runat="server" 
        ImageUrl="~/activitylinkbtn.jpg" height="48px" 
        PostBackUrl="~/frmUserActivity.aspx" width="48px" Visible="False" />
    <asp:LinkButton ID="lblBtnViewPersonnel" runat="server" 
        PostBackUrl="~/frmViewPersonnel.aspx"> View Personnel</asp:LinkButton>
    <asp:ImageButton ID="imgBtnViewPersonnel" runat="server" 
        ImageUrl="~/images/personnel.jpg" PostBackUrl="~/frmViewPersonnel.aspx" 
        height="48px" width="48px"/>
    <asp:LinkButton ID="btnSearchPersonnel" runat="server" 
        PostBackUrl="~/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
    <asp:ImageButton ID="imgBtnSearchPersonnel" runat="server" 
        PostBackUrl="~/frmSearchPersonnel.aspx" ImageUrl="~/images/personnelsearch.jpg" 
        height="48px" width="48px" /> 
        
    <asp:LinkButton ID="LinkButton1" runat="server" 
        PostBackUrl="~/frmEditPersonnel.aspx" Visible="False">Edit Employees</asp:LinkButton> 
    <asp:ImageButton
        ID="imgBtnEditEmployees" runat="server" height="48px" 
        ImageUrl="~/images/edit.jpg" PostBackUrl="~/frmEditPersonnel.aspx" 
        width="48px" Visible="False" />
    <asp:LinkButton ID="btnManageUsers" runat="server" 
        PostBackUrl="~/frmManageUsers.aspx" Visible="False">Manage Users</asp:LinkButton>
    <asp:ImageButton ID="imgManageUsers" runat="server" height="48px" 
        ImageUrl="~/images/add-user.png" PostBackUrl="~/frmManageUsers.aspx" 
        width="48px" Visible="False" />
    </form>
</body>
</html>