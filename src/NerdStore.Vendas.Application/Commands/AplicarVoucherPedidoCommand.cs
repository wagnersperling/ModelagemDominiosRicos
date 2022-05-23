using FluentValidation;
using NerdStore.Core.Messages;
using System;

namespace NerdStore.Vendas.Application.Commands
{
    public class AplicarVoucherPedidoCommand : Command
    {       
        public Guid ClienteId { get; private set; }
        public string CodigoVoucher{ get; private set; }

        public AplicarVoucherPedidoCommand(Guid clienteId, string codigoVoucher)
        {
            ClienteId = clienteId;
            CodigoVoucher = codigoVoucher;
        }

        public override bool EhValido()
        {
            validationResult = new AplicarVoucherPedidoValidation().Validate(this);
            return validationResult.IsValid;
        }
    }

    public class AplicarVoucherPedidoValidation : AbstractValidator<AplicarVoucherPedidoCommand>
    {
        public AplicarVoucherPedidoValidation()
        {
            RuleFor(c => c.ClienteId)
                .NotEqual(Guid.Empty)
                .WithMessage("Id do cliente inválido");

            RuleFor(c => c.CodigoVoucher)
                .NotEmpty()
                .WithMessage("O código do vaucher não pode ser vazio");
        }
    }
}
