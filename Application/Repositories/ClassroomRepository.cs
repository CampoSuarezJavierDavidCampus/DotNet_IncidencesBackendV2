using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;

public class ClassroomRepository : GenericRepository<Classroom>, IClassroomRepository
{
    public ClassroomRepository(ApiIncidencesContext context) : base(context)
    {
    }
}
