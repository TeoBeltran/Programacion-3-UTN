using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4
{
    public partial class Contact : Page
    {
        public string user { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            user = Session["usuario"] != null ? Session["usuario"].ToString() : "";

            lblTeo.Text = user;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            user = Session["usuario"] != null ? Session["usuario"].ToString() : "";

            lblTeo.Text = user + ", tu ingreso fue exitoso.";
        }

        protected void textBoxTeo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}