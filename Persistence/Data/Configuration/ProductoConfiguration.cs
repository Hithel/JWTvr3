
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
        {
            public void Configure(EntityTypeBuilder<Producto> builder)
            {
                builder.ToTable("Producto");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id);
    
                builder.Property(p => p.Nombre)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                builder.Property(p => p.Precio)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

                builder.HasOne(p => p.Marca)
                .WithMany(p => p.Productos)
                .HasForeignKey(p => p.MarcaId);

                builder.HasOne(p => p.Categoria)
                .WithMany(p => p.Productos)
                .HasForeignKey(p => p.CategoriaId);
            }
        }
