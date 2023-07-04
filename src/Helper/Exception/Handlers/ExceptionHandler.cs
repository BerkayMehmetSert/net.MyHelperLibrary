using Helper.Exception.Types;

namespace Helper.Exception.Handlers;

public abstract class ExceptionHandler
{
    public Task HandleExceptionAsync(System.Exception exception)
    {
        return exception switch
        {
            BusinessException businessException => HandleException(businessException),
            NotFoundException notFoundException => HandleException(notFoundException),
            _ => HandleException(exception)
        };
    }
    
    protected abstract Task HandleException(BusinessException businessException);
    protected abstract Task HandleException(NotFoundException notFoundException);
    protected abstract Task HandleException(System.Exception exception);
}