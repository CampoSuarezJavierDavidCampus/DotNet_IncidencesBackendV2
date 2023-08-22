using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
{
    public DepartmentRepository(ApiIncidencesContext context) : base(context)
    {
    }
}
