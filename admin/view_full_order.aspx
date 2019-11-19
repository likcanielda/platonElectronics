<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="view_full_order.aspx.cs" Inherits="admin_view_full_order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder1" Runat="Server">
    <h4>Client details</h4>
     <asp:Repeater ID="repeater2" runat="server">
       <HeaderTemplate>
           <table border="1">
               <tr style="background-color:gray; color:white; text-align:center">
                   <td>ID</td>
                   <td>Firstname</td>
                   <td>Lastname</td>
                   <td>Email</td>
                   <td>Address</td>
                   <td>Country</td>
                   <td>City</td>
                   <td>Postal Code</td>
                   <td>Mobile</td>

               </tr>
       </HeaderTemplate>
        <ItemTemplate>
       <tr>
           <td><%#Eval("id") %></td>
           <td><%#Eval("firstname") %></td>
           <td><%#Eval("lastname") %></td>
           <td><%#Eval("email") %></td>
           <td><%#Eval("address") %></td>
           <td><%#Eval("country") %></td>
           <td><%#Eval("city") %></td>
           <td><%#Eval("postal_code") %></td>
           <td><%#Eval("mobile") %></td>        
       </tr>
        </ItemTemplate>
       <FooterTemplate>
           </table>
       </FooterTemplate>
    </asp:Repeater>
    <br /> 

    <h4>Orders</h4>
     <asp:Repeater ID="repeater1" runat="server">
       <HeaderTemplate>
           <table border="1">
               <tr style="background-color:gray; color:white; text-align:center">
                   <td>Product Image</td>
                   <td>Product Name</td>
                   <td>Product Price</td>
                   <td>Product QTY</td>
               </tr>
       </HeaderTemplate>
        <ItemTemplate>
       <tr style="text-align:center">
           <td><img src="../<%#Eval("product_images") %>" height="100" width="100" /></td>
           <td><%#Eval("product_name") %></td>
           <td><%#Eval("product_price") %></td>
           <td><%#Eval("product_qty") %></td>
       </tr>
        </ItemTemplate>
       <FooterTemplate>
           </table>
       </FooterTemplate>
    </asp:Repeater>
    <asp:Label ID="label1" runat="server" Text=""></asp:Label>
</asp:Content>

