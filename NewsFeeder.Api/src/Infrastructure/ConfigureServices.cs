using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration["DbSettings:ConnectionStrings:DefaultConnection"];
        var serverVersion = new MySqlServerVersion(new Version(configuration.GetValue<int>("ConnectionStrings:ServerVersion:Major"), configuration.GetValue<int>("ConnectionStrings:ServerVersion:Minor"), configuration.GetValue<int>("ConnectionStrings:ServerVersion:Build")));
        services.AddDbContext<AppDbContext>(
                    dbContextOptions => dbContextOptions
                        .UseLazyLoadingProxies()
                        .UseMySql(connectionString, serverVersion));
        return services;
    }
}