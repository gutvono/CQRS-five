using Domain.Queries.v1;
using MediatR;

namespace Domain.Queries.v1.GetCustomerById;
public class GetCustomerByIdQuery(Guid Id) : IRequest<GetCustomerByIdQueryResponse>
{
    public Guid Id { get; set; } = Id;
}