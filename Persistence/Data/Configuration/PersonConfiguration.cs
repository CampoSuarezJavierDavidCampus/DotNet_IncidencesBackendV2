using System.Collections.Immutable;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class PersonConfiguration: IEntityTypeConfiguration<Person>{
    public void Configure(EntityTypeBuilder<Person> builder){
        builder.ToTable("persona");
        builder.HasKey(p => p.IdPerson);

        builder.Property(p => p.IdPerson)
            .IsRequired()
            .HasColumnName("idPersona");

        builder.Property(p => p.NamePerson)
            .IsRequired()
            .HasColumnName("nombrePersona")
            .HasMaxLength(50);

        builder.Property(p => p.IdGenderFk)
            .IsRequired()
            .HasColumnName("idGeneroFk");
        
        builder.Property(p => p.IdCityFk)
            .IsRequired()
            .HasMaxLength(3)
            .HasColumnName("idCiudadFk");

        builder.Property(p => p.IdPersonTypeFk)
            .IsRequired()
            .HasColumnName("idTipoPersonaFk");

        builder.HasOne(p => p.Gender)
            .WithMany(p => p.Persons)
            .HasForeignKey(p => p.IdGenderFk);

        builder.HasOne(p => p.City)
            .WithMany(p => p.Persons)
            .HasForeignKey(p => p.IdCityFk);

        builder.HasOne(p => p.PersonType)
            .WithMany(p => p.Persons)
            .HasForeignKey(p => p.IdPersonTypeFk);
    }
}
