using AutoMapper;
using GB_WebAppCource.Controllers.Models;
using GB_WebAppCource.DAL.Entities;

namespace GB_WebAppCource.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Person, PersonDto>();
            CreateMap<PersonDto, Person>();
        }
    }
}
