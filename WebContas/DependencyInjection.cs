using WebContas.Interfaces;
using WebContas.Rest;

namespace WebContas;

public static class DependencyInjection
{
    public static IServiceCollection AddInterfaces(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IContasApi, ContasApiRest>();

        return services;
    }
}
