using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_LEARNING.WEBAPI
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                //try
                //{
                //    var context = services.GetRequiredService<ApplicationDbContext>();
                //    var controllers = Assembly.GetExecutingAssembly().GetExportedTypes().Where(t => typeof(ControllerBase).IsAssignableFrom(t)).Select(t => t);
                //    await ApplicationDbContextSeed.SeedDefaultRoleAsync(context);
                //    await ApplicationDbContextSeed.SeedDefaultGroupAsync(context);
                //    await ApplicationDbContextSeed.SeedDefaultPermissionAsync(context, controllers);
                //    await ApplicationDbContextSeed.SeedDefaultPermissionReferenceAsync(context);
                //    await ApplicationDbContextSeed.SeedDefaultCodeTypeAsync(context);
                //    await ApplicationDbContextSeed.SeedDefaultCodeTypeReferenceAsync(context);
                //    await ApplicationDbContextSeed.SeedDefaultModuleAsync(context);
                //    await ApplicationDbContextSeed.SeedDefaultModuleStepAsync(context);
                //}
                //catch (Exception ex)
                //{
                //    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                //    logger.LogError(ex, "An error occurred while migrating or seeding the database.");
                //    throw;
                //}
            }
            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.Configure<KestrelServerOptions>(
                    context.Configuration.GetSection("Kestrel"));
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
