using System.Text.Json;
using Helper.Exception.Details;
using Helper.Exception.Types;
using Microsoft.AspNetCore.Http;

namespace Helper.Exception.Handlers;

public class HttpExceptionHandler : ExceptionHandler
{
    public HttpResponse? Response { get; set; }

    protected override Task HandleException(BusinessException businessException)
    {
        Response.StatusCode = StatusCodes.Status400BadRequest;
        var detail = new BusinessExceptionDetails(businessException.Message);
        var result = JsonSerializer.Serialize(detail);
        return Response.WriteAsync(result);
    }

    protected override Task HandleException(NotFoundException notFoundException)
    {
        Response.StatusCode = StatusCodes.Status404NotFound;
        var detail = new NotFoundExceptionDetails(notFoundException.Message);
        var result = JsonSerializer.Serialize(detail);
        return Response.WriteAsync(result);
    }

    protected override Task HandleException(System.Exception exception)
    {
        Response.StatusCode = StatusCodes.Status500InternalServerError;
        var detail = new InternalServerErrorExceptionDetails(exception.Message);
        var result = JsonSerializer.Serialize(detail);
        return Response.WriteAsync(result);
    }
}