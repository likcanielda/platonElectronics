<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="add_product.aspx.cs" Inherits="admin_add_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder1" Runat="Server">

    <h3> Add Product Page</h3>
    <table >
        <tr>
            <td>Product Name</td>
            <td><asp:TextBox ID="textbox1" runat="server"></asp:TextBox></td>
        </tr>

         <tr>
            <td>Product Description</td>
            <td><asp:TextBox ID="textbox2" runat="server"></asp:TextBox></td>
        </tr>

         <tr>
            <td>Product Price</td>
            <td><asp:TextBox ID="textbox3" runat="server"></asp:TextBox></td>
        </tr>

         <tr>
            <td>Product Quantity</td>
            <td><asp:TextBox ID="textbox4" runat="server"></asp:TextBox></td>
        </tr>
         <tr >
            <td>Product Image</td>
            <td>
            <asp:FileUpload ID="fileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Select Category</td>
            <td>
                <asp:DropDownList ID="dropdownlist1" runat="server"></asp:DropDownList>
            </td>
        </tr>
         <tr>
            <td colspan="2" align="center">
                <asp:Button ID="button1" runat="server" Text="Upload" OnClick="button1_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>

