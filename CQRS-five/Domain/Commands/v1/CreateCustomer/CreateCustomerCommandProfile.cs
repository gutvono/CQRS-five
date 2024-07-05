using Domain.Entities.v1;
using AutoMapper;

namespace Domain.Commands.v1.CreateCustomer;
public class CreateCustomerCommandProfile : Profile
{
    public CreateCustomerCommandProfile()
    {
        CreateMap<CreateCustomerCommand, Customer>()
            .ForMember(fieldOutput => fieldOutput.Document, option => option
                .MapFrom(input => GetOnlyNumbers(input.Document)));

        CreateMap<Customer, CreateCustomerCommandResponse>();
    }

    public static string GetOnlyNumbers(string text)
    {
        var stringNumber = new string((text ?? string.Empty).Where(char.IsDigit).ToArray());
        return stringNumber;
    }
}