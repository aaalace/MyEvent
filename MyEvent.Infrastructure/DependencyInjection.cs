using Microsoft.Extensions.DependencyInjection;
using MyEvent.Application.Common.Interfaces.Auth;
using MyEvent.Application.Common.Interfaces.Utils;
using MyEvent.Infrastructure.Auth;
using MyEvent.Infrastructure.Utils;
using Microsoft.Extensions.Configuration;

namespace MyEvent.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        ConfigurationManager builderConfiguration)
    {
        services.Configure<JwtSettings>(builderConfiguration.GetSection(JwtSettings.SectionName));
        
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        
        return services;
    }
}