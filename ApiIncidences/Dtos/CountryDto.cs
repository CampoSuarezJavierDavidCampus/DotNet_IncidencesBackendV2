namespace ApiIncidences.Dtos
{
    public class CountryDto
    {
        public int PaisId { get; set; }
        public string Nombre { get; set; } = String.Empty;

        public IEnumerable<DepartmentXCountryDto> Departamentos { get; set; } = new HashSet<DepartmentXCountryDto>();
    }
}