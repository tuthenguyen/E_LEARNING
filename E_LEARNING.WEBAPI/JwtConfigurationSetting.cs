using E_LEARNING.APPLICATION.Security;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace E_LEARNING.WEBAPI
{
    public static class JwtConfigurationSetting
    {
        public static IServiceCollection AddJwtSetting(this IServiceCollection services)
        {
            var key = Encoding.ASCII.GetBytes(JwtSetting.SECRET);
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateAudience = false,
                    RequireExpirationTime = true,
                    RequireSignedTokens = true,
                    ValidateIssuer = false,
                    //ValidIssuer = issuer,                                        
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });

            return services;
        }
    }
}
