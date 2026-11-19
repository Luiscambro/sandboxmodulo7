using Clase3.Controllers;

LibroControlador controlador = new LibroControlador();

bool continuar = true;

while (continuar)
{
    controlador.mostrarMenu();
    string opcion = controlador.SolicitarOpcion();

    switch (opcion)
    {
        case "1":
            string tituloNuevo = controlador.SolicitarTituloLibro();
            string autorNuevo = controlador.SolicitarAutorLibro();
            controlador.AgregarLibro(tituloNuevo, autorNuevo);
            break;

        case "2":
            string tituloPrestar = controlador.SolicitarTituloLibro();
            controlador.PrestarLibro(tituloPrestar);
            break;

        case "3":
            string tituloDevolver = controlador.SolicitarTituloLibro();
            controlador.DevolverLibro(tituloDevolver);
            break;

        case "4":
            controlador.mostrarLibrosDisponibles();
            break;

        case "5":
            continuar = false;
            Console.WriteLine("Saliendo del sistema...");
            break;

        default:
            Console.WriteLine("Opción no válida. Intente nuevamente.");
            break;
    }

    Console.WriteLine();
}
