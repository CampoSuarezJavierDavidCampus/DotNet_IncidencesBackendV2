using Domain.Entities;
using Persistence;

namespace Application.Repositories;
public class CountryRepository : GenericRepository<Country>
{
    public CountryRepository(ApiIncidencesContext context) : base(context)
    {
    }
}
