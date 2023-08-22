using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public class PersonTypeRepository : GenericRepository<PersonType>, IPersonTypeRepository
{
    public PersonTypeRepository(ApiIncidencesContext context) : base(context)
    {
    }
}