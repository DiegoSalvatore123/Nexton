using HealthcareClaims.Domain;
using HealthcareClaims.Domain.Interfaces;
using HealthcareClaims.Infra.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace HealthcareClaims.Infra
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
