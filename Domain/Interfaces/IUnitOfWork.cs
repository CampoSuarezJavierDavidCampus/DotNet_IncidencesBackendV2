namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ICityRepository Cities { get;}
        IClassroomRepository Classrooms { get;}
        ICountryRepository Countries { get;}
        IDepartmentRepository Departments { get;}
        IGenderRepository Genders { get;}
        IInscriptionRepository Inscriptions { get;}
        IPersonRepository Persons { get;}
        IPersonTypeRepository PersonTypes { get;}
        ITrainerClassroomRepository TrainerClassrooms { get;}

    }
}