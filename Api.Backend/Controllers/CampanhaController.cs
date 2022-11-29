using Api.Backend.Data;
using Api.Backend.Data.Dtos.Campanha;
using Api.Backend.Domain.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Api.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampanhaController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CampanhaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaCampanha([FromBody] CreateCampanhaDto campanhaDto)
        {
            Campanha campanha = _mapper.Map<Campanha>(campanhaDto);
            _context.Campanhas.Add(campanha);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaCampanhasPorId), new { Id = campanha.Id }, campanha);
        }

        [HttpGet]
        public IEnumerable<Campanha> RecuperaCampanhas()
        {
            return _context.Campanhas;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCampanhasPorId(int id)
        {
            Campanha campanha = _context.Campanhas.FirstOrDefault(campanha => campanha.Id == id);
            if (campanha != null)
            {
                ReadCampanhaDto campanhaDto = _mapper.Map<ReadCampanhaDto>(campanha);
                return Ok(campanhaDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCampanha(int id, [FromBody] UpdateCampanhaDto campanhaDto)
        {
            Campanha campanha = _context.Campanhas.FirstOrDefault(campanha => campanha.Id == id);
            if (campanha == null)
            {
                return NotFound();
            }
            _mapper.Map(campanhaDto, campanha);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaCampanha(int id)
        {
            Campanha campanha = _context.Campanhas.FirstOrDefault(campanha => campanha.Id == id);
            if (campanha == null)
            {
                return NotFound();
            }
            campanha.Ativo = false;
            _context.SaveChanges();
            return NoContent();
        }

    }
}
