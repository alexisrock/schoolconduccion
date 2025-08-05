using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Application.Common;
using Application.UseCases.ObtenerMateriasByEstudiante;
using Application.UseCases.ObtenerEstudiantes;
using Application.UseCases.ObtenerRoles;
using Domain.Entities;
using Domain.ValueObjects;

namespace Application.Mapper
{
    [ExcludeFromCodeCoverage]
    internal static class Transform
    {

        internal static BaseResponse SetDataResponse(this BaseResponse objeto, HttpStatusCode StatusCode, string? Message)
        {
            objeto.message = Message;
            return objeto;
        }

        internal static List<LicenciaResponse> MapperListRolResponse(this List<LicenciaResponse> listResponse, List<Licencia> list)
        {
            if (list.Any())
            {

                list.ForEach(rol =>
                {
                    var response = new LicenciaResponse();
                    response.Id = rol.Id;
                    response.Description = rol.Description;
                    listResponse.Add(response);
                });

            }

            return listResponse;
        }

        internal static List<ModulosResponse> MapperObtenerMateriasByIdEstudianteResponse(this List<ModulosResponse> listResponse, List<Modulo> list)
        {
            if (list.Any())
            {

                list.ForEach(list =>
                {
                    var response = new ModulosResponse();
                    response.Descripcion = list.Descripcion;
                    response.Id = list.Id;
                    response.IdMateria = list.IdMateria;
                    listResponse.Add(response);
                });
            }

            return listResponse;
        }

        internal static List<ObtenerEstudianteResponse> MapperObtenerEstudianteMateriaResponse(this List<ObtenerEstudianteResponse> listResponse, List<SPEstudiantes> list) {

            if (list.Any())
            {

                list.ForEach(list =>
                {
                    var response = new ObtenerEstudianteResponse();
                    response.Nombre = list.NameUsuario;
                    response.Identificacion = list.Identificacion;
                    response.Edad = list.Edad;
                    response.Licencia = list.Description;

                    listResponse.Add(response);
                });
            }

            return listResponse;


        }
    }
}

