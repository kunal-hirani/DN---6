<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WingtipToys._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="background: #f0f4f8; padding: 40px; border-radius: 8px; margin-bottom: 30px;">
        <h1 style="color: #0066cc;">Welcome to Wingtip Toys!</h1>
        <p class="lead" style="color: #4b5563; font-size: 1.25rem;">
            Wingtip Toys is all about transportation toys. You can browse through our fast cars, high-flying planes, rugged trucks, speed boats, and space rockets!
        </p>
        <p><a href="Catalog/ProductList.aspx" class="btn-add-cart" style="font-size: 1.1rem; padding: 10px 20px;">Browse Catalog &raquo;</a></p>
    </div>

    <div class="row" style="display: flex; gap: 20px;">
        <div style="flex: 1; background: #fff; padding: 20px; border: 1px solid #e5e7eb; border-radius: 6px;">
            <h2>Explore Categories</h2>
            <p>Select any category from the top navigation bar to filter our products by category.</p>
        </div>
        <div style="flex: 1; background: #fff; padding: 20px; border: 1px solid #e5e7eb; border-radius: 6px;">
            <h2>Product Details</h2>
            <p>Click on any product to view its high-resolution photo, unit price, and full description.</p>
        </div>
        <div style="flex: 1; background: #fff; padding: 20px; border: 1px solid #e5e7eb; border-radius: 6px;">
            <h2>ASP.NET Web Forms</h2>
            <p>Demonstrates Master Pages, Server Controls, Model Binding, and URL Routing.</p>
        </div>
    </div>
</asp:Content>
