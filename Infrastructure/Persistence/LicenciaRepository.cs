using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.ValueObjects;

namespace Infrastructure.Persistence
{
    public class LicenciaRepository : ILicenciaRepository
    {

        private readonly IRepository<Licencia> repository;


        public LicenciaRepository(IRepository<Licencia> repository)
        {
            this.repository = repository;
        }

        public async Task<List<Licencia>> GetAll()
        {

            return await repository.GetAll();
        }
    }
}