using Domain.ValueObjects.v1;

namespace Domain.Commands.v1.UpdateCustomerAddress
{
    public class UpdateCustomerAddressCommandResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Address? Address { get; set; }
    }
}
