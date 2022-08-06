using Api.Backend.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Backend.Data.Dtos.Produto
{
    public class UpdateProdutoDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        public int Qtde { get; set; }

        public Volume Volume { get; set; }

        public string Imagem { get; set; }

        public bool Ativo { get; set; }

        public int CategoriaId { get; set; }

    }
}
