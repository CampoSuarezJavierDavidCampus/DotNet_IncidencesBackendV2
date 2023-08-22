using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public class PersonRepository : GenericRepository<Person>, IPersonRepository
{
    public PersonRepository(ApiIncidencesContext context) : base(context){}
}
