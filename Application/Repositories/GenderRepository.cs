using Domain.Entities;
using Persistence;

namespace Application.Repositories;
public class GenderRepository : GenericRepository<Gender>
{
    public GenderRepository(ApiIncidencesContext context) : base(context)
    {
    }
}
