using Domain.Entities;
using Persistence;

namespace Application.Repositories;
public class CityRepository : GenericRepository<City>
{
    public CityRepository(ApiIncidencesContext context) : base(context){}
}