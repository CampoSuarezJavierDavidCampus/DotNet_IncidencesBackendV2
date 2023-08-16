using Domain.Entities;
using Persistence;

namespace Application.Repositories;
public class PersonTypeRepository : GenericRepository<PersonType>
{
    public PersonTypeRepository(ApiIncidencesContext context) : base(context)
    {
    }
}