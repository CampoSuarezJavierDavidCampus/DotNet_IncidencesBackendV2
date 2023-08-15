namespace Domain.Entities;
public class Person{
    public string? IdPerson { get; set; }
    public string? NamePerson { get; set; }

    public int IdGenderFK { get; set; }
    public Gender? Gender { get; set; }

    public int IdCityFK { get; set; }
    public City? City { get; set; }

    public int IdPersonTypeFK  { get; set; }
    public PersonType? PersonType { get; set; }

    public ICollection<Inscription>? Inscriptions { get; set; }
    public ICollection<TrainerClassroom>? TrainerClassrooms { get; set; }
}
