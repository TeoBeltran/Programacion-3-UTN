using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int edad;
            float sueldo;
            string nombre;
            int[] edades = new int[10];
            float[] sueldos = new float[10];
            string[] nombres =new string[10];*/

            Persona p1 = new Persona("Teo");
            p1.setEdad(20);
            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("Messi"));
            Console.WriteLine("La edad de la persona es " + p1.getEdad());

            /*Botella b1 = new Botella("Rojo", "Plastico");

            Console.WriteLine("Capacidad: " + b1.Capacidad);
            Console.WriteLine("Cant actual: " + b1.CantidadActual);
            b1.recargar();
            Console.WriteLine("Luego de recargar, la cant actual es: " + b1.CantidadActual);*/

        }
    }
}
