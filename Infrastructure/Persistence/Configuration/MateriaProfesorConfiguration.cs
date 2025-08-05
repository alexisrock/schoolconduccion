using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration
{
    public class MateriaProfesorConfiguration : IEntityTypeConfiguration<Modulo>
    {
        public void Configure(EntityTypeBuilder<Modulo> builder)
        {
            builder.ToTable("MateriaProfesor");
            builder.HasKey(u => u.Id);
            builder.HasOne(u => u.Clase)
            .WithMany()
            .HasForeignKey(u => u.IdMateria)
            .HasConstraintName("Fk_IdMateria_Modulo")
            .OnDelete(DeleteBehavior.Restrict);

      
        }
    }
}

