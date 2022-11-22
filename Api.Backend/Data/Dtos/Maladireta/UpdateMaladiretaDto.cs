using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Backend.Data.Dtos.Maladireta
{
    public class UpdateMaladiretaDto
    {
        [Key]
        [Required]

        public int ProdutoId { get; set; }

        public int CampanhaId { get; set; }

        public int Quantidade { get; set; }
    }
}
