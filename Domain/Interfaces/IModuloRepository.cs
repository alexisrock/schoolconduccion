using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IModuloRepository
    {
        Task<Modulo?> GetId(int objeto);
        Task CreateRange(Modulo[] objeto);
        Task Delete(Modulo objeto);
        Task Update(Modulo objeto);
        Task<List<Modulo>> GetAll();
        Task<List<Modulo>> GetAllById(int id);
        Task<List<SPEstudiantes>>? GetMateriasprofesor();
    }
}
