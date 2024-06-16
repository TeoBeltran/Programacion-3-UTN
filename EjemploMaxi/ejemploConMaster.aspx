<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ejemploConMaster.aspx.cs" Inherits="TP4.ejemploConMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>Ejemplo con master</h1>

    <asp:TextBox ID="txtNombre" runat="server" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>

    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>

    <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />

    <asp:Label ID="lblSaludo" runat="server" Text=""></asp:Label>

    <asp:Label ID="lblSecundario" runat="server" Text=""></asp:Label>


</asp:Content>
