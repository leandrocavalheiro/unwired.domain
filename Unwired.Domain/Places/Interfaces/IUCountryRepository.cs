using Unwired.Domain.Abstractions.Interfaces;
using Unwired.Domain.Places.Entities;
using Unwired.Models.Types;

namespace Unwired.Domain.Places.Interfaces;

public interface IUCountryRepository : IURepository<UCountry>
{
    IQueryable<UCountry> GetList(string filter = "", ICollection<USort> sort = null);
}
