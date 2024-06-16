﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4
{
    public partial class ejemploConMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtNombre.Text = "Ingrese su nombre:...";
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string password = txtPassword.Text;
            lblSaludo.Text = "Hola " + nombre;

            //Response.Redirect("Default.aspx?nombre=" + nombre + "&pass=" + txtPassword.Text, false);

            Session.Add("usuario", nombre);
            Session.Add("pass", password);

            Response.Redirect("Default.aspx", false);
        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblSecundario.Text = txtNombre.Text;
        }
    }
}