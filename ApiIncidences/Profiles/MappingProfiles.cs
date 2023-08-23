using ApiIncidences.Dtos;
using Domain;
using AutoMapper;
using Domain.Entities;
namespace ApiIncidences.Profiles;

public class MappingProfiles: Profile{
    public MappingProfiles(){
        CreateMap<CountriesDto, Country>()
            .ForMember(c => c.IdCountry, opt => opt.MapFrom(src => src.PaisId))
            .ForMember(c => c.NameCountry, opt => opt.MapFrom(src => src.Nombre))
            .ReverseMap();

        CreateMap<CountryDto, Country>()
            .ForMember(c => c.IdCountry, opt => opt.MapFrom(src => src.PaisId))
            .ForMember(c => c.NameCountry, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(c => c.Departments, opt => opt.MapFrom(src => src.Departamentos))
            .ReverseMap();




        CreateMap<Department, DepartmentsDto>().ReverseMap();        
        CreateMap<Department, DepartmentDto>().ReverseMap();        
    }
}