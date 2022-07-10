using E_LEARNING.APPLICATION.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.APPLICATION.Services
{
    public class PasswordService : IPasswordService
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool Verify(string password, string hash)
        {
            if (string.IsNullOrEmpty(hash))
            {
                return false;
            }
            var result = BCrypt.Net.BCrypt.Verify(password, hash);

            return result;
        }
    }
}
