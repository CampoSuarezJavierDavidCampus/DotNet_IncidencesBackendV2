namespace Domain.Entities;
public class City: BaseEntity{
    public int IdCity { get; set; }
    public string? NameCity { get; set; }

    public int IdDepartmentFk { get; set; }
    public Department? Department { get; set; }

    public ICollection<Person>? Persons { get; set; }
}
