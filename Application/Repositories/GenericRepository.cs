using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public class GenericRepository<T> where T : BaseEntity
{
    private readonly ApiIncidencesContext _context;
    public GenericRepository(ApiIncidencesContext context)=>_context = context;

    public virtual void Add(T entity)=>_context.Set<T>().Add(entity);

    public virtual void AddRange(IEnumerable<T> entities)=>_context.Set<T>().AddRange(entities);

    public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)=>_context.Set<T>().Where(expression);

    public virtual async Task<IEnumerable<T>> GetAllAsync()=> await _context.Set<T>().ToListAsync();

    public virtual async Task<T> GetByIdAsync(string id)=>(await _context.Set<T>().FindAsync(id))!;

    public virtual void Remove(T entity)=>_context.Remove(entity);

    public virtual void RemoveRange(IEnumerable<T> entities)=>RemoveRange(entities);

    public virtual void Update(T entity)=>_context.Update(entity);
}
