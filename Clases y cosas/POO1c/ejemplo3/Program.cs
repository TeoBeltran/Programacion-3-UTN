using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            nombre=Console.ReadLine();

            int cant = nombre.Length;

            nombre = nombre.Replace('e', 'z');
        }
    }
}
