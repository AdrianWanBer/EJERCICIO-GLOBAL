using EJERCICIO1GLOBAL.Dtos;
using EJERCICIO1GLOBAL.Servicios;

namespace EJERCICIO1GLOBAL.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            //Declaraciones y creaciones, variables...etc
            MenuInterfaz mi = new MenuImplementacion();
            AltaInterfaz ai = new AltaImplementacion();
            List<ClientesDtos> clientesLista = new List<ClientesDtos>();
            List<BibliotecaDtos> bibliotecaLista = new List<BibliotecaDtos>();
            List<LibrosDtos> librosLista = new List<LibrosDtos>();
            List<PrestamosDtos> prestamosLista = new List<PrestamosDtos>();
            bool cerrarAplicacion = false;



            //While que mantendra la aplicacion encendida
            while (!cerrarAplicacion)
            {
                int seleccion = mi.menuPrincipal();
                switch (seleccion)
                {
                    case 0: //Cerrar la aplicacion
                        cerrarAplicacion = true;
                        break;
                    case 1: //Abrir menu de acceso
                        int seleccionAcceso = mi.menuAcceso();
                        switch (seleccionAcceso)
                        {
                            case 0: //Cerrar Menu
                                break;
                            case 1:
                                break;
                            case 2:
                                break;
                        }
                        break;
                    case 2: //Abrir menu de dar altas
                        int seleccionAlta = mi.menuAltas();
                        switch (seleccionAlta)
                        {
                            case 0: //Cerrar la aplicacion
                                break;

                            case 1: //Dar de alta una Biblioteca
                                ai.darAltaBiblioteca(bibliotecaLista);
                                break;

                            case 2: //Dar de alta un Cliente
                                ai.darAltaCliente(clientesLista, bibliotecaLista);
                                break;

                            case 3: //Dar de alta un Libro
                                ai.darAltaLibro(librosLista);
                                break;

                            case 4: //Dar de alta un Prestamo
                                ai.darAltaPrestamo(prestamosLista);
                                break;
                        }
                        break;


                    default:
                        Console.WriteLine("Ha ocurrido un error");
                        break;
                }
            }

        }
    }
}
