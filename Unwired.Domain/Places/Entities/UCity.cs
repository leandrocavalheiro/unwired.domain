using Unwired.Domain.Abstractions.Entities;

namespace Unwired.Domain.Places.Entities;

public class UCity : UMinimalEntity
{
    public Guid? StateId { get; set; }
    public string Name { get; set; }
    public string IbgeCode { get; set; }

    /// <summary>
    /// Constructor<br/>
    /// City Identifier will be an automatically generated GUID.<br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    protected UCity() : base()
    {
    }

    /// <summary>
    /// Constructor <br/>
    /// City Identifier will be an automatically generated GUID. <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    /// <param name="name">City Name</param>
    /// <param name="stateId">State Identifier</param>
    public UCity(string name, Guid stateId, DateTime? createdAt = null) : base(Guid.NewGuid(), createdAt)
    {
        Name = name;
        StateId = stateId;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">City Identifier</param>
    /// <param name="name">City Name</param>
    /// <param name="stateId">State Identifier</param>
    /// <param name="ibgeCode">Ibge Code of City</param>
    /// <param name="createdAt">Creation date of record Country</param>
    public UCity(Guid id, string name, Guid stateId, string ibgeCode = "", DateTime? createdAt = null) : base(id, createdAt)
    {
        Name = name;
        StateId = stateId;
        IbgeCode = ibgeCode;
    }
}
