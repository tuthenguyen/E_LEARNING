using E_LEARNING.APPLICATION.Base.Interfaces;
using E_LEARNING.APPLICATION.Security;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace E_LEARNING.APPLICATION.Services
{
    public class JwtService : IJwtService
    {
        private readonly IDateTime _dateTime;
        public JwtService(IDateTime dateTime)
        {
            _dateTime = dateTime;
        }
        public string CreateAccessToken(JwtClaimSetting setting)
        {
            var key = Encoding.ASCII.GetBytes(JwtSetting.SECRET);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, setting.Username),
                    new Claim(ClaimTypes.Email, setting.Email),
                    new Claim(ClaimTypes.NameIdentifier, setting.Id.ToString()),
                    new Claim(ClaimTypes.Role, setting.Role.ToString())
                }),
                Expires = _dateTime.Now.AddMinutes(setting.ExpireMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public JwtClaimSetting VerifyToken(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(JwtSetting.SECRET);
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                if (jwtToken != null && jwtToken.ValidTo >= _dateTime.Now)
                {
                    var result = new JwtClaimSetting
                    {
                        Id = int.Parse(jwtToken.Claims.FirstOrDefault(c => c.Type == "nameid").Value),
                        Email = jwtToken.Claims.FirstOrDefault(c => c.Type == "email").Value,
                        Role = jwtToken.Claims.FirstOrDefault(c => c.Type == "role").Value,
                        Username = jwtToken.Claims.FirstOrDefault(c => c.Type == "unique_name").Value
                    };

                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
