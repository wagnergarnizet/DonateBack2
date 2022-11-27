using System.ComponentModel.DataAnnotations;

namespace Api.Backend.Data.Dtos.Categoria
{
    public class UpdateCategoriaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
    }
}
