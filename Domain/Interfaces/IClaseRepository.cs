using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Interfaces
{
    public interface IClaseRepository
    {
        Task<List<Clase>> GetAll();
        Task Insert(Clase obj);
        Task Update(Clase obj);
        Task Delete(object id);
        Task<Clase?> GetId(int objeto);

    }
}
