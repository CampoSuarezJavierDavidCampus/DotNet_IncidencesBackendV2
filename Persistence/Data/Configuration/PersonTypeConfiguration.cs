using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class PersonTypeConfiguration:IEntityTypeConfiguration<PersonType>{
    public void Configure(EntityTypeBuilder<PersonType> builder){
        builder.ToTable("tipoPersona");
        builder.HasKey(tp => tp.IdPersonType);

        builder.Property(tp => tp.IdPersonType)
            .IsRequired()
            .HasColumnName("idTipoPersona");
        
        builder.Property(tp => tp.DescriptionPersonType)
            .IsRequired()
            .HasColumnName("descripcionTipoPersona")
            .HasMaxLength(50);                
    }
}