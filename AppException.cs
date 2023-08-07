namespace Hagca.Exception;

public sealed class AppException : System.Exception
{
    public AppException(string message) : base(message)
    {
    }
}