using Domain.Entities.v1;
using AutoMapper;
using Domain.ValueObjects.v1;

namespace Domain.Commands.v1.UpdateCustomerAddress
{
    public class UpdateCustomerAddressCommandProfile : Profile
    {
        public UpdateCustomerAddressCommandProfile()
        {
            CreateMap<UpdateCustomerAddressCommand, Customer>()
                .ForMember(fieldOutput => fieldOutput.Address, option => option
                    .MapFrom(input => input.Address));
            CreateMap<Customer, UpdateCustomerAddressCommandResponse>();
        }
    }
}
