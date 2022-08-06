using Api.Backend.Data.Dtos.Usuario;
using Api.Backend.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Backend.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
            CreateMap<Usuario, ReadUsuarioDto>();
            CreateMap<Usuario, LoginUsuarioDto>();
            CreateMap<UpdateUsuarioDto, Usuario>();
        }
    }
}