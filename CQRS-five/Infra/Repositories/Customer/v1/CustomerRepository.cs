using Domain.Contracts.v1;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Infra.Repositories.Customer.v1;

public class CustomerRepository(IMongoClient client) : BaseDbRepository<Domain.Entities.v1.Customer, Guid>(client), ICustomerRepository;