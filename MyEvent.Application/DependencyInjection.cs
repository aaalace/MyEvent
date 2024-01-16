using Microsoft.Extensions.DependencyInjection;
using MyEvent.Application.Services.Auth;

namespace MyEvent.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();

        return services;
    }
}