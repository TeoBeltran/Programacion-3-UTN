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
    public partial class frmVentanaPrueba : Form
    {
        public frmVentanaPrueba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola Mundo");
            string texto = txtNombre.Text;
            labelSaludo.Text = "Hola " + texto;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            string elem = textNombre.Text;
            lwElementos.Items.Add(elem);
        }
    }
}
