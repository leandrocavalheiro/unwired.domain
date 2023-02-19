using Unwired.Domain.Abstractions.Interfaces;
using Unwired.Domain.Accounts.Entities;

namespace Unwired.Domain.Accounts.Interfaces;

public interface IUAccountRepository : IURepository<UAccount>
{
    IQueryable<UAccount> GetSubsidiaries(string filters = "");
}
