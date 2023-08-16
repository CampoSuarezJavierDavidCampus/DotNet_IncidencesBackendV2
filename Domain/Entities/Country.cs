namespace Domain.Entities;
public class Country: BaseEntity{
    public int IdCountry { get; set; }    
    public string? NameCountry { get; set; }
    
    public ICollection<Department>? Departments { get; set; }
}