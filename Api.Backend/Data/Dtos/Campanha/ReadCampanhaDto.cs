using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Backend.Data.Dtos.Campanha
{
    public class ReadCampanhaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de Descrição é obrigatório")]
        public string Descricao { get; set; }

        public string Logotipo { get; set; }

        public bool Ativo { get; set; }

        public DateTime Dt_inicio { get; set; }

        public DateTime Dt_fim { get; set; }

        public Api.Backend.Domain.Models.Instituicao Instituicao { get; set; }
        public int InstituicaoId { get; set; }

        public virtual List<Api.Backend.Domain.Models.Estoque> Estoques { get; set; }
    }
}
