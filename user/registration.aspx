<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="user_registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder1" Runat="Server">

    <table>

        <tr>
            <td>Firstname</td>
            <td style="width: 143px">
               <asp:TextBox ID="textbox1" runat="server" Width="139px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Lastname</td>
            <td style="width: 143px">
               <asp:TextBox ID="textbox2" runat="server" Width="140px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Email</td>
            <td style="width: 143px">
               <asp:TextBox ID="textbox3" runat="server" TextMode="Email" Width="141px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Password</td>
            <td style="width: 143px">
               <asp:TextBox ID="textbox4" runat="server" TextMode="Password" Width="141px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Address</td>
            <td style="width: 143px">
               <asp:TextBox ID="textbox5" runat="server" Height="61px" TextMode="MultiLine" Width="140px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Country</td>
            <td style="width: 143px">
               <asp:TextBox ID="textbox6" runat="server" Width="140px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>City</td>
            <td style="width: 143px">
               <asp:TextBox ID="textbox7" runat="server" Width="140px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Postal Code</td>
            <td style="width: 143px">
               <asp:TextBox ID="textbox8" runat="server" Width="141px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Phone number</td>
            <td style="width: 143px">
               <asp:TextBox ID="textbox9" runat="server" Width="141px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
               <asp:Button ID="button1" runat="server" Text="Register" OnClick="button1_Click" Width="78px"/>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="label1" runat="server" text=""></asp:Label>
            </td>
        </tr>

    </table>

</asp:Content>

