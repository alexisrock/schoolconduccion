using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration
{
    public static class ContainerID
    {

        public static IServiceCollection ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IModuloRepository, ModuloRepository>();
            services.AddScoped<IInscripcionModuloRepository, InscripcionModuloRepository>();
            services.AddScoped<IModuloRepository, ModuloRepository>();
            services.AddScoped<IClaseRepository, ClaseRepository>();
            services.AddScoped<ISPEstudianteRepository, SPEstudianteRepository>();
            services.AddScoped<ILicenciaRepository, LicenciaRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
