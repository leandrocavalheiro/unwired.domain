using Unwired.Domain.Abstractions.Entities;

namespace Unwired.Domain.Places.Entities;
public class UCountry : UMinimalEntity
{
    public string Name { get; set; }

    /// <summary>
    /// Constructor<br/>
    /// Country Identifier will be an automatically generated GUID<br/>
    /// CreatedAt and UpdatedAt is DateTime.UtcNow
    /// </summary>
    protected UCountry() : base()
    { 
    }

    /// <summary>
    /// Constructor<br/>
    /// Country Identifier will be an automatically generated GUID<br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    /// <param name="name">Country Name</param>
    public UCountry(string name) : base()
    {
        Name = name;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">Country Identifier</param>
    /// <param name="name">Country Name</param>
    /// <param name="createdAt">Creation date of record Country</param>
    public UCountry(Guid id, string name, DateTime? createdAt = null) : base(id, createdAt)
    {
        Name = name;
    }
}