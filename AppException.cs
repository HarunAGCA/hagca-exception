namespace Hagca.Exception;

public sealed class AppException : Exception
{
    public AppException(string message) : base(message)
    {
    }
}