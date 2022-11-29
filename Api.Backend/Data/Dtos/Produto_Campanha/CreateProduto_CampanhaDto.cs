namespace Api.Backend.Data.Dtos.Produto_Campanha
{
    public class CreateProduto_CampanhaDto
    {
        public int ProdutoId { get; set; }

        public int? CampanhaId { get; set; }

        public int Quantidade { get; set; }
    }
}
