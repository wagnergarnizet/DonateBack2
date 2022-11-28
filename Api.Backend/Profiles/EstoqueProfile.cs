using Api.Backend.Data.Dtos.Estoque;
using Api.Backend.Domain.Models;
using AutoMapper;

namespace Api.Backend.Profiles
{
    public class EstoqueProfile : Profile
    {
        public EstoqueProfile()
        {
            CreateMap<CreateEstoqueDto, Estoque>();
            CreateMap<Estoque, ReadEstoqueDto>();
            CreateMap<UpdateEstoqueDto, Estoque>();
        }
    }
}