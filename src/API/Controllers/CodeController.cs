using Helper.CodeGenerator;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CodeController : ControllerBase
{
    [HttpPost("/generate-code/{codeLength}")]
    public IActionResult GenerateCode([FromRoute] int codeLength)
    {
        var code = CodeHelper.GenerateCode(codeLength);
        return Ok(code);
    }
}