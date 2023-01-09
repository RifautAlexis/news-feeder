using Api.DataAccess;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace Api.IntegrationTests;

using static Testing;

internal class CustomWebApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureAppConfiguration(configurationBuilder =>
        {
            var integrationConfig = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            configurationBuilder.AddConfiguration(integrationConfig);
        });

        builder.ConfigureServices((builder, services) =>
        {
            var connectionString = builder.Configuration["DbSettings:ConnectionStrings:DefaultConnection"];
            var serverVersion = new MySqlServerVersion(new Version(builder.Configuration.GetValue<int>("ConnectionStrings:ServerVersion:Major"), builder.Configuration.GetValue<int>("ConnectionStrings:ServerVersion:Minor"), builder.Configuration.GetValue<int>("ConnectionStrings:ServerVersion:Build")));
            services
                .Remove<DbContextOptions<AppDbContext>>()
                .AddDbContext<AppDbContext>((sp, options) =>
                    options.UseMySql(connectionString, serverVersion));
        });
    }
}