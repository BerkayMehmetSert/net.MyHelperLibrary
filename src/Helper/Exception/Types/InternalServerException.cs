namespace Helper.Exception.Types;

public class InternalServerException : System.Exception
{
    public InternalServerException(string message) : base(message)
    {
    }
}