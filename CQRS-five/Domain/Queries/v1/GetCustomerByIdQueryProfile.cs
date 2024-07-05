using Domain.Entities.v1;
using AutoMapper;
using Domain.Queries.v1;

namespace _5by5.InterAction.Sample.Domain.Queries.v1.GetCustomerById;

public class GetCustomerByIdQueryProfile : Profile
{
    public GetCustomerByIdQueryProfile()
    {
        CreateMap<Customer, GetCustomerByIdQueryResponse>();
    }
}