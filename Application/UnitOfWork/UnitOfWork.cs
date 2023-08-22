using Application.Repositories;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork, IDisposable
    {   
        private ICityRepository? _City;
        private IClassroomRepository? _Classroom;
        private ICountryRepository? _Country;
        private IDepartmentRepository? _Department;
        private IGenderRepository? _Gender;
        private IInscriptionRepository? _Inscription;
        private IPersonRepository? _Person;
        private IPersonTypeRepository? _PersonType;
        private ITrainerClassroomRepository? _TrainerClassroom;

        private readonly ApiIncidencesContext _Context;

        public ICityRepository Cities => _City??= new CityRepository(_Context);
        
        public IClassroomRepository Classrooms => _Classroom??= new ClassroomRepository(_Context);
        
        public ICountryRepository Countries => _Country??= new CountryRepository(_Context);
        
        public IDepartmentRepository Departments => _Department??= new DepartmentRepository(_Context);
        
        public IGenderRepository Genders => _Gender??= new GenderRepository(_Context);
        
        public IInscriptionRepository Inscriptions => _Inscription??= new InscriptionRepository(_Context);
        
        public IPersonRepository Persons => _Person??= new PersonRepository(_Context);
        
        public ITrainerClassroomRepository TrainerClassrooms => _TrainerClassroom??= new TrainerClassroomRepository(_Context);

        public IPersonTypeRepository PersonTypes => _PersonType ??= new PersonTypeRepository(_Context);

        public UnitOfWork(ApiIncidencesContext context)=>_Context = context;

        public int Save()=>_Context.SaveChanges();
        public async Task<int> SaveAsync()=> await _Context.SaveChangesAsync();
        public void Dispose() => _Context.Dispose();
    }
}