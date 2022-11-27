using Api.Backend.Data.Dtos.Usuario;
using Api.Backend.Domain.Models;
using AutoMapper;

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