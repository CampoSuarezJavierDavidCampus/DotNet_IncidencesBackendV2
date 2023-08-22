using System.Security.Cryptography.X509Certificates;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public class CountryRepository : GenericRepository<Country>, ICountryRepository
{
    private readonly ApiIncidencesContext _Context;
    public CountryRepository(ApiIncidencesContext context) : base(context)=>_Context = context;

    public override async Task<IEnumerable<Country>> GetAllAsync(){
        return await _Context.Countries.Include(p=>p.Departments).ToListAsync();
    }
}
