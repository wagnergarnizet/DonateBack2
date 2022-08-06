using Api.Backend.Data.Dtos.Campanha;
using Api.Backend.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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