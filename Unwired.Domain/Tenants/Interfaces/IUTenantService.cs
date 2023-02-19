using Unwired.Domain.Abstractions.Interfaces;

namespace Unwired.Domain.Tenants.Interfaces;

public interface IUTenantService : IUService
{
    Task AlreadyRegistered(string subdomain);    
}
