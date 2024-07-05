using Domain.ValueObjects.v1;

namespace Domain.Queries.v1;

public class GetCustomerByIdQueryResponse
{
    public string Name { get; set; }
    public string Document { get; set; }
    public DateTime Birthday { get; set; }
    public Address? Address { get; set; }
    public Guid Id { get; set; }
}