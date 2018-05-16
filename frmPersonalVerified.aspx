<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonalVerified.aspx.cs" Inherits="frmPersonalVerified" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/frmMain.aspx"><font color="black" size="2" style="text-align:center"><strong><font color="blue" face="Comic Sans MS" size="4">
    Cool</font><font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font face="Comic Sans MS"
        size="4"> <font color="#993366">Productions</font>, Inc.</font></strong> </font> </asp:HyperLink>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Information To Submit"></asp:Label>
        <asp:TextBox ID="txtVerifiedInfo" runat="server" Height="80px" Width="400px" TextMode="MultiLine"></asp:TextBox>
        <asp:Button ID="btnViewPersonnel" runat="server" Text="View Personnel" 
            PostBackUrl="~/frmViewPersonnel.aspx" Width="95px" />
    </div>
    </form>
</body>
</html>