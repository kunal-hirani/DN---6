<%@ Page Title="Product Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="WingtipToys.Catalog.ProductDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server" ItemType="WingtipToys.Models.Product" SelectMethod="GetProduct" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#: Item.ProductName %></h1>
            </div>
            <br />
            <div class="details-wrapper">
                <div class="details-image-box">
                    <img src="<%#: Item.ImagePath %>" style="max-height: 300px" alt="<%#: Item.ProductName %>"/>
                </div>
                <div class="details-info-box">
                    <b>Description:</b><br />
                    <p class="details-desc"><%#: Item.Description %></p>
                    <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                    <br /><br />
                    <span><b>Product Number:</b>&nbsp;<%#: Item.ProductID %></span>
                    <br />
                    <span><b>Category:</b>&nbsp;<%#: Item.CategoryName %></span>
                    <br /><br />
                    <a href="ProductList.aspx" class="btn-add-cart">&larr; Back to Catalog</a>
                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
