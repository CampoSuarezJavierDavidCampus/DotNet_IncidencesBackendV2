using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class DepartmentConfiguration:IEntityTypeConfiguration<Department>{
    public void Configure(EntityTypeBuilder<Department> builder){
        builder.ToTable("departamento");
        builder.HasKey(d => d.IdDepartment);
        builder.Property(d => d.IdDepartment)
            .IsRequired()
            .HasColumnName("idDep")
            .HasMaxLength(3);
        
        builder.Property(d => d.NameDepartment)
            .IsRequired()
            .HasColumnName("nombreDep")
            .HasMaxLength(50);

        builder.Property(d => d.IdCountryFk)
            .IsRequired()
            .HasColumnName("idPaisFk")
            .HasMaxLength(3);

        builder.HasOne(d => d.Country)
            .WithMany(c => c.Departments)
            .HasForeignKey(d => d.IdCountryFk);
        
    }    
}
