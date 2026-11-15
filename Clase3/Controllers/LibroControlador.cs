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
        private LibroVista  vista = new LibroVista();
        private List<Libro> libros = new List<Libro>();

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
            Libro libro = new Libro(titulo, autor);
            libros.Add(libro);
            vista.MostrarMensaje($"El libro '{titulo}' ha sido agregado.");
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
