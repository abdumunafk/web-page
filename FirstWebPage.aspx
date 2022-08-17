<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstWebPage.aspx.cs" Inherits="WebApplication1.FirstWebPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <%--<center>
           <div>
           <asp:Label ID="LblErrorMsg" runat="server" Text="Label"></asp:Label>
               </div>
           </center>--%>
        <center>
        <div>
            welcome to Login Page
            <br /><br/>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox>
            
            <%--<asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="Please enter your username"></asp:RequiredFieldValidator>--%>
           <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
          
            <%--<asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Please enter your password"></asp:RequiredFieldValidator>--%>
          <br /><br />
            <asp:Button ID="BtnSubmit" runat="server" Text="Sign-In" OnClick="BtnSubmit_Click" Width="89px" />
            <br /><br />
             <asp:Button ID="BtnSignUp" runat="server" Text="Sign-Up" OnClick="BtnSubmit_Click" Width="96px" />
            <br /><br />
            <asp:Label ID="lblstatus" runat="server" Text="Label" Visible="False"></asp:Label>
            
              </div>
            </center>
    </form>
</body>
</html>






