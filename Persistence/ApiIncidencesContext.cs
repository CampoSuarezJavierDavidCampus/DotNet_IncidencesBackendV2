using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class ApiIncidencesContext : DbContext
{
    protected ApiIncidencesContext(DbContextOptions<ApiIncidencesContext> options):base(options){}
}