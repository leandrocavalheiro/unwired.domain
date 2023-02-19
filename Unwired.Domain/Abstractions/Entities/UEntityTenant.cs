using Unwired.Commons;
using Unwired.Commons.Extensions;

namespace Unwired.Domain.Abstractions.Entities;

public abstract class UEntityTenant : UMinimalEntity
{    
    public Guid? TenantId { get; set; }
    public Guid? CreatedById { get; set; }
    public Guid? UpdatedById { get; set; }
    public Guid? DeletedById { get; set; }

    //TODO Adicionar quando estiver desenvolvendo a parte de account
    //public virtual User CreatedBy { get; set; }
    //public virtual User UpdatedBy { get; set; }
    //public virtual User DeletedBy { get; set; }

    /// <summary>
    /// Constructor <br/>
    /// Identifier will be an automatically generated GUID. <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    protected UEntityTenant() : base()
    {
    }

    /// <summary>
    /// Constructor <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    /// <param name="id">Record Identifier</param>
    public UEntityTenant(Guid id) : base(id)
    {
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">Record Identifier</param>
    /// <param name="date">Record creation date</param>
    /// <param name="tenantId">Tenant owner of record</param>
    /// <param name="createdById">Identifier of the user who created the record</param>
    protected UEntityTenant(Guid id, DateTime? date = null, Guid? tenantId = null, Guid? createdById = null) : base(id)
    {        
        TenantId = tenantId;
        CreatedById = createdById;
        UpdatedById = createdById;
        CreatedAt = date.IsNullOrEmpty() ? UnwiredMethods.Now() : (DateTime)date;
        UpdatedAt = CreatedAt;
    }

    /// <summary>
    /// Constructor <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    /// <param name="id">Record Identifier</param>    
    /// <param name="tenantId">Tenant owner of record</param>
    /// <param name="createdById">Identifier of the user who created the record</param>
    /// <param name="kind">Kind used in date. Default: Utc</param>
    protected UEntityTenant(Guid id, Guid? tenantId = null, Guid? createdById = null, DateTimeKind kind = DateTimeKind.Utc) : base(id, kind)
    {
        TenantId = tenantId;
        CreatedById = createdById;
    }

    /// <summary>
    /// Constructor <br/>
    /// Record Identifier will be an automatically generated GUID. <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    /// <param name="kind">Kind used in date. Default and recommended UTC</param>
    protected UEntityTenant(DateTimeKind kind = DateTimeKind.Utc) : base(kind)
    {
    }
}