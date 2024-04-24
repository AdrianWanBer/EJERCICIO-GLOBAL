namespace EJERCICIO1GLOBAL.Dtos
{
    internal class PrestamosDtos
    {
        int identificadorPrestamo;
        int identificadorCliente = 99999;
        int identificadorLibro = 99999;
        string fechaPrestamo = "31/12/9999";
        string fechaEntrega = "31/12/9999";
        string estadoPrestamo = "31/12/9999";

        public int IdentificadorPrestamo { get => identificadorPrestamo; set => identificadorPrestamo = value; }
        public int IdentificadorCliente { get => identificadorCliente; set => identificadorCliente = value; }
        public int IdentificadorLibro { get => identificadorLibro; set => identificadorLibro = value; }
        public string FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public string FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public string EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }
    }
}
