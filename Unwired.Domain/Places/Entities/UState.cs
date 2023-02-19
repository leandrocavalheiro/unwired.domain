using Unwired.Domain.Abstractions.Entities;

namespace Unwired.Domain.Places.Entities;

public class UState : UMinimalEntity
{    
    public string Name { get; set; }
    public Guid? CountryId { get; set; }
    public string Initials { get; set; }

    /// <summary>
    /// Constructor <br/>
    /// State Identifier will be an automatically generated GUID. <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    protected UState() : base()
    {
    }

    /// <summary>
    /// Constructor <br/>
    /// State Identifier will be an automatically generated GUID <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    /// <param name="name">State Name</param>
    /// <param name="countryId">Country Identifier</param>
    public UState(string name, Guid countryId) : base()
    {
        Name = name;
        CountryId = countryId;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">State Identifier</param>
    /// <param name="name">State Name</param>
    /// <param name="countryId">Country Identifier</param>
    /// <param name="createdAt">Creation date of record State</param>
    public UState(Guid id, string name, Guid countryId, string initials = "", DateTime? createdAt = null) : base(id, createdAt)
    {
        Name = name;
        CountryId = countryId;
        Initials = initials;
    }
}