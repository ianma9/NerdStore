using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using NerdStore.Core.DomainObjects;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace NerdStore.Vendas.Domain
{
    public class Voucher : Entity
    {
        public string Codigo { get; private set; }
        public decimal? Percentual { get; private set; }
        public decimal? ValorDesconto { get; private set; }
        public int Quantidade { get; private set; }
        public TipoDescontoVoucher TipoDescontoVoucher { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime? DataUtilizacao { get; private set; }
        public DateTime DataValidade { get; private set; }
        public bool Ativo { get; private set; }
        public bool Utilizado { get; private set; }

        // EF Relation
        public ICollection<Pedido> Pedidos { get; set; }

        public ValidationResult ValidarSeAplicavel()
        {
            return new VoucherAplicavelValidation().Validate(this);
        }

    }

    public class VoucherAplicavelValidation : AbstractValidator<Voucher>
    {
        public VoucherAplicavelValidation()
        {
            RuleFor(c => c.DataValidade)
                .Must(DatadeVencimentoSuperiorAtual)
                .WithMessage("Voucher expirado");

            RuleFor(c => c.Ativo)
                .Equal(true)
                .WithMessage("Voucher inválido");

            RuleFor(c => c.Utilizado)
                .Equal(false)
                .WithMessage("Voucher inválido");
            RuleFor(c => c.Quantidade)
                .GreaterThan(0)
                .WithMessage("Voucher indisponível");
        }

        private static bool DatadeVencimentoSuperiorAtual(DateTime dataValidade)
        {
            return dataValidade >= DateTime.Now;
        }
    }
}