using Unwired.Domain.Abstractions.Interfaces;
using Unwired.Domain.Accounts.Entities;

namespace Unwired.Domain.Accounts.Interfaces;

public interface IUAccountService : IUService
{    
    Task<UConfiguration> GetConfiguration(string configurationKey, bool tracking = false);
    Task AccountAlreadyRegistered(string document);
    Task ValidateAccount(Guid? id, bool allowNullOrEmpty = false);
    Task<UAccount> GetParentAccount(Guid id);
}
