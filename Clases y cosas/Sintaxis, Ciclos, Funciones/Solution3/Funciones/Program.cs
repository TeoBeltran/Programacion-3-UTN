using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aaa = saludar("Teo");
            Console.WriteLine(aaa);

            int b = 10;
            int r = sumar(2, ref b);
            Console.WriteLine(r);
        }

        static int sumar(int a, ref int z)
        {
            return a + z;
        }

        static string saludar(string nombre)
        {
            return "Hola " + nombre;
        }
    }
}
