using Api.Backend.Data;
using Api.Backend.Data.Dtos.Categoria;
using Api.Backend.Domain.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Api.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private  readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CategoriaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaCategoria([FromBody] CreateCategoriaDto categoriaDto)
        {
            Categoria categoria = _mapper.Map<Categoria>(categoriaDto);
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaCategoriasPorId), new { Id = categoria.Id }, categoria);
        }

        [HttpGet]
        [Authorize(Roles = "Administrador,Usuario")]
        public IEnumerable<Categoria> RecuperaCategorias()
        {
            return _context.Categorias;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult RecuperaCategoriasPorId(int id)
        {
            Categoria categoria = _context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            if (categoria != null)
            {
                ReadCategoriaDto categoriaDto = _mapper.Map<ReadCategoriaDto>(categoria);
                return Ok(categoriaDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Administrador,Usuario")]
        public IActionResult AtualizaCategoria(int id, [FromBody] UpdateCategoriaDto categoriaDto)
        {
            Categoria categoria = _context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            if (categoria == null)
            {
                return NotFound();
            }
            _mapper.Map(categoriaDto, categoria);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrador,Usuario")]
        public IActionResult DeletaCategoria(int id)
        {
            Categoria categoria = _context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            if (categoria == null)
            {
                return NotFound();
            }
            _context.Remove(categoria);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
