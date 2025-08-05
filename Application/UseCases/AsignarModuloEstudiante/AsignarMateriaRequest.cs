using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common;

using MediatR;

namespace Application.UseCases.AsignarModuloEstudiante
{
    public class AsignarMateriaRequest : IRequest<BaseResponse>
    {

        public int IdUsuario { get; set; }
        public List<AsignarMateriaProfesorRequest> Modulos { get; set; }
    }


    public class AsignarMateriaProfesorRequest
    {
        public int IdModulo { get; set; }
     

    }
}
