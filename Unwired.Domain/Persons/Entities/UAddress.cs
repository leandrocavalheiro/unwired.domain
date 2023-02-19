using Unwired.Domain.Abstractions.Entities;
using Unwired.Domain.Places.Entities;

namespace Unwired.Domain.Persons.Entities;

public class UAddress : UEntity
{
    public Guid? PersonId { get; set; }
    public Guid? CityId { get; set; }
    public string ZipCode { get; set; }
    public string Neighborhood { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }
    public string Complement { get; set; }        
    public virtual UPerson Person { get; set; }
    public virtual UCity City { get; set; }

    /// <summary>
    /// Constructor <br/>
    /// Address Identifier will be an automatically generated GUID. <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    public UAddress() : base()
    { }

    /// <summary>
    /// Constructor <br/>
    /// </summary>
    /// <param name="id">Address Identifier</param>
    /// <param name="personId">Person Identifier</param>
    /// <param name="cityId">City Identifier</param>
    /// <param name="zipCode">Zip Code of address</param>
    /// <param name="neighborhood">Neighborhood</param>
    /// <param name="street">Street</param>
    /// <param name="number">Numer</param>
    /// <param name="complement">Complement of address</param>
    public UAddress(Guid id, Guid? personId, Guid? cityId, string zipCode, string neighborhood, string street, string number, string complement, DateTime? createdAt = null) : base(id, createdAt)
    {
        PersonId = personId;
        CityId = cityId;
        ZipCode = zipCode;
        Neighborhood = neighborhood;
        Street = street;
        Number = number;
        Complement = complement;        
    }  
}
