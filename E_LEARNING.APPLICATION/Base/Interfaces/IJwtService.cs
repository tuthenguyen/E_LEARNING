using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.APPLICATION.Base.Interfaces
{
    public interface IJwtService
    {
        string CreateAccessToken(JwtClaimSetting setting);

        JwtClaimSetting VerifyToken(string token);
    }

    public class JwtClaimSetting
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public double ExpireMinutes { get; set; }
    }
}
