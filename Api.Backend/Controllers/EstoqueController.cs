using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Backend.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Backend.Domain.Models;
using Api.Backend.Data.Dtos.Estoque;
using Api.Backend.Data.Dtos.Produto;

namespace Api.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstoqueController : ControllerBase
    {
        private  readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public EstoqueController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaEstoque([FromBody] CreateEstoqueDto estoqueDto)
        {
            Estoque estoque = _mapper.Map<Estoque>(estoqueDto);
            _context.Estoques.Add(estoque);
            _context.SaveChanges();
          

            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Id == estoque.ProdutoId);
 
            if (estoque.Tipo== Enums.Tipo.Entrada)
            {
                produto.Qtde = produto.Qtde + estoque.Qtde;
            }
            else
            {
                produto.Qtde = produto.Qtde - estoque.Qtde;
            }

            _context.Produtos.Update(produto);
             _context.SaveChanges();


            return CreatedAtAction(nameof(RecuperaEstoquesPorId), new { Id = estoque.Id }, estoque);
        }

        [HttpGet]
        public IEnumerable<Estoque> RecuperaEstoques()
        {
            return _context.Estoques.Include(x => x.Produto).Include(y => y.Campanha);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEstoquesPorId(int id)
        {
            Estoque estoque = _context.Estoques.FirstOrDefault(estoque => estoque.Id == id);
            if (estoque != null)
            {
                ReadEstoqueDto estoqueDto = _mapper.Map<ReadEstoqueDto>(estoque);
                return Ok(estoqueDto);
            }
            return NotFound();
        }

 

    }
}
