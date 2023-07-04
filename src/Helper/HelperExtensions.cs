using Helper.Exception.Middlewares;
using Helper.Logging;
using Helper.Logging.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Helper;

public static class HelperExtensions
{
    public static void AddHelperExtensions(this IServiceCollection services)
    {
        var config = new ConfigurationBuilder().AddJsonFile("serilog.json").Build();
        Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(config).CreateLogger();

        services.AddHttpContextAccessor();
        services.AddSingleton<ILoggerService, LoggerService>();
        services.AddScoped<ILogModelCreatorService, LogModelCreatorService>();
    }

    public static void UseHelperMiddlewares(this IApplicationBuilder app)
    {
        app.UseMiddleware<LoggerMiddleware>();
        app.UseMiddleware<ExceptionMiddleware>();
    }
}