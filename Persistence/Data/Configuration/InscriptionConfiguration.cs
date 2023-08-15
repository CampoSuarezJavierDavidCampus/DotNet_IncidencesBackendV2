using System;
using System.Collections.Immutable;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class InscriptionConfiguration : IEntityTypeConfiguration<Inscription>
{
    public void Configure(EntityTypeBuilder<Inscription> builder)
    {
        builder.ToTable("matricula");
        builder.HasKey(i => i.IdInscription);

        builder.Property(i => i.IdInscription)
            .IsRequired()
            .HasColumnName("idMatricula");

        builder.Property(i => i.IdPersonFk)
            .IsRequired()
            .HasColumnName("idPersonaFk");
        
        builder.Property(i => i.IdClassroomFk)
            .IsRequired()
            .HasColumnName("idSalonFk");

        builder.HasOne(i => i.Person)
            .WithMany(p => p.Inscriptions)
            .HasForeignKey(i => i.IdPersonFk);

        builder.HasOne(i => i.Classroom)
            .WithMany(p => p.Inscriptions)
            .HasForeignKey(i => i.IdClassroomFk);
    }
}
