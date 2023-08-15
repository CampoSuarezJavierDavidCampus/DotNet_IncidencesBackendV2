using System.Collections.Immutable;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class CountryConfiguration: IEntityTypeConfiguration<Country>{
   public void Configure(EntityTypeBuilder<Country> builder) {
        builder.ToTable("pais");
        builder.HasKey(p => p.IdCountry);

        builder.Property(p => p.IdCountry)
            .IsRequired()
            .HasColumnName("idPais")
            .HasMaxLength(3);

        builder.Property(p => p.NameCountry)
            .IsRequired()
            .HasColumnName("nombrePais")
            .HasMaxLength(50);        
   }
}
