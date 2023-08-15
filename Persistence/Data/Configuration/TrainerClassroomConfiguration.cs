using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class TrainerClassroomConfiguration:IEntityTypeConfiguration<TrainerClassroom>{
    public void Configure(EntityTypeBuilder<TrainerClassroom> builder){
        builder.ToTable("trainerSalon");
        builder.Property(tc => tc.IdPerTrainerFk)
            .IsRequired()
            .HasColumnName("idPerTrainerFk");

        builder.Property(tc => tc.IdClassroomFk)
            .IsRequired()
            .HasColumnName("idSalonFk");
        
        builder.HasOne(tc => tc.Person)
            .WithMany(tc => tc.TrainerClassrooms)
            .HasForeignKey(tc => tc.IdPerTrainerFk);
        
        builder.HasOne(tc => tc.Classroom)
            .WithMany(tc => tc.TrainerClassrooms)
            .HasForeignKey(tc => tc.IdClassroomFk);
    }
}
