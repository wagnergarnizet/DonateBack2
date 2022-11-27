using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Backend.Data.Dtos.Campanha
{
    public class CreateCampanhaDto
    {

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de Descrição é obrigatório")]
        public string Descricao { get; set; }

        public string Logotipo { get; set; }

        public bool Ativo { get; set; }

        public DateTime Dt_inicio { get; set; }

        public DateTime Dt_fim { get; set; }

        public int InstituicaoId { get; set; }

    }
}
