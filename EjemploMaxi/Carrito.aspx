<%@ Page Title="Carrito" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TP4.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="estilos.css" />

    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <p>Lista de productos agregados a tu carrito.</p>

        
        <section class="carrito">
            <h3>Product1</h3>
            <p>
                Datos del producto........
            </p>
        </section>
        



    </main>
</asp:Content>
