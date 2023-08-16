namespace Domain.Entities;
public class Gender: BaseEntity{
    public int IdGender { get; set; }
    public string? NameGender { get; set; }
    
    public IEnumerable<Person>? Persons { get; set; }
}
