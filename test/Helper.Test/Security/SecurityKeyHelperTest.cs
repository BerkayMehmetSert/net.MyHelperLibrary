using Helper.Security;
using Microsoft.IdentityModel.Tokens;
using Xunit;

namespace Helper.Test.Security;

public class SecurityKeyHelperTest
{
    [Fact]
    public void CreateSecurityKeyShouldReturnSuccess()
    {
        const string securityKey = "securityKey";
        var result = SecurityKeyHelper.CreateSecurityKey(securityKey);
        Assert.NotNull(result);
        Assert.IsType<SymmetricSecurityKey>(result);
    }
}