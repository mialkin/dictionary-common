using CSharpFunctionalExtensions;

namespace Dictionary.Common;

public sealed class Error : ValueObject
{
    public string Code { get; }
    public string Message { get; }

    public Error(string code, string message)
    {
        Code = code;
        Message = message;
    }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Code;
    }
}
