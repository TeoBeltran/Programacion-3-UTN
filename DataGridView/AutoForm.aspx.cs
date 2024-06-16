using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataGridView
{
    public partial class AutoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlColores.Items.Add("Negro");
                ddlColores.Items.Add("Blanco");
                ddlColores.Items.Add("Rojo");
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto();
            auto.Id = int.Parse(txtId.Text);
            auto.Modelo = txtModelo.Text;
            auto.Descripcion = txtDescripcion.Text;
            auto.Color=ddlColores.SelectedValue;
            auto.Fecha=DateTime.Parse(txtFecha.Text);

            if (rdbImportado.Checked)
            {
                auto.Importado = true;
            }
            else
            {
                if (rdbNacional.Checked)
                {
                    auto.Importado = false;
                }
            }

            //Acá se deberia mandar a la base de datos con algun metodo...

            //(List<Auto>)Session["listaAutos"].Add(auto);

            List<Auto> temporal = (List<Auto>)Session["listaAutos"];
            temporal.Add(auto);
            //<sessionState mode="InProc" cookieless="false" timeout="20" />

            Response.Redirect("Default.aspx");
        }
    }
}