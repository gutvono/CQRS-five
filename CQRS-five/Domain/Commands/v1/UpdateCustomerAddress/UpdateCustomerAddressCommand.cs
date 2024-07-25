using Domain.ValueObjects.v1;
using MediatR;

namespace Domain.Commands.v1.UpdateCustomerAddress
{
    public class UpdateCustomerAddressCommand : IRequest<UpdateCustomerAddressCommandResponse>
    {
        public Guid Id { get; set; }
        public Address? Address { get; set; }
    }
}
