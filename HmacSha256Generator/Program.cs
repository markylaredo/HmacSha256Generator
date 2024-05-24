using System.Security.Cryptography;
using System.Text;

var data = "MySuperSecretKey";
var key = GenerateKey(512); // Ensures key is greater than 256 bits

var hmac = ComputeHmacsha256(data, key);

Console.WriteLine(hmac);
return;


static string ComputeHmacsha256(string data, byte[] key)
{
    if (key.Length * 8 <= 256)
    {
        throw new ArgumentException("The key size must be greater than 256 bits.");
    }

    using var hmac = new HMACSHA256(key);
    var dataBytes = Encoding.UTF8.GetBytes(data);
    var hashBytes = hmac.ComputeHash(dataBytes);
    return Convert.ToBase64String(hashBytes);
}

static byte[] GenerateKey(int keySizeInBits)
{
    return RandomNumberGenerator.GetBytes(keySizeInBits / 8);
}