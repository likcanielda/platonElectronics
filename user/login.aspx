<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="user_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder1" Runat="Server">
    <table>

         <tr>
            <td>Enter email</td>
            <td>
               <asp:TextBox ID="textbox1" runat="server" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Enter password</td>
            <td>
               <asp:TextBox ID="textbox2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td colspan="2" align="center">
                <asp:Button ID="button1" runat="server" text="Login" OnClick="button1_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="label1" runat="server" text=""></asp:Label>
            </td>
        </tr>

    </table>
</asp:Content>

