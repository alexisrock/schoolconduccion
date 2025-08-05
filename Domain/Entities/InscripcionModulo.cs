using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InscripcionModulo
    {

        public int Id { get; set; }
        public int IdModulo { get; set; }
        public Modulo Modulo { get; set; }
        public int IdUsuario { get; set; }        
        public Users Usuario { get; set; }

        public InscripcionModulo(int idModulo, int idUsuario)
        {
            IdModulo = idModulo;
            IdUsuario = idUsuario;
        }

        public InscripcionModulo()
        {
        }
    }
}
