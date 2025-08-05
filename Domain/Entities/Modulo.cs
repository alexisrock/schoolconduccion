namespace Domain.Entities
{
    public class Modulo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int IdMateria { get; set; }

        public Clase Clase  { get; set; }
       

        public Modulo(string descripcion, int idMateria)
        {
            Descripcion = descripcion;
            IdMateria = idMateria;
        }

        public Modulo()
        {
        }
    }



    public class SPEstudiantes
    {
   
        public string NameUsuario { get; set; }
        public string Identificacion { get; set; }
        public int Edad { get; set; }
        public string Description { get; set; }






    }
}
