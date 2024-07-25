using AutoMapper;
using Domain.Commands.v1.UpdateCustomerAddress;
using MediatR;

namespace Domain.Contracts.v1
{
    public class UpdateCustomerAddressCommandHandler(ICustomerRepository repository, IMapper mapper, IDomainNotificationService domainNotification)
    : IRequestHandler<UpdateCustomerAddressCommand, UpdateCustomerAddressCommandResponse>
    {
        public async Task<UpdateCustomerAddressCommandResponse> Handle(
            UpdateCustomerAddressCommand request,
            CancellationToken cancellationToken)
        {
            var customer = await repository.GetByIdAsync(request.Id, cancellationToken);
            if (customer == null)
            {
                domainNotification.Add("Customer not found.");
                return null;
            }

            mapper.Map(request, customer);
            await repository.UpdateAsync(customer, cancellationToken);

            return mapper.Map<UpdateCustomerAddressCommandResponse>(customer);
        }
    }
}
