<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="update_order_details.aspx.cs" Inherits="user_update_order_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder1" Runat="Server">
    <table>

         <tr>
            <td>Firstname</td>
            <td>
               <asp:TextBox ID="textbox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Lastname</td>
            <td>
               <asp:TextBox ID="textbox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Address</td>
            <td>
               <asp:TextBox ID="textbox3" runat="server" Height="61px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Country</td>
            <td>
               <asp:TextBox ID="textbox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>City</td>
            <td>
               <asp:TextBox ID="textbox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Phone number</td>
            <td>
               <asp:TextBox ID="textbox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
               <asp:Button ID="button1" runat="server" Text="Update and continue" OnClick="button1_Click"/>
            </td>
        </tr>
        </table>
</asp:Content>

