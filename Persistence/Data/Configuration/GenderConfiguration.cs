using System.Collections.Immutable;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class GenderConfiguration:IEntityTypeConfiguration<Gender>
{
    public void Configure(EntityTypeBuilder<Gender> builder)
    {
        builder.ToTable("genero");
        builder.HasKey(g => g.IdGender);

        builder.Property(g => g.IdGender)
            .IsRequired()
            .HasColumnName("idGenero");
        
        builder.Property(g => g.NameGender)
            .IsRequired()
            .HasColumnName("nombreGenero")
            .HasMaxLength(50);                
    }
}
