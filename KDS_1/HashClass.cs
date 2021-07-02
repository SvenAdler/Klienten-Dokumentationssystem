using System;
using System.Security.Cryptography;
using System.Text;

namespace KDS_1
{
    public class HashClass
    {
        public static string SHA512HashPasswort(string passwort)
        {
            SHA512CryptoServiceProvider sha512 = new SHA512CryptoServiceProvider();
            byte[] passwort_bytes = Encoding.UTF8.GetBytes(passwort);
            byte[] encrypted_bytes = sha512.ComputeHash(passwort_bytes);

            return Convert.ToBase64String(encrypted_bytes);
        }
    }
}
