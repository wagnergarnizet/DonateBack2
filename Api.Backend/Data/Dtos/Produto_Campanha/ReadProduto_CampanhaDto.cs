using System.ComponentModel.DataAnnotations;

namespace Api.Backend.Data.Dtos.Produto_Campanha
{
    public class ReadProduto_CampanhaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public virtual Api.Backend.Domain.Models.Produto Produto { get; set; }
        public int ProdutoId { get; set; }

        public virtual Api.Backend.Domain.Models.Campanha Campanha { get; set; }
        public int? CampanhaId { get; set; }

        public int Quantidade { get; set; }
    }
}
