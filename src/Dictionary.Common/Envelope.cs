namespace Dictionary.Common;

public class Envelope : Envelope<string>
{
    protected Envelope(string errorMessage) : base(result: string.Empty, errorMessage)
    {
    }

    public static Envelope<T> Ok<T>(T result) => new(result, errorMessage: string.Empty);
    public static Envelope Ok() => new(errorMessage: string.Empty);
    public static Envelope Error(string errorMessage) => new(errorMessage);
}
