<%@ Page Title="Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="WingtipToys.Catalog.ProductList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>

            <asp:ListView ID="productList" runat="server" 
                DataKeyNames="ProductID" GroupItemCount="3"
                ItemType="WingtipToys.Models.Product" SelectMethod="GetProducts">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <div class="product-item-card">
                            <a href="<%#: GetRouteUrl("ProductByNameRoute", new {productName = Item.ProductName}) %>">
                                <img src="<%#: Item.ImagePath %>" class="product-thumb" alt="<%#: Item.ProductName %>" />
                            </a>
                            <br />
                            <a href="<%#: GetRouteUrl("ProductByNameRoute", new {productName = Item.ProductName}) %>" class="product-title">
                                <span><%#: Item.ProductName %></span>
                            </a>
                            <br />
                            <div class="product-price-tag">
                                <span><%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                            </div>
                            <a href="<%#: GetRouteUrl("ProductByNameRoute", new {productName = Item.ProductName}) %>" class="btn-add-cart">View Details</a>
                        </div>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table class="product-grid-table">
                        <tbody>
                            <tr id="groupPlaceholderContainer" runat="server">
                                <td id="groupPlaceholder" runat="server"></td>
                            </tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>
