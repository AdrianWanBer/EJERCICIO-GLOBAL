namespace EJERCICIO1GLOBAL.Dtos
{
    internal class LibrosDtos
    {
        int id;
        string titulo = "aaaaa";
        string subtitulo = "aaaaa";
        string autor = "aaaaa";
        string isbn = "aaaaa";
        int numeroEdicion = 99999;
        string editorial = "aaaaa";
        int stock = 99999;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Subtitulo { get => subtitulo; set => subtitulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public int NumeroEdicion { get => numeroEdicion; set => numeroEdicion = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
