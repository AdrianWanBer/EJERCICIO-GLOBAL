using EJERCICIO1GLOBAL.Dtos;

namespace EJERCICIO1GLOBAL.Servicios
{
    internal class AltaImplementacion : AltaInterfaz
    {
        int idBiblioteca = 0;
        //Dar alta Biblioteca 
        public void darAltaBiblioteca(List<BibliotecaDtos> listaBibliotecas)
        {

            try
            {
                //Separaciones
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                //----

                Console.WriteLine("      CREANDO BIBLIOTECA");
                BibliotecaDtos nuevaBiblioteca = new BibliotecaDtos();
                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Nombre de la biblioteca: ");
                Console.WriteLine("|---------------------------|");
                nuevaBiblioteca.NombreBiblioteca = Console.ReadLine();
                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Cual es la direccion de la Biblioteca: ");
                Console.WriteLine("|---------------------------|");
                nuevaBiblioteca.DireccionBiblioteca = Console.ReadLine();
                Console.WriteLine("|---------------------------|");
                //Generador de id

                idBiblioteca = idBiblioteca + 1;
                nuevaBiblioteca.Id = idBiblioteca;

                listaBibliotecas.Add(nuevaBiblioteca);
                Console.WriteLine("!Biblioteca creada con exito¡");
                //Separaciones
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                //----

            }
            catch (Exception e)
            {
                throw;
            }
        }

        int idCliente = 0;

        public void darAltaCliente(List<ClientesDtos> listaClientes, List<BibliotecaDtos> listaBibliotecas)
        {
            try
            {
                //Separaciones
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                //----

                ClientesDtos listaNueva = new ClientesDtos();

                Console.WriteLine("      CREANDO CLIENTE");
                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Nombre: ");
                Console.WriteLine("|---------------------------|");
                listaNueva.Nombre = Console.ReadLine();

                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Apellidos: ");
                Console.WriteLine("|---------------------------|");
                listaNueva.Apellidos = Console.ReadLine();

                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Fecha de Nacimiento: ");
                Console.WriteLine("|---------------------------|");
                listaNueva.FechaNacimiento = Console.ReadLine();

                //Operacion dni ----------------------------------------|
                bool seguir = true;
                while (seguir)
                {
                    Console.WriteLine("|---------------------------|");
                    Console.WriteLine(" Numeros del dni: ");
                    Console.WriteLine("|---------------------------|");
                    int dniNumeros = int.Parse(Console.ReadLine());
                    Console.WriteLine("|---------------------------|");
                    Console.WriteLine(" Letra del dni: ");
                    Console.WriteLine("|---------------------------|");
                    string dniLetra = Console.ReadLine();


                    string[] letras = { "T", "R", "W", "A", "G", "M", "Y"
                    , "F", "P", "D", "X", "B", "N", "J", "Z", "S"
                    , "Q", "V", "H", "L", "C", "K", "E" };
                    int mod = dniNumeros % 23;
                    if (letras[mod] == dniLetra.ToUpper())
                    {
                        seguir = false;
                        listaNueva.Dni1 = dniNumeros + dniLetra;
                    }
                    else
                    {
                        Console.WriteLine("El dni es incorrecto");
                    }

                }
                //-------------------------------------------------------|

                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Correo Electronico: ");
                Console.WriteLine("|---------------------------|");
                listaNueva.CorreoElectronico = Console.ReadLine();

                idCliente = idCliente + 1;
                listaNueva.Id = idCliente;

                //Comprobacion de biblioteca
                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" A que biblioteca se quiere dar de alta: ");
                Console.WriteLine("|---------------------------|");
                int bibliotecaId = int.Parse(Console.ReadLine());
                foreach(BibliotecaDtos biblioteca in listaBibliotecas)
                {
                    
                    if(biblioteca.Id == bibliotecaId)
                    {
                        listaClientes.Add(listaNueva);
                        Console.WriteLine("!Cliente creado con exito¡");

                        //Separaciones
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        //----
                    }
                    else
                    {
                        Console.WriteLine("No se ha podido encontrar la biblioteca");
                        
                        //Separaciones
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        //----
                    }
                }
 
            }
            catch (Exception e)
            {
                throw;
            }
            
        }

        int idLibro = 0;
        public void darAltaLibro(List<LibrosDtos> listaLibros)
        {

            try
            {
                
                //Separaciones
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                //----

                LibrosDtos libroNuevo = new LibrosDtos();

                Console.WriteLine("      CREANDO LIBRO");
                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Titulo: ");
                Console.WriteLine("|---------------------------|");
                libroNuevo.Titulo = Console.ReadLine();

                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Subtitulo: ");
                Console.WriteLine("|---------------------------|");
                libroNuevo.Subtitulo = Console.ReadLine();

                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Autor: ");
                Console.WriteLine("|---------------------------|");
                libroNuevo.Isbn = Console.ReadLine();

                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Titulo: ");
                Console.WriteLine("|---------------------------|");

                Console.WriteLine("|---------------------------|");
                Console.WriteLine("Numero Edicion: ");
                Console.WriteLine("|---------------------------|");
                libroNuevo.NumeroEdicion = int.Parse(Console.ReadLine());

                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Editorial: ");
                Console.WriteLine("|---------------------------|");
                libroNuevo.Editorial = Console.ReadLine();

                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Stock: ");
                Console.WriteLine("|---------------------------|");
                libroNuevo.Stock = int.Parse(Console.ReadLine());

                idLibro = idLibro + 1;
                libroNuevo.Id = idLibro;


                listaLibros.Add(libroNuevo);
                Console.WriteLine("!Libro creado con exito¡");

                //Separaciones
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                //----
            }
            catch (Exception e)
            {
                throw;
            }

        }

        int idPrestamo = 0;
        public void darAltaPrestamo(List<PrestamosDtos> listaPrestamos)
        {
            try
            {
                //Separaciones
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                //----

                PrestamosDtos nuevoPrestamo = new PrestamosDtos();

                Console.WriteLine("      CREANDO PRESTAMO");
                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Cual es la id del cliente: ");
                Console.WriteLine("|---------------------------|");
                nuevoPrestamo.IdentificadorCliente = int.Parse(Console.ReadLine());

                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Cual es la id del libro: ");
                Console.WriteLine("|---------------------------|");
                nuevoPrestamo.IdentificadorLibro = int.Parse(Console.ReadLine());

                Console.WriteLine("|---------------------------|");
                Console.WriteLine(" Fecha del prestamo: ");
                Console.WriteLine("|---------------------------|");
                nuevoPrestamo.FechaPrestamo = Console.ReadLine();

                idPrestamo = idPrestamo + 1;
                nuevoPrestamo.IdentificadorPrestamo = idPrestamo;

                listaPrestamos.Add(nuevoPrestamo);
                Console.WriteLine("!Prestamo creado con exito¡");

                //Separaciones
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                //----

            }
            catch (Exception e)
            {
                throw;
            }

            
        }
    }
}
