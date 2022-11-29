using Api.Backend.Enums;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Api.Backend.Domain.Models
{
    public class Estoque
    {
        [Key]
        [Required]
        public int Id { get; set; }

      
        public virtual Produto Produto { get; set; }
        public int ProdutoId { get; set; }

       
        public virtual Campanha Campanha { get; set; }
        public int? CampanhaId { get; set; }

        public int Qtde { get; set; }
        public Tipo Tipo { get; set; }
        public string Observacao { get; set; }


    }
}

