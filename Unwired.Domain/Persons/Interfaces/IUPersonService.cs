using Unwired.Domain.Abstractions.Interfaces;
using Unwired.Domain.Persons.Entities;

namespace Unwired.Domain.Persons.Interfaces;

public interface IUPersonService : IUService
{
    Task<bool> Populate(UPerson person, string name, string tradeName, string phone, string email, Guid? avatarId, string observation = null);    
    Task Exists(Guid id);
    void CityExists(Guid cityId);
    void AddressExists(Guid addressId);
    void EmailExists(Guid emailId, Guid accountId);       
}
