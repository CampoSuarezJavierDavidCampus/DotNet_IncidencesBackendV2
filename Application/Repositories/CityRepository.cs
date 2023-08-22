using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public class CityRepository : GenericRepository<City>, ICityRepository
{
    public CityRepository(ApiIncidencesContext context) : base(context){}
}