using Helper.Security;
using Xunit;

namespace Helper.Test.Security;

public class HashingHelperTest
{
    [Fact]
    public void CreatePasswordHash512CorrectPasswordShouldReturnSuccess()
    {
        const string password = "P@ssw0rd";
        HashingHelper.CreatePasswordHash512(password, out var passwordHash, out var passwordSalt);
        Assert.NotNull(passwordHash);
        Assert.NotEmpty(passwordHash);
        Assert.NotNull(passwordSalt);
        Assert.NotEmpty(passwordSalt);
    }
    
    [Fact]
    public void VerifyPasswordHash512CorrectPasswordShouldReturnSuccess()
    {
        const string password = "P@ssw0rd";
        HashingHelper.CreatePasswordHash512(password, out var passwordHash, out var passwordSalt);
        var result = HashingHelper.VerifyPasswordHash512(password, passwordHash, passwordSalt);
        Assert.True(result);
    }

    [Fact]
    public void VerifyPasswordHash512InCorrectPasswordShouldReturnFalse()
    {
        const string password = "P@ssw0rd";
        const string wrongPassword = "WrongP@ssw0rd";
        HashingHelper.CreatePasswordHash512(password, out var passwordHash, out var passwordSalt);
        var result = HashingHelper.VerifyPasswordHash512(wrongPassword, passwordHash, passwordSalt);
        Assert.False(result);
    }
    
    [Fact]
    public void CreatePasswordHash256CorrectPasswordShouldReturnSuccess()
    {
        const string password = "P@ssw0rd";
        HashingHelper.CreatePasswordHash256(password, out var passwordHash, out var passwordSalt);
        Assert.NotNull(passwordHash);
        Assert.NotEmpty(passwordHash);
        Assert.NotNull(passwordSalt);
        Assert.NotEmpty(passwordSalt);
    }
    
    [Fact]
    public void VerifyPasswordHash256CorrectPasswordShouldReturnSuccess()
    {
        const string password = "P@ssw0rd";
        HashingHelper.CreatePasswordHash256(password, out var passwordHash, out var passwordSalt);
        var result = HashingHelper.VerifyPasswordHash256(password, passwordHash, passwordSalt);
        Assert.True(result);
    }

    [Fact]
    public void VerifyPasswordHash5256InCorrectPasswordShouldReturnFalse()
    {
        const string password = "P@ssw0rd";
        const string wrongPassword = "WrongP@ssw0rd";
        HashingHelper.CreatePasswordHash256(password, out var passwordHash, out var passwordSalt);
        var result = HashingHelper.VerifyPasswordHash256(wrongPassword, passwordHash, passwordSalt);
        Assert.False(result);
    }
}