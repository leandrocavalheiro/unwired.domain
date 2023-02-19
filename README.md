# Unwired Base Domain

Open-source **Base Domain** developed to facilitate the creation of a new project in .Net, providing some base entities.

- 👉 [Nuget Package](https://www.nuget.org/packages/Unwired.Domain) - `nuget page`

> Product Roadmap

| Status | Item                                         | info                  |
| ------ | -------------------------------------------- | --------------------- |
|   ✅   | **Abstracts Entities**                       |                       |
|   ✅   | **Tenant Entity**                            |                       |
|   ✅   | **TenantLog Entity**                         | Log TenantEvents      |
|   ✅   | **Account Entity**                           |                       |
|   ✅   | **Configuration Entity**                     | System Configurations |
|   ✅   | **Country Entity**                           |                       |
|   ✅   | **State Entity**                             |                       |
|   ✅   | **City Entity**                              |                       |
|   ✅   | **User Entity**                              |                       |
|   ✅   | **Person Entity**                            |                       |
|   ✅   | **Address Entity**                           | Person Address        |

> Something is missing? Submit a new `product feature request` using the [issues tracker](https://github.com/leandrocavalheiro/unwired.domain/issues).

## ✨ Abstracts Entities

- **UMinimalEntity**
Base entity for entities that have no relationship with Tenant/Account. Example: Country, State, City, Tenant.
```bash
    Guid Id : Record Identifier
    DateTime CreatedAt : Creation date of record
    DateTime UpdatedAt : Update date of record
    DateTime? DeletedAt : Deletation date of record
```
- **UEntityTenant**
Base entity for entities that have a relationship only with Tenant. Example: Account.
```bash
    Guid Id : Record Identifier
    Guid? TenantId : Tenant Identifier
    DateTime CreatedAt : Creation date of record
    DateTime UpdatedAt : Update date of record
    DateTime? DeletedAt : Deletation date of record
    Guid? CreatedById :  User who created the record
    Guid? UpdatedById} :  User who updated the record
    Guid? DeletedById :  User who deleted the record
```

- **UEntity**
Base entity for entities that have a relationship with Tenant and Account. Example: Account.
```bash
    public Guid Id { get; set; }
    public Guid? TenantId { get; set; }
    public Guid? AccountId { get;  set; }
    public Guid? CreatedById { get; set; }
    public Guid? UpdatedById { get; set; }
    public Guid? DeletedById { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
```
## ✨ Tenant Entity
- **UTenant**
Base entity for Tenant. With the possibility of informing data for a customized host

> Complete Documentation WIP

## ✨ Using the library

> 👉 **Step 1** - Install library into project

- **Package Manager**

```bash
$ Install-Package Unwired.Domain
```

- **.Net CLI**

```bash
$ dotnet add package Unwired.Domain
```

> 👉 **Step 2** - Use the base domains

## ✨ Code-base structure

The project is coded using a simple and intuitive structure presented below:

```bash
< PROJECT ROOT >
   |
   |-- Unwired.Domain/                     # Library
   |    |-- Abstractions/                  # Abstraction of Entities. All commons properties.
   |    |-- PluralEntityName/              # Group Entity ( One per Entity or Group Entity)
   |         |-- Entities/                 # Definitions of entity
   |         |-- Interfaces/               # Definitions of services, repositories
```

## ✨ Contacts

> 📧 **Email** - leo.cavalheiro.ti@gmail.com
