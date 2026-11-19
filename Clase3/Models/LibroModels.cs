using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Models
{
    /// <summary>
    /// modelo que representa un libro en la biblioteca.
    /// </summary>
    public class LibroModels
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
        public LibroModels(string titulo, string autor)
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
        public LibroModels(string titulo, string autor, bool disponible)
        {
            Titulo = titulo;
            Autor = autor;
            Disponible = disponible;
        }

        /// <summary>
        /// Marca el libro como prestado si está disponible y muestra un mensaje en la consola.
        /// </summary>
        public bool Prestar()
        {
            // TAREA: regla de negocio del Model. Un libro ya prestado no cambia
            // de estado y devuelve false para que el Controller avise al usuario.
            if (!Disponible)
            {
                return false;
            }

            Disponible = false;
            return true;
        }

        /// <summary>
        /// Marca el libro como devuelto y muestra un mensaje en la consola.
        /// </summary>
        public bool Devolver()
        {
            // TAREA: regla de negocio del Model. Un libro disponible no puede
            // devolverse otra vez y devuelve false para indicar la operación inválida.
            if (Disponible)
            {
                return false;
            }

            Disponible = true;
            return true;
        }


    }
}
