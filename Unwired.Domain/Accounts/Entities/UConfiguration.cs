using Unwired.Domain.Abstractions.Entities;

namespace Unwired.Domain.Accounts.Entities;

public class UConfiguration : UEntity
{
    public string Key { get; set; }
    public string Description { get; set; }
    public string Value { get; set; }
    public string FieldType { get; set; }
    public string OriginTable { get; set; }
    public string FieldName { get; set; }

    /// <summary>
    /// Constructor <br/>
    /// Configuration Identifier will be an automatically generated GUID. <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    public UConfiguration() : base()
    {
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id"></param>
    /// <param name="key"></param>
    /// <param name="description"></param>
    /// <param name="value"></param>
    /// <param name="fieldType"></param>
    /// <param name="tenantId"></param>
    /// <param name="accountId"></param>
    /// <param name="createdById"></param>
    /// <param name="createdAt"></param>    
    /// <param name="originTable"></param>
    /// <param name="fieldName"></param>
    public UConfiguration(Guid id, string key, string description, string value, string fieldType, Guid? tenantId, Guid? accountId, Guid createdById, DateTime? createdAt = null, string originTable = "", string fieldName = "") : base(id, createdAt, tenantId, accountId, createdById)
    {
        Key = key;
        Description = description;
        Value = value;
        FieldType = fieldType;
        OriginTable = originTable;
        FieldName = fieldName;
    }
}
