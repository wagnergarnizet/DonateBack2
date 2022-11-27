using Api.Backend.Data.Dtos.Campanha;
using Api.Backend.Domain.Models;
using AutoMapper;

namespace Api.Backend.Profiles
{
    public class CampanhaProfile : Profile
    {
        public CampanhaProfile()
        {
            CreateMap<CreateCampanhaDto, Campanha>();
            CreateMap<Campanha, ReadCampanhaDto>();
            CreateMap<UpdateCampanhaDto, Campanha>();
        }
    }
}