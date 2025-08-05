using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.NameUsuario).IsRequired();
            builder.Property(u => u.Identificacion);
            builder.Property(u => u.Edad).IsRequired();          
            builder.HasOne(u => u.Licencia)  
              .WithMany() 
              .HasForeignKey(u => u.IdLicencia)  
              .HasConstraintName("FK_Usuario_Ro")  
              .OnDelete(DeleteBehavior.Restrict);

        }


    }
}
