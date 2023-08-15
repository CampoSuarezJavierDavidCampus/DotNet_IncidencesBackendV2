using System.Data;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class ApiIncidencesContext : DbContext
{
    protected ApiIncidencesContext(DbContextOptions<ApiIncidencesContext> options):base(options){}

    public DbSet<City> Cities { get; set; }
    public DbSet<Classroom> Classrooms { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<Inscription> Inscriptions { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<PersonType> PersonTypes { get; set; }
    public DbSet<TrainerClassroom> TrainerClassrooms { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TrainerClassroom>().HasKey(r => new{r.IdClassroomFk,r.IdPerTrainerFk});
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}