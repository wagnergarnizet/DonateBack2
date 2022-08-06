using Api.Backend.Data.Dtos.Produto;
using Api.Backend.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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