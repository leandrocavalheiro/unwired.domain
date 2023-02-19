namespace Unwired.Domain.Abstractions.Entities;

public abstract class UEntity : UEntityTenant
{  
    public Guid? AccountId { get;  set; }

    //TODO Adicionar quando estiver desenvolvendo a parte de user
    //public virtual User CreatedBy { get; set; }
    //public virtual User UpdatedBy { get; set; }
    //public virtual User DeletedBy { get; set; }


    /// <summary>
    /// Constructor <br/>
    /// Identifier will be an automatically generated GUID. <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    protected UEntity() : base()
    {
    }

    /// <summary>
    /// Constructor <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    /// <param name="id">Record Identifier</param>
    public UEntity(Guid id) : base(id)
    {
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">Record Identifier</param>
    /// <param name="date">Record creation date</param>
    /// <param name="tenantId">Tenant owner of record</param>
    /// <param name="accountId">Account owner of record</param>
    /// <param name="createdById">Identifier of the user who created the record</param>
    protected UEntity(Guid id, DateTime? date, Guid? tenantId = null, Guid? accountId = null, Guid? createdById = null) : base(id, date, tenantId, createdById)
    {
        AccountId = accountId;
    }

    /// <summary>
    /// Constructor <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    /// <param name="id">Record Identifier</param>
    /// <param name="tenantId">Tenant owner of record</param>
    /// <param name="accountId">Account owner of record</param>
    /// <param name="createdById">Identifier of the user who created the record</param>
    /// <param name="kind">Kind used in date. Default and recommended UTC</param>
    protected UEntity(Guid id, Guid? tenantId = null, Guid? accountId = null, Guid? createdById = null, DateTimeKind kind = DateTimeKind.Utc) : base(id, tenantId, createdById, kind)
    {
        AccountId = accountId;        
    }

    /// <summary>
    /// Constructor
    /// Record Identifier will be an automatically generated GUID.
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    /// <param name="kind">Kind used in date. Default: Utc</param>
    protected UEntity(DateTimeKind kind = DateTimeKind.Utc) : base(kind)
    {
    }
}