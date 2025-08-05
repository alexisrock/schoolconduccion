using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Mapper;

using Domain.Exceptions;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.ObtenerEstudiantes
{
    public class ObtenerEstudianteHandler : IRequestHandler<ObtenerEstudianteRequest, List<ObtenerEstudianteResponse>>
    {

        private readonly ISPEstudianteRepository sPEstudiante;

        public ObtenerEstudianteHandler(ISPEstudianteRepository sPEstudiante)
        {
            this.sPEstudiante = sPEstudiante;
        }

        public async Task<List<ObtenerEstudianteResponse>> Handle(ObtenerEstudianteRequest request, CancellationToken cancellationToken)
        {
            List<ObtenerEstudianteResponse> listResponse = new List<ObtenerEstudianteResponse> ();
            try
            {

                var list = await sPEstudiante.GetAll();
                listResponse.MapperObtenerEstudianteMateriaResponse(list);
                return listResponse;
            }
            catch (Exception e)
            {

                throw new ApiException("Ocurrió un error inesperado", (int)System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}
