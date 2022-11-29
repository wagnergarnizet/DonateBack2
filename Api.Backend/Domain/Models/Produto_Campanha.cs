using System.ComponentModel.DataAnnotations;

namespace Api.Backend.Domain.Models
{
    public class Produto_Campanha
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public virtual Produto Produto  { get; set; }
        public int ProdutoId { get; set; }

        public virtual  Campanha Campanha { get; set; }
        public int? CampanhaId { get; set; }

        public int Quantidade { get; set; }


    }
}
