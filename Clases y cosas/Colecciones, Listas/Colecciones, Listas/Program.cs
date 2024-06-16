using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones__Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            c1.Color = "Amarillo";
            c2.Color = "Rojo";
            c3.Color = "Azul";

            List<Camioneta> listaCamionetas = new List<Camioneta>();
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            // Console.WriteLine("La cant de camionetas es de " + listaCamionetas.Count);
            // Console.WriteLine("El color es " + listaCamionetas[1].Color);

            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("Color: " + item.Color);
            }

            Console.ReadKey();

        }
    }
}
