using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        // Out ifadesi geri dönüş yapacağını söylüyor.
        // passwordHash kayıt olurken verilen hashing değeri.
        // computedHash, doğrulama için aynı Key(passwordSalt) ile oluşturulan değer.
        public static void CreatePasswordHash(string signingPassword, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(signingPassword));  // password degerini, byte[] olarak istiyor.
            }
        }

        public static bool VerifyPasswordHash(string loginPassword, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginPassword));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
