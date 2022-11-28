using System.ComponentModel.DataAnnotations;

namespace Api.Backend.Data.Dtos.Maladireta
{
    public class CreateMaladiretaDto
    {
  
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo de Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email em formato inválido.")]
        public string Email { get; set; }
        public int InstituicaoId { get; set; }
    }
}
