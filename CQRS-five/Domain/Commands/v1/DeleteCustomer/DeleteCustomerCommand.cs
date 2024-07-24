using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands.v1.DeleteCustomer
{
    public class DeleteCustomerCommand(Guid Id) : IRequest<DeleteCustomerCommandResponse>
    {
        public Guid Id { get; set; } = Id;
    }
}
