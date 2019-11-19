<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminlogin.aspx.cs" Inherits="admin_adminlogin" %>

<!DOCTYPE html>
<html >
  <head>
    <meta charset="UTF-8">
    <title>Admin Login</title>
    
    
    
    
        <link rel="stylesheet" href="logincss/style.css">

    
    
    
    
  </head>

  <body>

    
<form id="form1" runat="server">
  <header>Login</header>
  <label>Username <span>*</span></label>
  <asp:TextBox ID="username" runat="server"></asp:TextBox>
  <label>Password <span>*</span></label>
  <asp:TextBox ID="password" runat="server"></asp:TextBox>
   <br /> <br />


  <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click"/>
    <br />
    <asp:Label ID="label1" runat="server" Text=""></asp:Label>
    <br />
    <br />
</form>
            
  </body>
</html>
    
