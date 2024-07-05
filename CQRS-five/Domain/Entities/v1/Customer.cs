using Domain.Contracts.v1;
using Domain.ValueObjects.v1;

namespace Domain.Entities.v1;

public sealed class Customer : IEntity<Guid>
{
    public Customer()
    {
        Id = Guid.NewGuid();
    }

    public string Name { get; set; }
    public string Document { get; set; }
    public DateTime Birthday { get; set; }
    public Address? Address { get; set; }

    public Guid Id { get; set; }

}