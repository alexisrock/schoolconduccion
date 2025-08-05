using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Application.Common;
using Application.Mapper;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.AsignarModuloEstudiante
{
    public class AsignarMateriaHandler : IRequestHandler<AsignarMateriaRequest, BaseResponse>
    {

        private readonly IInscripcionModuloRepository _inscripcionMateriaRepository;

        public AsignarMateriaHandler(IInscripcionModuloRepository inscripcionMateriaRepository)
        {
            _inscripcionMateriaRepository = inscripcionMateriaRepository;
        }

        public async Task<BaseResponse> Handle(AsignarMateriaRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse();
            try
            {
                if (await ValidarMateriasEstudiante(request.IdUsuario))
                {
                    throw new ApiException("Ya tiene materias registradas", (int)System.Net.HttpStatusCode.BadRequest);
                }

                if (!request.Modulos.Any())
                {
                    throw new ApiException("Debe registrar al menos una modulo", (int)System.Net.HttpStatusCode.BadRequest);
                }             


                await Insert(request);

                response.SetDataResponse(HttpStatusCode.OK, $"Materias registradas con exito");
                return response;
            }
            catch (Exception ex) when (ex is ApiException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApiException("Ocurrió un error inesperado", (int)System.Net.HttpStatusCode.InternalServerError);
            }
        }


        private async  Task<bool> ValidarMateriasEstudiante(int idUsuario)
        {
            var materias = await _inscripcionMateriaRepository.GetListByParam( x => x.IdUsuario== idUsuario);
            return materias.Any();
        }

    

        private async Task Insert(AsignarMateriaRequest request)
        {
            List<InscripcionModulo> listAsignarMateria = new List<InscripcionModulo>();
            request.Modulos.ForEach(materia => {
                var inscripcionMateria = new InscripcionModulo(materia.IdModulo, request.IdUsuario);
                listAsignarMateria.Add(inscripcionMateria);
            });

            await _inscripcionMateriaRepository.Create(listAsignarMateria.ToArray());
        }

    }
}
