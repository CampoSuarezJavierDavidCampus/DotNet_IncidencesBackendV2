namespace ApiIncidences.Dtos
{
    public class CountryDto: CountriesDto
    {       
        public IEnumerable<DepartmentsDto> Departamentos { get; set; } = new HashSet<DepartmentsDto>();
    }
}