using Domain.Entities;
using Persistence;

namespace Application.Repositories;
public class PersonRepository : GenericRepository<Person>
{
    public PersonRepository(ApiIncidencesContext context) : base(context){}
}
