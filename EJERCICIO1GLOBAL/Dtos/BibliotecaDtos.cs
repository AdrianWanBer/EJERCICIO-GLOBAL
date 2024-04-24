namespace EJERCICIO1GLOBAL.Dtos
{
    internal class BibliotecaDtos
    {
        //Campos
        int id;
        string nombreBiblioteca = "aaaaa";
        string direccionBiblioteca = "aaaaa";



        //Get y Set
        public int Id { get => id; set => id = value; }
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public string DireccionBiblioteca { get => direccionBiblioteca; set => direccionBiblioteca = value; }
    }
}
