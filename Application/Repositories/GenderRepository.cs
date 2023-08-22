using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public class GenderRepository : GenericRepository<Gender>, IGenderRepository
{
    public GenderRepository(ApiIncidencesContext context) : base(context)
    {
    }
}
