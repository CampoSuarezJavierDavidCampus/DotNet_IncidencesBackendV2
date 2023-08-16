using Domain.Entities;
using Persistence;

namespace Application.Repositories;

public class ClassroomRepository : GenericRepository<Classroom>
{
    public ClassroomRepository(ApiIncidencesContext context) : base(context)
    {
    }
}
