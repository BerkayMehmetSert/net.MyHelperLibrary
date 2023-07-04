namespace Helper.Exception.Types;

public class BusinessException : System.Exception
{
    public BusinessException(string message) : base(message)
    {
    }
}