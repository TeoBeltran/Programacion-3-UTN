<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <% if (user != "")
        { %>
    <h2>Ingresaste!</h2>
    <asp:Label ID="lblUser" runat="server" Text="text"></asp:Label>

    <% }
        else
        { %>
    <h2>Debes loguearte</h2>
    <a href="ejemploConMaster">Login</a>
    <% } %>

</asp:Content>
