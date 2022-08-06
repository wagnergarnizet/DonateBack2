using Api.Backend.Data.Dtos.Maladireta;
using Api.Backend.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Backend.Profiles
{
    public class MaladiretaProfile : Profile
    {
        public MaladiretaProfile()
        {
            CreateMap<CreateMaladiretaDto, Maladireta>();
            CreateMap<Maladireta, ReadMaladiretaDto>();
            CreateMap<UpdateMaladiretaDto, Maladireta>();
        }
    }
}
