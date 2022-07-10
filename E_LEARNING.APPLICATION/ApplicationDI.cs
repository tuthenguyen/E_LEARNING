using E_LEARNING.APPLICATION.Base.Interfaces;
using E_LEARNING.APPLICATION.Services;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace E_LEARNING.APPLICATION
{
    public static class ApplicationDI
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddSingleton<IPasswordService, PasswordService>();
            services.AddSingleton<IJwtService, JwtService>();
            return services;
        }
    }
}
