﻿using Api.Backend.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Backend.Data.Dtos.Usuario
{
    public class CreateUsuarioDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de Email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo de Senha é obrigatório")]
        public string Senha { get; set; }

        public Boolean Ativo { get; set; }

        public Funcao Funcao { get; set; }

    }
}
