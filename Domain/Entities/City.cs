namespace Domain.Entities;
public class City{
    public int IdCity { get; set; }
    public string? NameCity { get; set; }

    public int IdDepartmentFk { get; set; }
    public Department? Department { get; set; }

    public ICollection<Person>? Persons { get; set; }
}
