namespace EJERCICIO1GLOBAL.Dtos
{
    internal class ClientesDtos
    {
        int id;
        string nombre = "aaaaa";
        string apellidos = "aaaaa";
        string fechaNacimiento = "31/12/9999";
        string Dni = "aaaaa";
        string correoElectronico = "aaaaa";
        string fechaInicioSuspension = "31/12/9999";
        string fechaFinSuspension = "31/12/9999";
        int bibliotecaId = 99999;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Dni1 { get => Dni; set => Dni = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string FechaInicioSuspension { get => fechaInicioSuspension; set => fechaInicioSuspension = value; }
        public string FechaFinSuspension { get => fechaFinSuspension; set => fechaFinSuspension = value; }
        public int BibliotecaId { get => bibliotecaId; set => bibliotecaId = value; }
    }
}
