using Unwired.Domain.Abstractions.Interfaces;
using Unwired.Domain.Persons.Entities;

namespace Unwired.Domain.Persons.Interfaces;

public interface IUPersonRepository : IURepository<UPerson>
{
    IQueryable<UAddress> GetAddresses(Guid id, string filter = "");
    IQueryable<UPerson> GetList(string filter = "");        
}
