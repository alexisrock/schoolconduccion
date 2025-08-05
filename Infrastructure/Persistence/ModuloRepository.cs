using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ModuloRepository : IModuloRepository
    {

        private readonly IRepository<Modulo> repository;

        private readonly PruebaContext _Context;
        public ModuloRepository(IRepository<Modulo> repository, PruebaContext Context)
        {
            this.repository = repository;
            _Context = Context;
        }

        public async Task CreateRange(Modulo[] objeto)
        {
            await repository.InsertRange(objeto);
        }

        public async Task Delete(Modulo objeto)
        {
            await repository.Delete(objeto);
        }

        public async Task<List<Modulo>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<List<Modulo>> GetAllById(int id)
        {
            return await repository.GetListByParam(x => x.IdMateria == id);
        }

        public async Task<Modulo?> GetId(int objeto)
        {
            return await repository.GetById(objeto);

        }

        public  async Task<List<SPEstudiantes>>? GetMateriasprofesor()
        {
            var listMateriasProfesor = await _Context.SPEstudiantes.FromSqlRaw("EXEC SPMateriasProfesor").ToListAsync();
            return listMateriasProfesor;
        }

        public async Task Update(Modulo objeto)
        {
            await repository.Update(objeto);
        }





    }
}
