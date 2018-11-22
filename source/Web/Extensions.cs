using DotNetCoreArchitecture.Database;
using DotNetCoreArchitecture.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DotNetCoreArchitecture.Web
{
    public static class Extensions
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterServices();
            services.AddCriptography(Guid.NewGuid().ToString());
            services.AddJsonWebTokenSettings(Guid.NewGuid().ToString());
            services.AddLogger(configuration);
            services.AddDbContext<DatabaseContext>(configuration.GetConnectionString(nameof(DatabaseContext)));
        }

        public static void AddSpaStaticFilesDefault(this IServiceCollection services)
        {
            services.AddSpaStaticFiles(spa => spa.RootPath = "Frontend/dist");
        }

        public static void UseSpaDefault(this IApplicationBuilder application, IHostingEnvironment environment)
        {
            application.UseSpa(spa =>
            {
                spa.Options.SourcePath = "Frontend";

                if (environment.IsDevelopment())
                {
                    spa.UseAngularCliServer("serve");
                }
            });
        }
    }
}
