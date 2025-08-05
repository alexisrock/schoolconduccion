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
    public class InscripcionModuloConfiguration : IEntityTypeConfiguration<InscripcionModulo>
    {
        public void Configure(EntityTypeBuilder<InscripcionModulo> builder)
        {
            builder.ToTable("InscripcionMateria");
            builder.HasKey(u => u.Id);
            builder.HasOne(u => u.Modulo)
            .WithMany() 
            .HasForeignKey(x => x.IdModulo)
            .HasConstraintName("Fk_IdModulo_InscripcionModulo")
            .OnDelete(DeleteBehavior.Restrict);
        

            builder.HasOne(u => u.Usuario)
           .WithMany()
           .HasForeignKey(u => u.IdUsuario)
           .HasConstraintName("Fk_IdUsuario_InscripcionModulo")
           .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
