<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmManageUsers.aspx.cs" Inherits="frmAddUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align= "center">
        x<img src="images/CoolBiz_Productions_logo.JPG" align="middle" alt="Coolbiz" />

    <br />
        <asp:Label ID="lblUser" runat="server" align="center" Text="User Name: "></asp:Label>  
        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPass" runat="server" Text="Password: " height="19px" 
            width="77px"></asp:Label> 
        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
       
        <br />
    <asp:DropDownList ID="comboSecurityLevel" runat="server">
        <asp:ListItem>A</asp:ListItem>
        <asp:ListItem>U</asp:ListItem>
    </asp:DropDownList>
    <br />
     <asp:Button runat="server" Text="Add User" ID="btnAddUser" 
            onclick="btnAddUser_Click" />
        <br />
        <asp:Label ID="lblErrorMessage" runat="server" Text=" "></asp:Label>
        
  </div>
  <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" align= "center" runat="server" 
        DataSourceID="SqlDataSource1">
    </asp:GridView>
       </form>
</body>
</html>