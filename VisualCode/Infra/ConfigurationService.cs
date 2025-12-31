using  Domain;
using  Domain.Interfaces;
using  Infra.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace  Infra
{
    public static class ConfigurationService
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IClaimRepository, ClaimRepository>();
            services.AddScoped<IClaimService, ClaimService>();

            return services;
        }
    }
}