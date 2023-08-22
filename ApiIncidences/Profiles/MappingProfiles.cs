using ApiIncidences.Dtos;
using Domain;
using AutoMapper;
using Domain.Entities;
namespace ApiIncidences.Profiles;

public class MappingProfiles: Profile{
    public MappingProfiles(){
        CreateMap<Country, CountryDto>()
            .ReverseMap()
            .ForMember(c => c.IdCountry, opt => opt.MapFrom(src => src.PaisId))
            .ForMember(c => c.IdCountry, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(c => c.Departments, opt => opt.MapFrom(src => src.Departamentos));
        CreateMap<Department, DepartmentXCountryDto>().ReverseMap();        
        CreateMap<Department, DepartmentDto>().ReverseMap();        
    }
}