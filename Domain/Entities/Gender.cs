namespace Domain.Entities;
public class Gender{
    public int IdGender { get; set; }
    public string? NameGender { get; set; }
    
    public IEnumerable<Person>? Persons { get; set; }
}
