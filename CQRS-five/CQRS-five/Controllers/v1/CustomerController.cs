﻿using Domain.Contracts.v1;
using Domain.Queries.v1.GetCustomerById;
using Domain.Commands.v1.CreateCustomer;
using Domain.Commands.v1.DeleteCustomer;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Domain.Commands.v1.UpdateCustomerAddress;

namespace CQRS_five.Controllers.v1;

[Route("api/v1/customers")]
[ApiController]
public sealed class CustomerController(IMediator bus, IDomainNotificationService domainNotification) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateCustomerCommand model, CancellationToken token)
    {
        var response = await bus.Send(model, token);

        return StatusCode((int)HttpStatusCode.Created, new
        {
            Content = response,
            Notification = "Cliente cadastrado com sucesso!!!"
        });
    }

    [HttpPatch]
    public async Task<IActionResult> Patch([FromBody] UpdateCustomerAddressCommand model, CancellationToken token)
    {
        var response = await bus.Send(model, token);

        if (response is null)
        {
            return NotFound();
        }

        return Ok(new
        {
            Content = response,
            Notification = "Endereço do cliente atualizado com sucesso!!!"
        });
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id, CancellationToken token)
    {
        var customer = await bus.Send(new GetCustomerByIdQuery(id));

        if (customer is null) return NotFound();

        return Ok(new
        {
            Content = customer
        });
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id, CancellationToken token)
    {
        var response = await bus.Send(new DeleteCustomerCommand(id));

        if (response.Equals(default)) return NotFound();

        return StatusCode((int)HttpStatusCode.NoContent);
    }
}