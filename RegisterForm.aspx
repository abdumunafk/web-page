<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="WebApplication1.RegisterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Usernmae"></asp:Label>
            <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="TxtConfirmPassword" runat="server" TextMode="Password" ></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label4" runat="server" Text="Mobile Number"></asp:Label>
            <asp:TextBox ID="TxtMobileNumber" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label5" runat="server" Text="Mail"></asp:Label>
            <asp:TextBox ID="TxtMail" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="BtnRegister" runat="server" Text="Register" OnClick="BtnRegister_Click" />
        </div>
            </center>
    </form>
</body>
</html>
