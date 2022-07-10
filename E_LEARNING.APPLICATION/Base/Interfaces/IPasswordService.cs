using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.APPLICATION.Base.Interfaces
{
    public interface IPasswordService
    {
        string HashPassword(string password);
        bool Verify(string password, string hash);
    }
}
