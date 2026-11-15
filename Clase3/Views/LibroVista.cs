using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Views
{
    /// <summary>
    /// Vista para mostrar información relacionada con los libros en la consola.
    /// </summary>
    public class LibroVista
    {
        /// <summary>
        /// Muestra el menú principal de la biblioteca en la consola.
        /// </summary>
        public void MostrarMenu()
        {
            Console.WriteLine("=== Menú de Biblioteca ===");
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Prestar libro");
            Console.WriteLine("3. Devolver libro");
            Console.WriteLine("4. Mostrar libros disponibles");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
           
        }

        /// <summary>
        /// Muestra la lista de libros disponibles en la biblioteca.
        /// </summary>
        /// <param name="libros"></param>
        public void MostrarLibrosDisponibles(List<Models.Libro> libros)
        {
            Console.WriteLine("=== Libros Disponibles ===");
            foreach (var libro in libros)
            {
                string disponibilidad = libro.Disponible ? "Disponible" : "No disponible";

                Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Disponibilidad: {disponibilidad}");
            }
            
        }

        /// <summary>
        /// Muestra un mensaje en la consola.
        /// </summary>
        /// <param name="mensaje"></param>
        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
