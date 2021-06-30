﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KDS_1
{
    class HashClass
    {
        int saltLength = 32;
        public byte[] GenerateSalt()
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[saltLength];
                randomNumberGenerator.GetBytes(randomNumber);
                return randomNumber;
            }
        }

        public string HashDataWithRounds(byte[] password, byte[] salt, int rounds)
        {
            using (var rfc2898 = new Rfc2898DeriveBytes(password, salt, rounds))
            {
                return Convert.ToBase64String(rfc2898.GetBytes(32));
            }
        }
    }
}
