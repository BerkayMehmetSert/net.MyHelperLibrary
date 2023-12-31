﻿using Helper.Security;
using Microsoft.IdentityModel.Tokens;
using Xunit;

namespace Helper.Test.Security;

public class SecurityCredentialsHelperTest
{
    [Fact]
    public void CreateSigningCredentialsShouldReturnSuccess()
    {
        const string securityKey = "securityKey";
        var result = SigningCredentialsHelper.CreateSigningCredentials(
            SecurityKeyHelper.CreateSecurityKey(securityKey)
        );
        Assert.NotNull(result);
        Assert.IsType<SigningCredentials>(result);
    }
}