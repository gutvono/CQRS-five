using FluentValidation;
using System.Text.RegularExpressions;

namespace Domain.Commands.v1.UpdateCustomerAddress
{
    public class UpdateCustomerAddressCommandValidator : AbstractValidator<UpdateCustomerAddressCommand>
    {
        private const int StateLength = 2;

        public UpdateCustomerAddressCommandValidator()
        {
            RuleFor(updateCustomerAddressCommand => updateCustomerAddressCommand.Id)
                .NotEmpty().WithMessage($"Informe o ID do cliente!");

            RuleFor(updateCustomerAddressCommand => updateCustomerAddressCommand.Address.Street)
                .NotEmpty().WithMessage($"O campo {{PropertyName}} é obrigatório!");

            RuleFor(updateCustomerAddressCommand => updateCustomerAddressCommand.Address.Number)
                .NotEmpty().WithMessage($"O campo {{PropertyName}} é obrigatório!");

            RuleFor(updateCustomerAddressCommand => updateCustomerAddressCommand.Address.City)
                .NotEmpty().WithMessage($"O campo {{PropertyName}} é obrigatório!");

            RuleFor(updateCustomerAddressCommand => updateCustomerAddressCommand.Address.State)
                .NotEmpty().WithMessage($"O campo {{PropertyName}} é obrigatório!")
                .MaximumLength(StateLength)
                .WithMessage($"O {{PropertyName}} deve conter apenas a sigla.");

            RuleFor(updateCustomerAddressCommand => updateCustomerAddressCommand.Address.ZipCode)
                .NotEmpty().WithMessage($"O campo {{PropertyName}} é obrigatório!");
        }
    }
}
