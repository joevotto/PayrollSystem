<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="frmLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style1">
        <div class="style1">
     <img src="images/CoolBiz_Productions_logo.JPG" align="middle" alt="Coolbiz" />
        </div>
        <asp:Login ID="Login1" runat="server" align="center" DestinationPageUrl="~/frmMain.aspx" 
        
            TitleText="Please enter your UserName and Password in order to log into the system" 
            onauthenticate="Login1_Authenticate">
        </asp:Login>
    </div>
    </form>
</body>
</html>