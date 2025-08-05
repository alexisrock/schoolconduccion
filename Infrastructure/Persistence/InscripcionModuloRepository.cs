using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class InscripcionModuloRepository : IInscripcionModuloRepository
    {

        private readonly IRepository<InscripcionModulo> repository;

        public InscripcionModuloRepository(IRepository<InscripcionModulo> repository)
        {
            this.repository = repository;
        }

        public async Task Create(InscripcionModulo objeto)
        {
            await repository.Insert(objeto);
        }

        public async Task Create(InscripcionModulo[] objeto)
        {
            await repository.InsertRange(objeto);
        }

        public async Task Delete(InscripcionModulo objeto)
        {
            await repository.Delete(objeto);
        }

        public async Task<List<InscripcionModulo>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<InscripcionModulo?> GetId(int objeto)
        {
            return await repository.GetById(objeto);

        }

        public async Task<List<InscripcionModulo>> GetListByParam(Expression<Func<InscripcionModulo, bool>> obj)
        {

            return await repository.GetListByParam(obj);
        }

        public async Task Update(InscripcionModulo objeto)
        {
            await repository.Update(objeto);
        }



    }
}
