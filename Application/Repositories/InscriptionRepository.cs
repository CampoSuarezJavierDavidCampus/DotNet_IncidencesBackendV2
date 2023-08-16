using Domain.Entities;
using Persistence;

namespace Application.Repositories;
public class InscriptionRepository: GenericRepository<Inscription>{
    public InscriptionRepository(ApiIncidencesContext context):base(context) {}
}