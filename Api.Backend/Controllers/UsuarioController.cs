using Api.Backend.Data;
using Api.Backend.Data.Dtos.Usuario;
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
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UsuarioController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaUsuario([FromBody] CreateUsuarioDto usuarioDto)
        {
            Usuario usuario = _mapper.Map<Usuario>(usuarioDto);
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaUsuariosPorId), new { Id = usuario.Id }, usuario);
        }


        [HttpGet]
        [Authorize(Roles= "Administrador,Usuario")]
        public IEnumerable<Usuario> RecuperaUsuarios()
        {
            return _context.Usuarios;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult RecuperaUsuariosPorId(int id)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            if (usuario != null)
            {
                ReadUsuarioDto usuarioDto = _mapper.Map<ReadUsuarioDto>(usuario);
                return Ok(usuarioDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaUsuario(int id, [FromBody] UpdateUsuarioDto usuarioDto)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }
            _mapper.Map(usuarioDto, usuario);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaUsuario(int id)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }
            _context.Remove(usuario);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
