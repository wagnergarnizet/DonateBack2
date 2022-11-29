using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Backend.Data.Dtos.Instituicao
{
    public class ReadInstituicaoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo de Cnpj é obrigatório")]
        public string Cnpj { get; set; }

        public string Endereco { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Bairro { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public string Logotipo { get; set; }

        public bool Ativo { get; set; }

        public string Descricao { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public int? UsuarioId { get; set; }

        public virtual List<Api.Backend.Domain.Models.Campanha> Campanhas { get; set; }
    }
}
