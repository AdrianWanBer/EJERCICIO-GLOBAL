using EJERCICIO1GLOBAL.Dtos;

namespace EJERCICIO1GLOBAL.Servicios
{
    internal interface AltaInterfaz
    {
        public void darAltaBiblioteca(List<BibliotecaDtos> listaBibliotecas);

        public void darAltaCliente(List<ClientesDtos> lsitaClientes, List<BibliotecaDtos> listaBibliotecas);

        public void darAltaLibro(List<LibrosDtos> listaLibros);

        public void darAltaPrestamo(List<PrestamosDtos> listaPrestamos);
    }
}
