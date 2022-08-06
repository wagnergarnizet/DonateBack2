using Api.Backend.Data;
using Api.Backend.Data.Dtos.Maladireta;
using Api.Backend.Domain.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaladiretaController: ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public MaladiretaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult AdicionaMaladireta([FromBody] CreateMaladiretaDto maladiretaDto)
        {
            Maladireta maladireta = _mapper.Map<Maladireta>(maladiretaDto);
            _context.Maladiretas.Add(maladireta);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaMaladiretasPorId), new { Id = maladireta.Id }, maladireta);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaMaladiretasPorId(int id)
        {
            Maladireta maladireta = _context.Maladiretas.FirstOrDefault(maladireta => maladireta.Id == id);
            if (maladireta != null)
            {
                ReadMaladiretaDto maladiretaDto = _mapper.Map<ReadMaladiretaDto>(maladireta);
                return Ok(maladiretaDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaMaladireta(int id, [FromBody] UpdateMaladiretaDto maladiretaDto)
        {
            Maladireta maladireta = _context.Maladiretas.FirstOrDefault(maladireta => maladireta.Id == id);
            if (maladireta == null)
            {
                return NotFound();
            }
            _mapper.Map(maladiretaDto, maladireta);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaMaladireta(int id)
        {
            Maladireta maladireta = _context.Maladiretas.FirstOrDefault(maladireta => maladireta.Id == id);
            if (maladireta == null)
            {
                return NotFound();
            }
            _context.Remove(maladireta);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
