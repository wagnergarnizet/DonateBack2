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
            return CreatedAtAction(nameof(RecuperaEstoquesPorId), new { Id = estoque.Id }, estoque);
        }

        [HttpGet]
        public IEnumerable<Estoque> RecuperaEstoques()
        {
            return _context.Estoques;
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

        [HttpPut("{id}")]
        public IActionResult AtualizaEstoque(int id, [FromBody] UpdateEstoqueDto estoqueDto)
        {
            Estoque estoque = _context.Estoques.FirstOrDefault(estoque => estoque.Id == id);
            if (estoque == null)
            {
                return NotFound();
            }
            _mapper.Map(estoqueDto, estoque);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaEstoque(int id)
        {
            Estoque estoque = _context.Estoques.FirstOrDefault(estoque => estoque.Id == id);
            if (estoque == null)
            {
                return NotFound();
            }
            _context.Remove(estoque);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
