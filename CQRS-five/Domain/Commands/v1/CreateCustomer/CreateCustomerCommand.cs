using Domain.ValueObjects.v1;
using MediatR;
using System.Net;

namespace Domain.Commands.v1.CreateCustomer;

public class CreateCustomerCommand : IRequest<CreateCustomerCommandResponse>
{
    public string Name { get; set; } = string.Empty;
    public string Document { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public Address? Address { get; set; }
}