using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.ObtenerEstudiantes
{
    public class ObtenerEstudianteResponse
    {
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public int Edad { get; set; }
        public string Licencia { get; set; }
    }
}
