using Domain.Entities;
using Persistence;

namespace Application.Repositories;
public class TrainerClassroomRepository : GenericRepository<TrainerClassroom>
{
    public TrainerClassroomRepository(ApiIncidencesContext context) : base(context)
    {
    }
}
