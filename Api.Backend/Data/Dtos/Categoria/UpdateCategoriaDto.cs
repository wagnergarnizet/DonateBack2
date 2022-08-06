using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Backend.Data.Dtos.Categoria
{
    public class UpdateCategoriaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
    }
}
