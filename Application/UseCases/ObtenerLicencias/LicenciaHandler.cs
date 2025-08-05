using Domain.Exceptions;
using Domain.Interfaces;
using MediatR;
using Application.Mapper;

namespace Application.UseCases.ObtenerRoles
{
    public class LicenciaHandler : IRequestHandler<LicenciaRequest, List<LicenciaResponse>>
    {

        private readonly ILicenciaRepository _repository;

        public LicenciaHandler(ILicenciaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<LicenciaResponse>> Handle(LicenciaRequest request, CancellationToken cancellationToken)
        {
            var listResponse = new List<LicenciaResponse>();
            try
            {

                var listRol = await _repository.GetAll();
                listResponse.MapperListRolResponse(listRol);
                return listResponse;
            }
            catch (Exception e)
            {

                throw new ApiException("Ocurrió un error inesperado", (int)System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}
