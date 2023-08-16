namespace Domain.Entities;
public class Person: BaseEntity{
    public string? IdPerson { get; set; }
    public string? NamePerson { get; set; }

    public int IdGenderFk { get; set; }
    public Gender? Gender { get; set; }

    public int IdCityFk { get; set; }
    public City? City { get; set; }

    public int IdPersonTypeFk  { get; set; }
    public PersonType? PersonType { get; set; }

    public ICollection<Inscription>? Inscriptions { get; set; }
    public ICollection<TrainerClassroom>? TrainerClassrooms { get; set; }
}
