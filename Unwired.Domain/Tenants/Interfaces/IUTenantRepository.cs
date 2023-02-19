using Unwired.Domain.Abstractions.Interfaces;
using Unwired.Domain.Tenants.Entities;
using Unwired.Models.Types;

namespace Unwired.Domain.Tenants.Interfaces;

public interface IUTenantRepository : IURepository<UTenant>
{
    Task<UTenant> GetBySubdomain(string subDomain, bool tracking = false);
    IQueryable<UTenant> GetList(string filter = "", ICollection<USort> sort = null);
}
