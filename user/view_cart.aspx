<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="view_cart.aspx.cs" Inherits="user_view_cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder1" Runat="Server">
        <div>
        <asp:DataList ID="d1" runat="server">
            <HeaderTemplate>
                <table border="1">
                    <tr align="center" style="background-color:silver; color:white; font-weight:bold">
                        <td>product image</td>
                        <td>product name</td>
                        <td>product description</td>
                        <td>product price</td>
                        <td>product quantity</td>
                        <td>delete</td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr align="center">
                    <td>
                        <img src="../<%#Eval("product_images") %>" height="100" width="100"/>

                    </td>
                    <td>
                        <%#Eval("product_name") %>

                    </td>
                    <td>
                        <%#Eval("product_desc") %>

                    </td>
                    <td>
                        <%#Eval("product_price") %>

                    </td>
                    <td>
                        <%#Eval("product_qty") %>

                    </td>
                    <td>
                        <a href="delete_cart.aspx?id=<%#Eval("id") %>">delete</a>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:DataList>
      <br />
        <p align="center">
            <asp:Label ID="label1" runat="server"></asp:Label><br />
            <asp:Button ID="button1" runat="server" text="checkout" OnClick="button1_Click" />
        </p>    
    </div>
</asp:Content>

