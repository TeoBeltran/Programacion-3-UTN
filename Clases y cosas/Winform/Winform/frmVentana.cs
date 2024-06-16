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
    public partial class frmVentana : Form
    {
        public frmVentana()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bover");
            comboBox1.Items.Add("Rica");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola Mundo");
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            DateTime fecha = dtpFechaNac.Value;
            string marcame = chb.Checked == true ? "Si" : "No";     //operador ternario
            string equipo;
            if (Boca.Checked == true)
                equipo = "Boca";
            else
                equipo = "River";
            string fusion = comboBox1.SelectedItem.ToString();

            MessageBox.Show("Nombre: " + nombre + " Fecha: " + fecha + " Marcame: " + marcame + " Equipo: " + equipo + " Fusion: " + fusion);
        }

        private void frmVentana_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bover");
            comboBox1.Items.Add("Rica");
        }
    }
}
