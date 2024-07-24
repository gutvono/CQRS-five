using AutoMapper;
using Domain.Contracts.v1;
using Domain.Queries.v1.GetCustomerById;
using Domain.Queries.v1;
using MediatR;

namespace Domain.Commands.v1.DeleteCustomer
{
    public class DeleteCustomerCommandHandler(
    ICustomerRepository repository,
    IMapper mapper,
    IDomainNotificationService domainNotification
    ) : IRequestHandler<DeleteCustomerCommand, DeleteCustomerCommandResponse>
    {
        public async Task<DeleteCustomerCommandResponse> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            await repository.DeleteAsync(request.Id, cancellationToken);
            return new DeleteCustomerCommandResponse();
        }
    }
}
