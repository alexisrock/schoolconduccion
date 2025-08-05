using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration
{
    public class LicenciaConfiguration : IEntityTypeConfiguration<Licencia>
    {
        public void Configure(EntityTypeBuilder<Licencia> builder)
        {
            builder.ToTable("Licencia");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Description).IsRequired();
        }
    }
}
