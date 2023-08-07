namespace Hagca.Exception;

public sealed class RecordNotFoundException : System.Exception
{
    public RecordNotFoundException(string message) : base(message)
    {

    }
}