﻿namespace Domain.Commands.v1.CreateCustomer;
public class CreateCustomerCommandResponse
{
    public string Name { get; set; } = string.Empty;
    public Guid Id { get; set; }
}