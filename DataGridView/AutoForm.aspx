<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AutoForm.aspx.cs" Inherits="DataGridView.AutoForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>"
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtModelo" class="form-label">Modelo</label>"
                <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion</label>"
                <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtColor" class="form-label">Color</label>"
                <asp:DropDownList ID="ddlColores" runat="server" CssClass="form-select"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="txtFecha" class="form-label">Fecha</label>"
                <asp:TextBox ID="txtFecha" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:CheckBox Text="" ID="chkUsado" runat="server" />
                <asp:Label Text="Usado" CssClass="form-check-label" runat="server"></asp:Label>
            </div>
            <div>
                <asp:RadioButton ID="rdbImportado" Text="Importado" runat="server" GroupName="Importado" />
                <asp:RadioButton ID="rdbNacional" Text="Nacional" Checked="true" runat="server" GroupName="Importado" />
            </div>

            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <a href="Default.aspx">Cancelar</a>
            </div>




        </div>
    </div>
</asp:Content>

