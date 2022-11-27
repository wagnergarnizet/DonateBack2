using Api.Backend.Enums;

namespace Api.Backend.Data.Dtos.Estoque
{
    public class UpdateEstoqueDto
    {
        public int ProdutoId { get; set; }
        public int CampanhaId { get; set; }
        public int Qtde { get; set; }
        public Tipo Tipo { get; set; }
        public string Observacao { get; set; }
    }
}
