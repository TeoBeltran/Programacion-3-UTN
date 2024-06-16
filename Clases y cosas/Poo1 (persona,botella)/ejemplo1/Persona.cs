using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //Persona: edad, sueldo, nombre;
        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int e)
        {
            edad = e;
        }
        public int getEdad()
        {
            return edad;
        }

        //Metodos
        public string saludar()
        {
            return "Hola soy " + nombre;
        }
        public string saludar(string personaje)
        {
            return "Hola " + personaje + ", soy " + nombre;
        }

    }
}
