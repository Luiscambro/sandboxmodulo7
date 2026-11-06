using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox
{
    public class persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public int id { get; set; }
        public int altura { get; set; } = 0;

        public persona(string nombre, int edad, int id)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.id = id;
        }

        public int calculaAltura() { 
            if (edad >= 18)
            {
                altura = 180;
            }
            else
            {
                altura = 150;
            }
            return altura;
        }
    }
}

