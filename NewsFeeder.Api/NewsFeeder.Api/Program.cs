
using Microsoft.EntityFrameworkCore;
using NewsFeeder.Api.DataAccess;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers(options =>
    {
        options.UseNamespaceRouteToken();
    })
    .AddNewtonsoftJson();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(config =>
{
    config.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "News feed API", Version = "v1" });
    config.EnableAnnotations();
});

var connectionString = builder.Configuration["DbSettings:ConnectionString:DefaultConnection"];
var serverVersion = new MySqlServerVersion(new Version(builder.Configuration.GetValue<int>("ConnectionString:ServerVersion:Major"), builder.Configuration.GetValue<int>("ConnectionString:ServerVersion:Minor"), builder.Configuration.GetValue<int>("ConnectionString:ServerVersion:Build")));
builder.Services.AddDbContext<AppDbContext>(
            dbContextOptions => dbContextOptions
                .UseLazyLoadingProxies()
                .UseMySql(connectionString, serverVersion));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.UsePathBase("/api");

if (app.Environment.IsDevelopment())
{
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "News feed API v1"));

app.MapControllers();

app.Run();
