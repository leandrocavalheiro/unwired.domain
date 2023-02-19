using Unwired.Domain.Abstractions.Entities;

namespace Unwired.Domain.Users.Entities;

public class UUser : UEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    /// <summary>
    /// Constructor <br/>
    /// User Identifier will be an automatically generated GUID <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now()
    /// </summary>
    public UUser() : base()
    {
        Name = string.Empty;
        Email = string.Empty;
        Password = string.Empty;
    }
    public UUser(Guid id, string name, string email, string password, Guid? tenantId, Guid? accountId, Guid? createdById, DateTime? createdAt = null) : base(id, createdAt, tenantId, accountId, createdById)
    {
        Name = name;
        Email = email;
        Password = password;        
    }
}