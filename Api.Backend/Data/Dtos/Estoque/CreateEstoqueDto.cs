using Api.Backend.Enums;
using System.ComponentModel.DataAnnotations;

namespace Api.Backend.Data.Dtos.Estoque
{
    public class CreateEstoqueDto
    {

        public int ProdutoId { get; set; }
        public int? CampanhaId { get; set; }
        public int Qtde { get; set; }
        public Tipo Tipo { get; set; }
        public string Observacao { get; set; }
    }
}
