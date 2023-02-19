using Unwired.Domain.Abstractions.Interfaces;
using Unwired.Domain.Accounts.Entities;

namespace Unwired.Domain.Accounts.Interfaces;

public interface IUConfigurationRepository : IURepository<UConfiguration>
{
    Task<UConfiguration> GetByKey(string key, bool tracking = false);        
}
