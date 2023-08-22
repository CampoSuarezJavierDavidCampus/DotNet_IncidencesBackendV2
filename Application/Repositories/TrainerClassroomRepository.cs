using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public class TrainerClassroomRepository : GenericRepository<TrainerClassroom>, ITrainerClassroomRepository
{
    public TrainerClassroomRepository(ApiIncidencesContext context) : base(context)
    {
    }
}
