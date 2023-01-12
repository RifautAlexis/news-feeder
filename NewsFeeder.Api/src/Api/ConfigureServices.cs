namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddApiServices(this IServiceCollection services)
    {
        services
            .AddControllers()
            .AddNewtonsoftJson();

        services.AddSwaggerGen(config =>
        {
            config.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "News feed API", Version = "v1" });
            config.EnableAnnotations();
        });

        return services;
    }
}