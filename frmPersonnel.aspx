<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnel.aspx.cs" Inherits="frmPersonnel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
</head>
 
<body>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/frmMain.aspx"><font color="black" size="2" style="text-align:center"><strong><font color="blue" face="Comic Sans MS" size="4">
    Cool</font><font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font face="Comic Sans MS"
        size="4"> <font color="#993366">Productions</font>, Inc.</font></strong> </font> </asp:HyperLink>

     <form id="form1" runat="server">
<asp:Panel ID="Panel1" runat="server" Height="250px" HorizontalAlign="Left" 
         Width="500px">
    <asp:Label ID="lblError" runat="server" ForeColor="#CC0000"></asp:Label>
    <br/>
         <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
     <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txtFirstName" ErrorMessage="First Name Is Required"></asp:RequiredFieldValidator>
         <br/>
     <asp:Label ID="Label2" runat="server" Text="Last Name:" width="71px"></asp:Label>
     <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txtLastName" ErrorMessage="Last Name Is Required"></asp:RequiredFieldValidator>
     <br />
     <asp:Label ID="Label3" runat="server" Text="Pay Rate:" width="71px"></asp:Label><asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ControlToValidate="txtPayRate" ErrorMessage="PayRate Is Required "></asp:RequiredFieldValidator>
     <br />
     
     <asp:Label ID="Label4" runat="server" Text="Start Date:" width="71px"></asp:Label>
     <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="txtStartDate" 
        ErrorMessage="Date Must Be In mm/dd/yyyy Format" 
        ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
     <br />
     <asp:Label ID="Label5" runat="server" Text="End Date:" width="71px"></asp:Label>
     <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
     <asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
        runat="server" ControlToValidate="txtEndDate" 
        ErrorMessage="Date Must Be In mm/dd/yyyy Format " 
        ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
     <br />
     <asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click" />

    </asp:Panel>
     
    </form>
</body>
</html>