using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado;
            try
            {
                resultado = calcular();
                label1.Text = "= " + resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error xD");
            }
            finally
            {
                //abc
            }
        }

        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                r = a / b;
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
