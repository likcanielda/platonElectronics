<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="display_order.aspx.cs" Inherits="admin_display_order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder1" Runat="Server">
    <h4>Total Orders:</h4>
    <asp:Label ID="label1" runat="server"></asp:Label>
    <br />
    <hr />
    <h4>Total Orders Per Country:</h4>
    <label>Enter country name </label>
    <asp:TextBox ID="textbox1" runat="server"></asp:TextBox>
    <asp:Button ID="button_total" runat="server" Text="Get Total" OnClick="button_total_Click" />
    <br />
    <asp:Label ID="label2" runat="server" ></asp:Label>
    <br />
    <hr />
    <h4>Orders</h4>
    <asp:Repeater ID="repeater1" runat="server">
       <HeaderTemplate>
           <table border="1">
               <tr style="background-color:gray; color:white; text-align:center">
                   <td>ID</td>
                   <td>Firstname</td>
                   <td>Lastname</td>
                   <td>Country</td>
                   <td>City</td>
                   <td>Postal Code</td>
                   <td>Order</td>
                   <td>Delete</td>
               </tr>
       </HeaderTemplate>
        <ItemTemplate>
       <tr>
           <td><%#Eval("id") %></td>
           <td><%#Eval("firstname") %></td>
           <td><%#Eval("lastname") %></td>
           <td><%#Eval("country") %></td>
           <td><%#Eval("city") %></td>
           <td><%#Eval("postal_code") %></td>
           <td><a href="view_full_order.aspx?id=<%#Eval("id") %>">View full order</a></td>
           <td><a href="delete_order.aspx?id=<%#Eval("id") %>">Delete Order</a></td>
       </tr>
        </ItemTemplate>
       <FooterTemplate>
           </table>
       </FooterTemplate>
    </asp:Repeater>
</asp:Content>

