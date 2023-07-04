namespace Helper.Exception.Types;

public class NotFoundException : System.Exception
{
    public NotFoundException(string message) : base(message)
    {
    }
}