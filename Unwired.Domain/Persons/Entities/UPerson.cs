using Unwired.Domain.Abstractions.Entities;
using Unwired.Domain.Accounts.Entities;
using Unwired.Domain.Users.Entities;

namespace Unwired.Domain.Persons.Entities;

public class UPerson : UEntity
{
    /// <summary>
    /// Natura Person or Legal Person
    /// </summary>
    public string PersonTypeKey { get; set; }
    public int Code { get; set; }
    public string Name { get; set; }
    public string TradeName { get; set; }
    public string Document { get; set; }
    public string Notes { get; set; }
    public bool Blocked { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Guid? UserId { get; set; } // Id do usuário relacionado
    public virtual UUser User { get; set; }
    public virtual UAccount Account { get; set; }
    public virtual ICollection<UAddress> Addresses { get; set; }
    
    /// <summary>
    /// Constructor <br/>
    /// Person Identifier will be an automatically generated GUID. <br/>
    /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
    /// </summary>
    public UPerson() : base()
    { }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">Person Identifier</param>
    /// <param name="accountId">Account Identifier</param>
    /// <param name="personTypeKey">Person Type ( Legal Person or Natural Person )</param>
    /// <param name="name">Person Name</param>
    /// <param name="tradeName">Trade Name</param>
    /// <param name="notes">Notes</param>
    /// <param name="document">Person Identification document</param>
    /// <param name="phone">Contact Phone</param>
    /// <param name="email">Contact EMail</param>
    /// <param name="createdAt">Person creation date</param>
    public UPerson(Guid id, Guid accountId, string personTypeKey, string name, string tradeName, string notes, string document = "", string phone = "", string email = "", Guid? userId = null,  DateTime? createdAt = null) : base(id, createdAt)
        => Initialize(accountId, personTypeKey, name, tradeName, notes, document, phone, email, userId);
    public UPerson(Guid id, Guid accountId, string personTypeKey, string name, DateTime? createdAt = null) : base(id, createdAt)
        => Initialize(accountId, personTypeKey, name);
    private void Initialize(Guid accountId, string personTypeKey, string name, string tradeName = "", string notes = "", string document = "", string phone = "", string email = "", Guid? userId = null)
    {
        AccountId = accountId;
        PersonTypeKey = personTypeKey;    
        Name = name;
        TradeName = tradeName;
        Notes = notes;
        Document = document;
        Phone = phone;
        Email = email;
        UserId = userId;
    }
    public void AddPersonAddress(Guid? cityId, string zipCode, string neighborhood, string street, string number, string complement)
    {
        Addresses ??= new List<UAddress>();
        Addresses.Add(new UAddress(Guid.NewGuid(), Id, cityId, zipCode, neighborhood, street, number, complement));
    }
    public void BlockPerson()
        => Blocked = true;
    public void UnblockPerson()
        => Blocked = false;

}
