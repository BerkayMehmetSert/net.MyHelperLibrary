using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Helper.Exception.Details;

public class BusinessExceptionDetails : ProblemDetails
{
    public BusinessExceptionDetails(string detail)
    {
        Title = "Business error";
        Detail = detail;
        Status = StatusCodes.Status400BadRequest;
        Type = "https://example.com/probs/business";
    }
}