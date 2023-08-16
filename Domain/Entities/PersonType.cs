namespace Domain.Entities;
public class PersonType: BaseEntity{
    public int IdPersonType { get; set; }
    public string? DescriptionPersonType { get; set; }
    
    public ICollection<Person>? Persons { get; set; }
}