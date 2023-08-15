using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class ClassroomConfiguration:IEntityTypeConfiguration<Classroom>{
    public void Configure(EntityTypeBuilder<Classroom> builder){
        builder.ToTable("salon");
        builder.HasKey(c => c.IdClassroom);
        builder.Property(c => c.IdClassroom)
            .IsRequired()
            .HasColumnName("idSalon");
        
        builder.Property(c => c.NameClassroom)
            .IsRequired()
            .HasColumnName("nombreSalon")
            .HasMaxLength(50);

        builder.Property(c => c.Capacity)
            .IsRequired()
            .HasColumnName("capasidadSalon");
    }
}