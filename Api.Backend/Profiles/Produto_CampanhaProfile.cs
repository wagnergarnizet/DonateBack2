using Api.Backend.Data.Dtos.Campanha;
using Api.Backend.Data.Dtos.Produto_Campanha;
using Api.Backend.Domain.Models;
using AutoMapper;

namespace Api.Backend.Profiles
{
    public class Produto_CampanhaProfile : Profile
    {
        public Produto_CampanhaProfile()
        {
            CreateMap<CreateProduto_CampanhaDto, Produto_Campanha>();
            CreateMap<Produto_Campanha, ReadProduto_CampanhaDto>();
            CreateMap<UpdateProduto_CampanhaDto, Produto_Campanha>();
        }
    }
}

