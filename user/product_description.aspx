<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="product_description.aspx.cs" Inherits="user_product_description" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder1" Runat="Server">

   
     <asp:Repeater ID="repeater1" runat="server">
       <HeaderTemplate>
       </HeaderTemplate>
        <ItemTemplate>
          
         <div style="height:300px; width:600px; border-style:solid; border-width:1px;">

          <div style="height:300px; width:200px; border-style:solid; border-width:1px; float:left;">
              <img src='../<%# Eval("product_images")%>' height="300" width="200" alt=""/>
          </div>
          <div style="height:300px; width:395px; border-style:solid; border-width:1px; float:left;">
             item name= <%# Eval("product_name")%> <br />
             product description= <%# Eval("product_desc")%><br />
             product price= <%# Eval("product_price")%><br />
             product quantity= <%# Eval("product_qty")%>
          </div>

         </div>

        </ItemTemplate>
       <FooterTemplate>
       </FooterTemplate>
    </asp:Repeater>
    <br />

   <table>
       <tr>
           <td><asp:Label ID="label2" runat="server" text="Enter quantity"></asp:Label></td>
           <td><asp:TextBox ID="textbox1" runat="server" text=""></asp:TextBox></td>
           <td><asp:Button ID="button1" runat="server" Text="Add to cart" OnClick="button1_Click" /></td>
       </tr>
       <tr>
           <td colspan="3">
               <asp:Label ID="label1" runat="server" ForeColor="Red" Text=""></asp:Label>
           </td>
       </tr>
   </table>

</asp:Content>

