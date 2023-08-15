using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    { 
        builder.ToTable("ciudad");
        builder.HasKey(c => c.IdCity);        
        builder.Property(c => c.IdCity)
            .HasColumnName("idCiudad")
            .IsRequired()
            .HasMaxLength(3);

        builder.Property(c => c.NameCity)
            .HasColumnName("nombreCiudad")
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(c => c.IdDepartmentFk)
            .HasColumnName("idDepFk")
            .IsRequired()
            .HasMaxLength(3);
        
        builder.HasOne(c => c.Department)
            .WithMany(d => d.Cities)
            .HasForeignKey(c => c.IdDepartmentFk);
    }
}
