using Api.Backend.Data.Dtos.Produto;
using Api.Backend.Domain.Models;
using AutoMapper;

namespace Api.Backend.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<Produto, ReadProdutoDto>();
            CreateMap<UpdateProdutoDto, Produto>();
        }
    }
}