using Unwired.Commons;
using Unwired.Commons.Extensions;
using Unwired.Domain.Abstractions.Entities;

namespace Unwired.Domain.Tenants.Entities;

public class UTenant : UMinimalEntity
{    
    public string Name { get; set; }
    public string TradeName { get; set; }
    public string Document { get; set; }
    public string Subdomain { get; set; }
    public string ContractNumber { get; set; }
    public string HostName { get; set; }
    public string HostWrite { get; set; }
    public string HostRead { get; set; }
    public string HostUserName { get; set; }
    public string HostPassword { get; set; }    
    public string DatabaseName { get; set; }
    public string TenantStatusKey { get; set; }    
    public DateTime? ParentAccountCreatedAt { get; set; }
    public DateTime? UserCreatedAt { get; set; }

    /// <summary>
    /// Constructor <br/>
    /// Tenant Identifier will be an automatically generated GUID <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now()
    /// </summary>
    protected UTenant() : base()
    {        
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">Unique Identifier</param>
    /// <param name="name">Name</param>
    /// <param name="tradeName">Trademark</param>
    /// <param name="document">Document Identifier</param>
    /// <param name="subDomain">Subdomain to indentify Tenant</param>
    /// <param name="contractNumber">Contract number signed with the software supplier</param>
    /// <param name="createdAt">Creation date of record</param>
    /// <param name="tenantStatusKey">Tenant creation status. Options: Pending, Concluded and Failed. Default: Pending</param>
    /// <param name="databaseName">Database name. Default: udatabase</param>
    public UTenant(Guid id, string name, string tradeName, string document, string subDomain, string contractNumber, DateTime? createdAt = null, string tenantStatusKey = "Pending",  string databaseName = "udatabase") : base(id, createdAt)
    {
        //TODO tenantStatusKey deve ser um Enumerador ( depende do projeto de enumeradores )

        Name = name;
        TradeName = tradeName;
        Document = document;
        Subdomain = subDomain;
        ContractNumber = contractNumber;
        TenantStatusKey = tenantStatusKey;
        DatabaseName = databaseName;
    }

    /// <summary>
    /// Set a custom host infos
    /// </summary>
    /// <param name="name">Host name.</param>
    /// <param name="write">Address to write.</param>
    /// <param name="read">Address to read.</param>
    /// <param name="user">Username database</param>
    /// <param name="password">Password database.</param>
    public void SetHost(string name, string write, string read, string user, string password)
    {
        //TODO Validar valores Default
        HostName = name;
        HostWrite = write;
        HostRead = read;
        HostUserName = user;
        HostPassword = password;
    }

    /// <summary>
    /// Set creation date of Parent Account
    /// </summary>
    /// <param name="createdAt">Datetime of creation. Null for UnwiredMethods.Now()</param>
    /// <param name="kind">Kind used in date. Default:Utc</param>
    public void ParentAccountCreated(DateTime? createdAt = null, DateTimeKind kind = DateTimeKind.Utc)
        => ParentAccountCreatedAt = createdAt.IsNullOrEmpty() ? UnwiredMethods.Now(kind) : createdAt;

    /// <summary>
    /// Set creation date of Super User
    /// </summary>
    /// <param name="createdAt">Datetime of creation. Null for UnwiredMethods.Now()</param>
    /// <param name="kind">Kind used in date. Default:Utc</param>
    public void SuperUserCreated(DateTime createdAt, DateTimeKind kind = DateTimeKind.Utc)
        => UserCreatedAt = createdAt.IsNullOrEmpty() ? UnwiredMethods.Now(kind) : createdAt;
    
    //TODO Melhorar validação ( colocar todos os campos necessários )
    /// <summary>
    /// Validate record.
    /// </summary>
    /// <returns>A boolean value. True for a valid record and False for a not valid record</returns>
    public bool IsValid()          
        => !string.IsNullOrEmpty(Name);    
}