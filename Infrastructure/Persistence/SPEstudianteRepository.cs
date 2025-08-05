using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class SPEstudianteRepository : ISPEstudianteRepository
    {
        private readonly PruebaContext _Context;

        public SPEstudianteRepository(PruebaContext context)
        {
            _Context = context;
        }

        public async Task<List<SPEstudiantes>> GetAll()
        {
            var listestudiantes = await _Context.SPEstudiantes.FromSqlRaw("EXEC SPEstudiantes  ").ToListAsync();
            return listestudiantes;
        }
    }
}
