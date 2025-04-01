﻿using System.ComponentModel.DataAnnotations;

namespace MBA.Marketplace.Core.DTOs
{
    public class RegistrarUsuarioDto
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Display(Name = "Nome completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "A confirmação da senha é obrigatória.")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
        public string ConfirmacaoSenha { get; set; }
    }
}
