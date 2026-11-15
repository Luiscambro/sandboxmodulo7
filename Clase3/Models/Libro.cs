using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Models
{
    /// <summary>
    /// modelo que representa un libro en la biblioteca.
    /// </summary>
    public class Libro
    {
        //Seccion de las propiedades de la clase libro
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponible { get; private set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Libro.
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Disponible = true;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Libro.
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="disponible"></param>
        public Libro(string titulo, string autor, bool disponible)
        {
            Titulo = titulo;
            Autor = autor;
            Disponible = disponible;
        }

        /// <summary>
        /// Marca el libro como prestado si está disponible y muestra un mensaje en la consola.
        /// </summary>
        public void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine($"El libro '{Titulo}' ha sido prestado.");
            }
            else
            {
                Console.WriteLine($"El libro '{Titulo}' no está disponible para préstamo.");
            }
        }

        /// <summary>
        /// Marca el libro como devuelto y muestra un mensaje en la consola.
        /// </summary>
        public void Devolver()
        {
            if (!Disponible)
            {
                Disponible = true;
                Console.WriteLine($"El libro '{Titulo}' ha sido devuelto.");
            }
            else
            {
                Console.WriteLine($"El libro '{Titulo}' ya está disponible.");
            }
        }



    }
}
