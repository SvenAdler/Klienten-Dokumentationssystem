using System;
using System.Security.Cryptography;
using System.Text;

namespace KDS_1
{
    public class HashClass
    {
        public static string SHA1HashPasswort(string passwort)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] passwort_bytes = Encoding.UTF8.GetBytes(passwort);
            byte[] encrypted_bytes = sha1.ComputeHash(passwort_bytes);

            return Convert.ToBase64String(encrypted_bytes);

            // TODO Änderung des Verschlüsselungsalgotithmus
        }
    }
}
