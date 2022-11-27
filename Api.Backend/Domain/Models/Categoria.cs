using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Backend.Domain.Models
{
    public class Categoria
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }


        public virtual List<Produto> Produtos { get; set; }

    }
}
