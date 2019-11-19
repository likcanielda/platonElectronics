<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="add_category.aspx.cs" Inherits="admin_add_category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder1" Runat="Server">
     <br />
<table>
    <tr>
        <td> Enter Category Name &nbsp; </td> 
       
        <td><asp:TextBox ID="textbox1" runat="server"></asp:TextBox>  &nbsp;</td>
         <td colspan="2" align="center" >
            <asp:Button ID="button1" runat="server" Text="Add Category" OnClick="button1_Click" />
        </td>
    </tr>
</table>
    <br />
    <hr />
  
    <h4>Product Categories</h4>
    <asp:DataList ID="datalist1" runat="server">
        <HeaderTemplate>
            <table>
        </HeaderTemplate>

        <ItemTemplate>
            <tr>
                <td><%#Eval("product_category") %></td>
                <td>
                    <a href="delete_category.aspx?category=<%#Eval("product_category") %>">Delete</a>
                </td>
            </tr>
        </ItemTemplate>
        
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:DataList>

</asp:Content>

