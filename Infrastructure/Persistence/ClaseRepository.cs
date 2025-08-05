using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class ClaseRepository : IClaseRepository
    {
        private readonly IRepository<Clase> repository;

        public ClaseRepository(IRepository<Clase> repository)
        {
            this.repository = repository;
        }

        public async Task Delete(object id)
        {
            await repository.Delete(id);
        }

        public async Task<List<Clase>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Clase?> GetId(int objeto)
        {
            return await repository.GetById(objeto);
        }

        public async Task Insert(Clase obj)
        {
            await repository.Insert(obj);
        }

        public async Task Update(Clase obj)
        {
            await repository.Update(obj);
        }



    }
}
