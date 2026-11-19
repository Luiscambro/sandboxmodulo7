using System;
using System.Collections.Generic;
using System.Text;
using Clase3.Models;
using Clase3.Views;

namespace Clase3.Controllers
{
    /// <summary>
    /// Controlador para gestionar las operaciones relacionadas con los libros.
    /// </summary>
    public class LibroControlador
    {
        private LibroVista vista = new LibroVista();
        private List<LibroModels> libros = new List<LibroModels>();

        /// <summary>
        /// Muestra el menu principal en pantalla. 
        /// </summary>
        public void mostrarMenu()
        {
            vista.MostrarMenu();
        }

        // TAREA: el Controller coordina la comunicación entre la View y el resto
        // de la aplicación, sin leer directamente desde Console.
        public string SolicitarOpcion()
        {
            return vista.SolicitarOpcion();
        }

        public string SolicitarTituloLibro()
        {
            return vista.SolicitarTituloLibro();
        }

        public string SolicitarAutorLibro()
        {
            return vista.SolicitarAutorLibro();
        }

        /// <summary>
        /// Agrega un nuevo libro a la lista de libros.
        /// </summary>
        /// <param name="titulo"></param>
        /// El titulo del libro a agregar.
        /// <param name="autor"></param>
        /// autor del libro a agregar.
        public void AgregarLibro(string titulo, string autor)
        {
            LibroModels libro = new LibroModels(titulo, autor);
            libros.Add(libro);
            vista.MostrarMensaje($"El libro '{titulo}' ha sido agregado.");
        }



        /// <summary>
        ///  controlador que permite prestar un libro de la biblioteca.
        /// </summary>
        /// <param name="titulo"></param>



        public void PrestarLibro(string titulo)
        {
            // TAREA: se busca el libro y se delega al Model la regla de préstamo.
            // La comparación ignora mayúsculas y minúsculas para facilitar el uso.
            LibroModels? libro = libros.FirstOrDefault(
                libro => libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));


            // Si el libro no se encuentra, la View informa el problema y se detiene.
            if (libro == null)
            {
                vista.MostrarMensaje("El libro no existe.");
                return;
            }
            // El Model valida que no esté prestado y cambia su estado si procede.
            if (libro.Prestar())
            {
                vista.MostrarMensaje($"El libro '{titulo}' fue prestado correctamente.");
            }

            // TAREA: caso no válido: no se puede prestar dos veces el mismo libro.
            else
            {
                vista.MostrarMensaje($"El libro '{titulo}' ya está prestado.");
            }
        }

        /// <summary>
        /// controlador que permite devolver el libro
        /// </summary>
        /// <param name="titulo"></param>



        public void DevolverLibro(string titulo)
        {
            // TAREA: se busca el libro y se delega al Model la regla de devolución.
            LibroModels? libro = libros.FirstOrDefault(
                libro => libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            //si el libro no se encuentra, muestra un mensaje de error y termina la ejecución del método.
            if (libro == null)
            {
                vista.MostrarMensaje("El libro no existe.");
                return;
            }
            // El Model solo permite devolver un libro que esté prestado.
            if (libro.Devolver())
            {
                vista.MostrarMensaje($"El libro '{titulo}' fue devuelto correctamente.");
            }
            // TAREA: caso no válido: no se puede devolver un libro disponible.
            else
            {
                vista.MostrarMensaje($"El libro '{titulo}' ya estaba disponible.");
            }
        }




        /// <summary>
        /// Muestra la lista de libros disponibles en la biblioteca.
        /// </summary>
        public void mostrarLibrosDisponibles()
        {
            vista.MostrarLibrosDisponibles(libros);
        }



    }
}

    