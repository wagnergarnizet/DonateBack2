using Api.Backend.Data.Dtos.Instituicao;
using Api.Backend.Domain.Models;
using AutoMapper;

namespace Api.Backend.Profiles
{
    public class InstituicaoProfile : Profile
    {
        public InstituicaoProfile()
        {
            CreateMap<CreateInstituicaoDto, Instituicao>();
            CreateMap<Instituicao, ReadInstituicaoDto>();
            CreateMap<UpdateInstituicaoDto, Instituicao>();
        }
    }
}