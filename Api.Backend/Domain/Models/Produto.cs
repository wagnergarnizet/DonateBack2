using Api.Backend.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Api.Backend.Domain.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        public int Qtde { get; set; }

        public Volume Volume { get; set; }

        public string Imagem { get; set; }

        public bool Ativo { get; set; }

        public virtual Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

        public virtual List<Estoque> Estoques { get; set; }
    }
}
