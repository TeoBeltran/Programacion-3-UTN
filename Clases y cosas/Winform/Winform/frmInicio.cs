using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmVentana))
                {
                    return;
                }
            }

            frmVentana ventana = new frmVentana();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmVentana))
                {
                    MessageBox.Show("Ya está abierta");
                    return;
                }
            }

            frmVentana ventana = new frmVentana();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
