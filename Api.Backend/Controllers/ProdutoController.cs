using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Backend.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Backend.Domain.Models;
using Api.Backend.Data.Dtos.Produto;

namespace Api.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProdutoController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaProduto([FromBody] CreateProdutoDto produtoDto)
        {
            Produto produto = _mapper.Map<Produto>(produtoDto);
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaProdutosPorId), new { Id = produto.Id }, produto);
        }

        [HttpGet]
        public IEnumerable<Produto> RecuperaProdutos()
        {
            return _context.Produtos;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaProdutosPorId(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto != null)
            {
                ReadProdutoDto produtoDto = _mapper.Map<ReadProdutoDto>(produto);
                return Ok(produtoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaProduto(int id, [FromBody] UpdateProdutoDto produtoDto)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            _mapper.Map(produtoDto, produto);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaProduto(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            _context.Remove(produto);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
