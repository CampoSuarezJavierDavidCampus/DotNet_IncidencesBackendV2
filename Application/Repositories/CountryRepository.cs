using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public class CountryRepository : GenericRepository<Country>, ICountryRepository
{
    public CountryRepository(ApiIncidencesContext context) : base(context)
    {
    }
}
