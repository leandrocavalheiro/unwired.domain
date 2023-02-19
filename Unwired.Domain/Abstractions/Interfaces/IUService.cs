namespace Unwired.Domain.Abstractions.Interfaces;

public interface IUService
{
    sbyte ValidateFieldIsNull(string fieldName, Guid? value, bool allowNullOrEmpty = false);
    sbyte ValidateFieldIsNull(string fieldName, string value, bool allowNullOrEmpty = false);
}
