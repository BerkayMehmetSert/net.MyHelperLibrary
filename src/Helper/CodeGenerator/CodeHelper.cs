namespace Helper.CodeGenerator;

public static class CodeHelper
{
    private const string AllowedCharacters  = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private static readonly Random Random = new();
    
    public static string GenerateCode(int codeLength)
    {
        var codeChars = new char[codeLength];
        
        for (var i = 0; i < codeLength; i++)
        {
            codeChars[i] = AllowedCharacters[Random.Next(AllowedCharacters.Length)];
        }

        return new string(codeChars);
    }
}