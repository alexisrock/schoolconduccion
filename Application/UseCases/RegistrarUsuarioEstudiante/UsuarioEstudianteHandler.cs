using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Application.Common;
using Application.Mapper;

using Domain.Entities;
using Domain.Enums;
using Domain.Exceptions;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.RegistrarUsuarioEstudiante
{
    public class UsuarioEstudianteHandler : IRequestHandler<UsuarioEstudianteRequest, BaseResponse>
    {

        private readonly IUsuarioRepository _usuarioRepository;
         private readonly IUnitOfWork _unitOfWork;

        public UsuarioEstudianteHandler(IUsuarioRepository usuarioRepository, IUnitOfWork unitOfWork)
        {
            _usuarioRepository = usuarioRepository;        
            _unitOfWork = unitOfWork;
           
        }

        public async Task<BaseResponse> Handle(UsuarioEstudianteRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse();           
            try
            {

                await _unitOfWork.ExecuteAsync(async () =>
                {
                    var validateUser = await ValidateUserName(request.NameUsuario);
                    if (validateUser is null)
                    {
                        var usuario = new Users(request.NameUsuario, request.Identificacion, request.Edad, request.IdLicencia);
                        await InsertUser(usuario);
                        return response;


                    }
                    throw new ApiException($"the user already exists with name {request.NameUsuario}", (int)System.Net.HttpStatusCode.Conflict);


                });
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
        private async Task<Users?> ValidateUserName(string? userName)
        {
            var user = await _usuarioRepository.GetByParam(x => x.NameUsuario.Equals(userName));
            return user;
        }
        private async Task InsertUser(Users usuario)
        {
            await _usuarioRepository.Insert(usuario);
        }
       

    }
}
