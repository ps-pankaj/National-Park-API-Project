using AutoMapper;
using National_Park_Api_Project.Models;
using National_Park_Api_Project.Models.DTOs;

namespace National_Park_Api_Project.DTOMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NationalPark, NationalParkDto>().ReverseMap();
            CreateMap<TrailDto, Trail>().ReverseMap();
        }
    }
}
