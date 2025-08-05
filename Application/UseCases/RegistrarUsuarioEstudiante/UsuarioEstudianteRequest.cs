﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common;
using MediatR;

namespace Application.UseCases.RegistrarUsuarioEstudiante
{
    public class UsuarioEstudianteRequest : IRequest<BaseResponse>
    {
        public string? NameUsuario { get; set; }
        public string? Identificacion { get; set; }
        public int Edad { get; set; }
        public int IdLicencia { get; set; }
       

    }
}
