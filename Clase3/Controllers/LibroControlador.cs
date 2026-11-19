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
            ///busca el libro en la lista de libros por su título.“Compara el título del libro sin importar si el usuario escribió mayúsculas o minúsculas.”
            LibroModels? libro = libros.FirstOrDefault(
                libro => libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));


            ///si el libro no se encuentra, muestra un mensaje de error y termina la ejecución del método.
            if (libro == null)
            {
                vista.MostrarMensaje("El libro no existe.");
                return;
            }
            ///si el libro se encuentra, intenta prestarlo llamando al método Prestar() del modelo LibroModels.
            if (libro.Prestar())
            {
                vista.MostrarMensaje($"El libro '{titulo}' fue prestado correctamente.");
            }

            //si el libro no está disponible, muestra un mensaje indicando que el libro ya está prestado.
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
            //busca el libro en la lista de libros por su título. Compara el título del libro sin importar si el usuario escribió mayúsculas o minúsculas.
            LibroModels? libro = libros.FirstOrDefault(
                libro => libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            //si el libro no se encuentra, muestra un mensaje de error y termina la ejecución del método.
            if (libro == null)
            {
                vista.MostrarMensaje("El libro no existe.");
                return;
            }
            //si el libro fue devuelto mostrar msj el libro fue devuelto correctamente 
            if (libro.Devolver())
            {
                vista.MostrarMensaje($"El libro '{titulo}' fue devuelto correctamente.");
            }
            //como fue devuelto correctamente mostrar el msj ya esta disponible
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

    