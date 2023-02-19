using Unwired.Domain.Abstractions.Entities;

namespace Unwired.Domain.Tenants.Entities;

public class UTenantLog : UEntityTenant
{
    public string TenantStatusKey { get; set; }
    public string EventTenantKey { get; set; }
    public string Description { get; set; }

    /// <summary>
    /// Constructor <br/>
    /// Tenant Identifier will be an automatically generated GUID <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now()
    /// </summary>
    protected UTenantLog() : base()
    {
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">TenantLog Identifier</param>
    /// <param name="tenantid">Tenant Identifier</param>
    /// <param name="tenantStatusKey">Tenant creation status</param>
    /// <param name="eventTenantKey">Tenant event</param>
    /// <param name="description">Descrição do log</param>
    /// <param name="createdAt">Creation date of record</param>
    public UTenantLog(Guid id, Guid tenantid, string tenantStatusKey, string eventTenantKey, string description, DateTime? createdAt = null) : base(id, createdAt)
    {
        //TODO tenantStatusKey deve ser um Enumerador ( depende do projeto de enumeradores )
        //TODO EventTenantKey deve ser um Enumerador ( depende do projeto de enumeradores )

        TenantId= tenantid;                
        TenantStatusKey = tenantStatusKey;
        EventTenantKey = eventTenantKey;
        Description = description;
    }
}
