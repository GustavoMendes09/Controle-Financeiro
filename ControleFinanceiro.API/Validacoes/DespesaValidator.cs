using ControleFinanceiro.BLL.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.API.Validacoes
{
    public class DespesaValidator : AbstractValidator<Despesa>
    {

        public DespesaValidator()
        {
            RuleFor(d => d.CartaoId)
               .NotNull().WithMessage("Escolha o cartão")
               .NotEmpty().WithMessage("Escolha o cartão");

            RuleFor(d => d.Descricao)
               .NotNull().WithMessage("Preencha a descrição")
               .NotEmpty().WithMessage("Preencha a descrição")
               .MinimumLength(1).WithMessage("Use mais caracteres")
               .MaximumLength(50).WithMessage("Preencha o número do cartão");

            RuleFor(d => d.Valor)
               .NotNull().WithMessage("Preencha o valor")
               .NotEmpty().WithMessage("Preencha o valor")
               .InclusiveBetween(0, double.MaxValue).WithMessage("Valor inválido");

            RuleFor(d => d.MesId)
               .NotNull().WithMessage("Escolha o mês")
               .NotEmpty().WithMessage("Escolha o mês");

            RuleFor(d => d.Ano)
               .NotNull().WithMessage("Escolha o ano")
               .NotEmpty().WithMessage("Escolha o ano")
               .InclusiveBetween(2016, 2030).WithMessage("Valor inválido");
        }

    }
}
