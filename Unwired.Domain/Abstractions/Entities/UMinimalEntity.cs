using Unwired.Commons;
using Unwired.Commons.Extensions;

namespace Unwired.Domain.Abstractions.Entities
{
    public abstract class UMinimalEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Returns whether the record is active
        /// </summary>
        /// <returns>A boolean value, representing the status of the record. True for active and False for inactive.</returns>
        public bool Active()
            => DeletedAt == null;

        /// <summary>
        /// Constructor <br/>
        /// Identifier will be an automatically generated GUID. <br/>
        /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
        /// </summary>
        protected UMinimalEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = UnwiredMethods.Now();
            UpdatedAt = CreatedAt;
        }

        /// <summary>
        /// Constructor <br/>
        /// CreatedAt and UpdatedAt is UnwiredMethods.Now() <br/>
        /// </summary>
        /// <param name="id">Record Identifier</param>
        protected UMinimalEntity(Guid id)
        {            
            Id = id;
            CreatedAt = UnwiredMethods.Now();
            UpdatedAt = CreatedAt;
        }

        /// <summary>
        /// Constructor <br/>
        /// If the DateTimeKind is Unspecified then its value will be changed to Utc
        /// </summary>
        /// <param name="id">Record Identifier</param>
        /// <param name="createdAt">Record creation date</param>
        protected UMinimalEntity(Guid id, DateTime? createdAt)
        {
            var date = createdAt.IsNullOrEmpty() ? UnwiredMethods.Now() : (DateTime)createdAt;
            if (date.Kind == DateTimeKind.Unspecified)
                date.SetKind(DateTimeKind.Utc);
            
            Id = id;
            CreatedAt = date;
            UpdatedAt = date;            
        }

        /// <summary>
        /// Constructor <br/>
        /// CreatedAt and UpdatedAt is UnwiredMethods.Now(kind)
        /// </summary>
        /// <param name="id">Record Identifier</param>
        /// <param name="kind">Kind used in date. Default: Utc</param>
        protected UMinimalEntity(Guid id, DateTimeKind kind = DateTimeKind.Utc)
        {
            Id = id;
            CreatedAt = UnwiredMethods.Now(kind);
            UpdatedAt = CreatedAt;
        }

        /// <summary>
        /// Constructor <br/>
        /// Record Identifier will be an automatically generated GUID. <br/>
        /// CreatedAt and UpdatedAt is UnwiredMethods.Now(kind) <br/>
        /// </summary>
        /// <param name="kind">Kind used in date. Default: Utc</param>
        protected UMinimalEntity(DateTimeKind kind = DateTimeKind.Utc)
        {
            Id = Guid.NewGuid();
            CreatedAt = UnwiredMethods.Now(kind);
            UpdatedAt = CreatedAt;
        }
    }
}