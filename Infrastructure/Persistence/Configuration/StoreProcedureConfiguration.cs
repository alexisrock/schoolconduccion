using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Configuration
{
    internal static  class StoreProcedureConfiguration
    {



        internal static ModelBuilder SpConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SPEstudiantes>().HasNoKey().ToView("SPEstudiantes");
        

            
            return modelBuilder;
        }


    }
}
