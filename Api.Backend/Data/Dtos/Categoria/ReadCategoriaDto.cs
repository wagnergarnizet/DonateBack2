using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Api.Backend.Data.Dtos.Categoria
{
    public class ReadCategoriaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        public virtual List<Api.Backend.Domain.Models.Produto> Produtos { get; set; }

    }
}
