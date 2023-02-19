using Unwired.Domain.Places.Entities;
using Unwired.Domain.Abstractions.Interfaces;
using Unwired.Models.Types;

namespace Unwired.Domain.Places.Interfaces;

public interface IUStateRepository : IURepository<UState>
{
    IQueryable<UCity> GetCities(Guid id, string filter = "", ICollection<USort> sort = null);
    IQueryable<UState> GetByCountryId(Guid countryId, string filter = "", ICollection<USort> sort = null);
    IQueryable<UState> GetList(string filter = "", ICollection<USort> sort = null);
}