using Unwired.Domain.Places.Entities;
using Unwired.Domain.Abstractions.Interfaces;
using Unwired.Models.Types;

namespace Unwired.Domain.Places.Interfaces;

public interface IUCityRepository : IURepository<UCity>
{
    IQueryable<UCity> GetByStateId(Guid stateId, string filter = "", ICollection<USort> sort = null);
    IQueryable<UCity> GetList(string filter = "", ICollection<USort> sort = null);
}