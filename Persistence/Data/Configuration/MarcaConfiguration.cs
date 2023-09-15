
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
        {
            public void Configure(EntityTypeBuilder<Marca> builder)
            {
                builder.ToTable("Marca");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(p => p.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            }
        }
