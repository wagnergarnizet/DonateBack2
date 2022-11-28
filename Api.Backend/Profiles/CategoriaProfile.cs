using Api.Backend.Data.Dtos.Categoria;
using Api.Backend.Domain.Models;
using AutoMapper;

namespace Api.Backend.Profiles
{
    public class CategoriaProfile : Profile
    {
        public CategoriaProfile()
        {
            CreateMap<CreateCategoriaDto, Categoria>();
            CreateMap<Categoria, ReadCategoriaDto>();
            CreateMap<UpdateCategoriaDto, Categoria>();
        }
    }
}
