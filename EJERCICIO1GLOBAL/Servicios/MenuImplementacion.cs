namespace EJERCICIO1GLOBAL.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuAltas()
        {
            try
            {
                Console.WriteLine("|---------------------------|");
                Console.WriteLine("|      QUE DESEA HACER      |");
                Console.WriteLine("|---------------------------|");
                Console.WriteLine("|                           |");
                Console.WriteLine("|    0.Salir                |");
                Console.WriteLine("|                           |");
                Console.WriteLine("|    1.Crear Biblioteca     |");
                Console.WriteLine("|                           |");
                Console.WriteLine("|    2.Crear Cliente        |");
                Console.WriteLine("|                           |");
                Console.WriteLine("|    3.Crear  Libro         |");
                Console.WriteLine("|                           |");
                Console.WriteLine("|    4.Crear  Prestamo      |");
                Console.WriteLine("|                           |");
                Console.WriteLine("|---------------------------|");
                int seleccion = int.Parse(Console.ReadLine());
                return seleccion;
            }
            catch (Exception e)
            {
                throw;
            }
           
        }

        public int menuPrincipal()
        {
            try
            {
                Console.WriteLine("|---------------------------|");
                Console.WriteLine("|      QUE DESEA HACER      |");
                Console.WriteLine("|---------------------------|");
                Console.WriteLine("|                           |");
                Console.WriteLine("|    0.Cerrar               |");
                Console.WriteLine("|                           |");
                Console.WriteLine("|    1.Acceder              |");
                Console.WriteLine("|                           |");
                Console.WriteLine("|    2.Dar de alta          |");
                Console.WriteLine("|                           |");
                Console.WriteLine("|---------------------------|");
                int seleccion = int.Parse(Console.ReadLine());
                return seleccion;
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public int menuAcceso()
        {
            try
            {
                Console.WriteLine("|---------------------------|");
                Console.WriteLine("|      QUE DESEA HACER      |");
                Console.WriteLine("|---------------------------|");
                Console.WriteLine("|                           |");
                Console.WriteLine("|    0.Cerrar               |");
                Console.WriteLine("|                           |");
                Console.WriteLine("|    1.              |");
                Console.WriteLine("|                           |");
                Console.WriteLine("|    2.          |");
                Console.WriteLine("|                           |");
                Console.WriteLine("|---------------------------|");
                int seleccion = int.Parse(Console.ReadLine());

                return seleccion;
            }
            catch (Exception e)
            {
                throw;
            }
            
        }
    }
}
