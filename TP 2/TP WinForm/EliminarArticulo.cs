using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinForm
{
    public partial class EliminarArticulo : Form
    {

        private ArticuloNegocio negocioArticulo;
        private Articulo articuloActual;
        public EliminarArticulo(List<Articulo> catalogo)
        {
            InitializeComponent();
            negocioArticulo = new ArticuloNegocio();
            articuloActual = new Articulo();
        }

        private void EliminarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cbBrand.DataSource = marcaNegocio.ListarM();
                cbCat.DataSource = categoriaNegocio.ListarC();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string id = tbId.Text;

            if (!string.IsNullOrWhiteSpace(id))
            {
                try
                {
                    Articulo articulo = negocioArticulo.BuscarPorId(id);

                    if (articulo != null)
                    {
                        tbCod.Text = articulo.Codigo;
                        tbName.Text = articulo.Nombre;
                        tbDesc.Text = articulo.Descripcion;
                        cbBrand.Text = articulo.IdMarca.Descripcion;
                        cbCat.Text = articulo.IdCategoria.Descripcion;
                        tbPrice.Text = articulo.Precio.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ese articulo no existe");
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el artículo: " + ex.Message);
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un id valido.");
            }
        }

        private void LimpiarCampos()
        {
            tbName.Clear();
            tbDesc.Clear();
            tbPrice.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = tbId.Text;

            if (!string.IsNullOrWhiteSpace(id))
            {
                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(respuesta == DialogResult.Yes)
                    {
                        negocioArticulo.Eliminar(id);
                        MessageBox.Show("El artículo se ha eliminado correctamente.");
                        LimpiarCampos();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el artículo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
        }
    }
}
