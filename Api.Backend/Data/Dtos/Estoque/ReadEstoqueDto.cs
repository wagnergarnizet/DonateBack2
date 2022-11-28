using Api.Backend.Enums;
using System.ComponentModel.DataAnnotations;

namespace Api.Backend.Data.Dtos.Estoque
{
    public class ReadEstoqueDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int Qtde { get; set; }
        public Tipo Tipo { get; set; }
        public string Observacao { get; set; }
        public virtual Api.Backend.Domain.Models.Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public virtual Api.Backend.Domain.Models.Campanha Campanha { get; set; }
        public int CampanhaId { get; set; }
    }
}
