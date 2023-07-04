using Helper.Exception.Types;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExceptionController : ControllerBase
{
    [HttpGet("/business-exception/{message}")]
    public IActionResult GetBusinessException([FromRoute] string message)
    {
        throw new BusinessException(message);
    }
    
    [HttpGet("/not-found-exception/{message}")]
    public IActionResult GetNotFoundException([FromRoute] string message)
    {
        throw new NotFoundException(message);
    }
    
    [HttpGet("/exception/{message}")]
    public IActionResult GetException([FromRoute] string message)
    {
        throw new Exception(message);
    }
}