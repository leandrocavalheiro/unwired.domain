using Unwired.Domain.Abstractions.Entities;

namespace Unwired.Domain.Accounts.Entities;

public class UAccount : UEntityTenant
{
    public int Code { get; set; }
    public string Name { get; set; }
    public string TradeName { get; set; }
    public string Document { get; set; }
    public string ContractNumber { get; set; }
    public string Initials { get; set; }           
    public Guid? ParentAccountId { get; set; } // Empresa Matriz
    public string Notes { get; set; }
    public bool Blocked { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Guid? CityId { get; set; }
    public string ZipCode { get; set; }
    public string Neighborhood { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }
    public string Complement { get; set; }

    /// <summary>
    /// Constructor <br/>
    /// Account Identifier will be an automatically generated GUID. <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    protected UAccount() : base()
    {
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">Account Identifier</param>
    /// <param name="tenantId">Tenant Identifier</param>
    /// <param name="name">Name</param>
    /// <param name="tradeName">TradeMark</param>
    /// <param name="document">Document Indentifier</param>
    /// <param name="contractNumber">Contract number signed with the software supplier</param>
    /// <param name="createdAt">Creation date of record</param>
    /// <param name="creatById">User Identifier creation of record</param>
    /// <param name="parentAccountId">When an account is a subsidiary, this field must contain the identifier of the parent account.</param>
    /// <param name="notes">Additional Notes</param>
    public UAccount(Guid id, Guid? tenantId, string name, string tradeName, string document, string contractNumber, string initials, 
                    Guid? creatById, Guid? parentAccountId = null, DateTime? createdAt = null, string notes = "" ) : base(id, createdAt, tenantId, creatById)
    {
        Name = name;
        TradeName = tradeName;
        Document = document;
        ContractNumber = contractNumber;
        Initials = initials;
        TenantId = tenantId;
        ParentAccountId = parentAccountId;
        Notes = notes;
    }

    /// <summary>
    /// Update contacts info
    /// </summary>
    /// <param name="phone">Contact phone</param>
    /// <param name="email">Contact email</param>
    /// <param name="cityId">Account city identifier</param>
    /// <param name="zipCode">Zip Code</param>
    /// <param name="neighborhood">Name of neighborhood</param>
    /// <param name="street">Street name</param>
    /// <param name="number">Address number</param>
    /// <param name="complement">Address complement</param>
    public void SetContact(string phone, string email, Guid? cityId, string zipCode, string neighborhood, string street, string number, string complement) 
    {        
        Phone = phone;
        Email = email;
        CityId = cityId;
        ZipCode = zipCode;
        Neighborhood = neighborhood;
        Street = street;
        Number = number;
        Complement = complement;
    }
}
