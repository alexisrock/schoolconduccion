using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.ValueObjects;
using Infrastructure.Configuration;
using Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class PruebaContext : DbContext
    {

        public PruebaContext(DbContextOptions<PruebaContext> options) : base(options) { }
        public virtual DbSet<Modulo>? Modulo { get; set; }
        public virtual DbSet<Users>? Usuarios { get; set; }
        public virtual DbSet<Clase>? Clase { get; set; }
        public virtual DbSet<Licencia>? Licencia { get; set; }
 
        public virtual DbSet<InscripcionModulo>? InscripcionModulo { get; set; }
        public virtual DbSet<SPEstudiantes>? SPEstudiantes { get; set; }

        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new LicenciaConfiguration());
             modelBuilder.ApplyConfiguration(new MateriaProfesorConfiguration());
            modelBuilder.ApplyConfiguration(new ClaseConfiguration());
            modelBuilder.ApplyConfiguration(new InscripcionModuloConfiguration());

            modelBuilder.SpConfiguration();

        }
    }
}
