using Api.Backend.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Backend.Data.Dtos.Estoque
{
    public class CreateEstoqueDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int CampanhaId { get; set; }
        public int Qtde { get; set; }
        public Tipo Tipo { get; set; }
        public string Observacao { get; set; }
    }
}
