namespace Domain.Entities;
public class Department{
    public int IdDepartment { get; set; }
    public string? NameDepartment { get; set; }

    public int IdCountryFk { get; set; }
    public Country? Country { get; set; }

    public IEnumerable<City>? Cities { get; set; }
}
