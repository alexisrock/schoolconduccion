using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Users
    {
        
        public int Id { get; set; }
        public string NameUsuario { get; set; }
        public string Identificacion { get; set; }
        public int Edad { get; set; }
        public int IdLicencia { get; set; }
        public Licencia Licencia { get; set; }  

        public Users(string nombre, string identificacion, int edad, int idLicencia)
        {
            NameUsuario = nombre;
            Identificacion = identificacion;
            Edad = edad;
            IdLicencia = idLicencia;
        }

        public Users()
        {
        }
    }
}
