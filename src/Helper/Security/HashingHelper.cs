using System.Security.Cryptography;
using System.Text;

namespace Helper.Security;

public static class HashingHelper
{
    public static void CreatePasswordHash512(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using HMACSHA512 hmac = new();
        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

    public static bool VerifyPasswordHash512(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using HMACSHA512 hmac = new(passwordSalt);
        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        return computedHash.SequenceEqual(passwordHash);
    }
    
    public static void CreatePasswordHash256(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using HMACSHA256 hmac = new();
        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }
    
    public static bool VerifyPasswordHash256(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using HMACSHA256 hmac = new(passwordSalt);
        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        return computedHash.SequenceEqual(passwordHash);
    }
}