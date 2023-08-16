using Domain.Entities;
using Persistence;

namespace Application.Repositories;
public class DepartmentRepository : GenericRepository<Department>
{
    public DepartmentRepository(ApiIncidencesContext context) : base(context)
    {
    }
}
