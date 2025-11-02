using System;
using System.Security.Cryptography;

namespace the_forsty_cone
{
    public class PasswordHasher
    {
        private const int SaltSize = 16; // 128 bits
        private const int HashSize = 20; // 160 bits
        private const int Iterations = 10000;

        public static string HashPassword(string password)
        {
            // Generate a random salt
            byte[] salt;
            using (var rng = new RNGCryptoServiceProvider())
            {
                salt = new byte[SaltSize];
                rng.GetBytes(salt);
            }

            // Create the hash
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
            {
                var hash = pbkdf2.GetBytes(HashSize);

                // Combine the salt and hash
                var hashBytes = new byte[SaltSize + HashSize];
                Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

                // Convert to base64 for storage
                return Convert.ToBase64String(hashBytes);
            }
        }

        //public static bool VerifyPassword(string password, string hashedPassword)
        //{
        //    // Convert from base64 string
        //    var hashBytes = Convert.FromBase64String(hashedPassword);

        //    // Get the salt
        //    var salt = new byte[SaltSize];
        //    Array.Copy(hashBytes, 0, salt, 0, SaltSize);

        //    // Create the hash with the same salt
        //    using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
        //    {
        //        var hash = pbkdf2.GetBytes(HashSize);

        //        // Compare the results
        //        for (var i = 0; i < HashSize; i++)
        //        {
        //            if (hashBytes[i + SaltSize] != hash[i])
        //                return false;
        //        }
        //        return true;
        //    }
        //}


        //new version because prevoious one was giving errors
        public static bool VerifyPassword(string password, string hashedPassword) // verifies if the provided password matches the stored hashed password
        {
            if (string.IsNullOrEmpty(hashedPassword)) // Check for null or empty hashed password
                return false;

            byte[] hashBytes; // Declare byte array to hold the hash bytes

            try // Try to convert the Base64 string to byte array
            {
                hashBytes = Convert.FromBase64String(hashedPassword);
            }
            catch // Catch any format exceptions
            {
                return false; // Not a valid Base64 string
            }

            if (hashBytes.Length != SaltSize + HashSize) // Check if the length of hashBytes is valid
                return false;

            byte[] salt = new byte[SaltSize]; // Declare byte array to hold the salt
            Array.Copy(hashBytes, 0, salt, 0, SaltSize); // Extract the salt from the hashBytes

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations)) // Create PBKDF2 instance with the provided password and extracted salt
            {
                var hash = pbkdf2.GetBytes(HashSize);// Generate the hash for the provided password

                for (int i = 0; i < HashSize; i++) // Compare the generated hash with the stored hash
                {
                    if (hashBytes[i + SaltSize] != hash[i]) // If any byte does not match
                        return false;
                }
            }

            return true;
        }
    }
}