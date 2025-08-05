﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Configuration
{
    public static class ContainerID
    {



        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {

            services.AddFluentValidationAutoValidation();
           
            return services;
        }
    }
}
