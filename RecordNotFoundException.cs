namespace Hagca.Exception;

public sealed class RecordNotFoundException : Exception
{
    public RecordNotFoundException(string message) : base(message)
    {

    }
}