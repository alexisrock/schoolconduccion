using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Mapper;
using Application.UseCases.ObtenerEstudiantes;
using Domain.Exceptions;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.ObtenerMateriasByEstudiante
{
    public class ObtenerModulosHandler : IRequestHandler<ModulosRequest, List<ModulosResponse>>
    {

        private readonly IModuloRepository moduloRepository;

        public ObtenerModulosHandler(IModuloRepository moduloRepository)
        {
            this.moduloRepository = moduloRepository;
        }

        public async Task<List<ModulosResponse>> Handle(ModulosRequest request, CancellationToken cancellationToken)
        {
            var listResponse = new List<ModulosResponse>();

            try
            {

                var list = await moduloRepository.GetAll();
                listResponse.MapperObtenerMateriasByIdEstudianteResponse(list);
                return listResponse;
            }
            catch (Exception)
            {
                throw new ApiException("Ocurrió un error inesperado", (int)System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}
