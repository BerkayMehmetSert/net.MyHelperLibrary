using Helper.Security;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SecurityController : ControllerBase
{
    [HttpPost("/create-password-hash-512/{password}")]
    public IActionResult CreatePasswordHash512([FromRoute] string password)
    {
        HashingHelper.CreatePasswordHash512(password, out var passwordHash, out var passwordSalt);
        return Ok(new
        {
            passwordHash = Convert.ToBase64String(passwordHash),
            passwordSalt = Convert.ToBase64String(passwordSalt)
        });
    }
    
    [HttpPost("/create-password-hash-256/{password}")]
    public IActionResult CreatePasswordHash256([FromRoute] string password)
    {
        HashingHelper.CreatePasswordHash256(password, out var passwordHash, out var passwordSalt);
        return Ok(new
        {
            passwordHash = Convert.ToBase64String(passwordHash),
            passwordSalt = Convert.ToBase64String(passwordSalt)
        });
    }
    
    [HttpPost("/create-security-key/{securityKey}")]
    public IActionResult CreateSecurityKey([FromRoute] string securityKey)
    {
        var securityKeyResult = SecurityKeyHelper.CreateSecurityKey(securityKey);
        return Ok(new
        {
            securityKey = securityKeyResult
        });
    }
    
    [HttpPost("/create-signing-credentials/{securityKey}")]
    public IActionResult CreateSigningCredentials([FromRoute] string securityKey)
    {
        var securityKeyResult = SecurityKeyHelper.CreateSecurityKey(securityKey);
        var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKeyResult);
        return Ok(new
        {
            signingCredential = signingCredentials
        });
    }
}