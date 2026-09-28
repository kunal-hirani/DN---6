<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WingtipToys.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %> Wingtip Toys</h2>
    <h3>Customer Support & Inquiries</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr> 425.555.0100
    </address>

    <address>
        <strong>Support:</strong> <a href="mailto:Support@wingtiptoys.com">Support@wingtiptoys.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@wingtiptoys.com">Marketing@wingtiptoys.com</a>
    </address>
</asp:Content>
