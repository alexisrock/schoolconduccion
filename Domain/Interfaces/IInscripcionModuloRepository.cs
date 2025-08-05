using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IInscripcionModuloRepository
    {
        Task<InscripcionModulo?> GetId(int objeto);
        Task Create(InscripcionModulo objeto);
        Task Create(InscripcionModulo[] objeto);
        Task Delete(InscripcionModulo objeto);
        Task Update(InscripcionModulo objeto);
        Task<List<InscripcionModulo>> GetAll();
        Task<List<InscripcionModulo>> GetListByParam(Expression<Func<InscripcionModulo, bool>> obj);
    }
}

