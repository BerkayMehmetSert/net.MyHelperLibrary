using Helper.CodeGenerator;
using Xunit;

namespace Helper.Test.CodeGenerator;

public class CodeHelperTest
{
    [Fact]
    public void GenerateCodeShouldReturnCodeWithCorrectLength()
    {
        const int codeLength = 10;
        var code = CodeHelper.GenerateCode(codeLength);
        Assert.Equal(codeLength, code.Length);
    }
    
    [Fact]
    public void GenerateCodeShouldReturnCodeWithOnlyAllowedCharacters()
    {
        const int codeLength = 10;
        var code = CodeHelper.GenerateCode(codeLength);
        Assert.Matches("^[A-Z0-9]*$", code);
    }
}