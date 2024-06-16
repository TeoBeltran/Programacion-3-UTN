<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPRO.aspx.cs" Inherits="NetPulse.LoginPRO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <style>
        .wrapper {
            display: flex;
            align-items: center;
            flex-direction: column;
            justify-content: center;
            width: 100%;
            min-height: 100%;
            padding: 20px;
        }

        #formcontent {
            -webkit-border-radius: 10px 10px 10px 10px;
            border-radius: 10px 10px 10px 10px;
            background: #fff;
            padding: 30px;
            width: 90%;
            max-width: 450px;
            position: relative;
            padding: 0px;
            -webkit-box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
            box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
            text-align: center;
        }
    </style>
</head>
<body class="bg-light">
    <div class="wrapper">
        <div class="formcontent">
            <form id="formLogin" runat="server">
                <div class="form-control">
                    <div class="col-md-6 text-center mb-5">
                        <asp:Label ID="lblBienvenida" runat="server" Text="Bienvenido" Class="h2"></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
                        <asp:TextBox ID="tbUsuario" runat="server" placeholder="Nombre de usuario" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblContraseña" runat="server" Text="Contraseña:"></asp:Label>
                        <asp:TextBox ID="tbContraseña" runat="server" placeholder="Contraseña" CssClass="form-control"></asp:TextBox>
                    </div>
                    <hr />
                    <div class="row">
                        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-primary btn-dark" OnClick="btnIngresar_Click"/>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace NetPulse
{
    public partial class LoginPRO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();
            {
                datos.conection.ConnectionString = "server=.\\SQLEXPRESS;database=UserLoginTest;integrated security=true";

            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
