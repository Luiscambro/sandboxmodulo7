using System;
using Clase3.Controllers;

LibroControlador controlador = new LibroControlador();

controlador.AgregarLibro("Cien Años de Soledad", "Gabriel García Márquez");
controlador.AgregarLibro("1984", "George Orwell");
controlador.AgregarLibro("El Principito", "Antoine de Saint-Exupéry");

controlador.mostrarLibrosDisponibles();

