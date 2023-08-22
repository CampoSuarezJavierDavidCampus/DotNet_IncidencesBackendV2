using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public class InscriptionRepository: GenericRepository<Inscription>, IInscriptionRepository{
    public InscriptionRepository(ApiIncidencesContext context):base(context) {}
}