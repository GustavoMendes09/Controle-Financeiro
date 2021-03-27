﻿using ControleFinanceiro.API.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.API.Validacoes
{
    public class AtualizarUsuarioViewModelValidator : AbstractValidator<AtualizarUsuarioViewModel>
    {

        public AtualizarUsuarioViewModelValidator()
        {
            RuleFor(r => r.UserName)
                .NotNull().WithMessage("Preencha o nome de usuario")
                .NotEmpty().WithMessage("Preencha o nome de usuario")
                .MinimumLength(6).WithMessage("Use mais caracteres")
                .MaximumLength(50).WithMessage("Use menos caracteres");

            RuleFor(c => c.CPF)
                .NotNull().WithMessage("Preencha o CPF")
                .NotEmpty().WithMessage("Preencha o CPF")
                .MinimumLength(1).WithMessage("Use mais caracteres")
                .MaximumLength(20).WithMessage("Use menos caracteres");

            RuleFor(c => c.Profissao)
                .NotNull().WithMessage("Preencha a profissão")
                .NotEmpty().WithMessage("Preencha a profissão")
                .MinimumLength(1).WithMessage("Use mais caracteres")
                .MaximumLength(30).WithMessage("Use menos caracteres");

            RuleFor(c => c.Foto)
                .NotNull().WithMessage("Escolha a foto")
                .NotEmpty().WithMessage("Escolha a foto");

            RuleFor(c => c.Email)
                .NotNull().WithMessage("Preencha o email")
                .NotEmpty().WithMessage("Preencha o email")
                .MinimumLength(10).WithMessage("Use mais caracteres")
                .MaximumLength(50).WithMessage("Use menos caracteres")
                .EmailAddress().WithMessage("Email invalido");
        }
    }
}
