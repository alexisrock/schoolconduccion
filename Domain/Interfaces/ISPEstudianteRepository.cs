using Domain.Entities;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISPEstudianteRepository
    {

        Task<List<SPEstudiantes>> GetAll();
    }
}
