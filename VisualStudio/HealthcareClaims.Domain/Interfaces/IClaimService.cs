using HealthcareClaims.Domain.Entity;

namespace HealthcareClaims.Domain.Interfaces
{
    public interface IClaimService
    {
        Task<HealthClaimResponse> ProcessClaims(List<HealthClaim> claims);
    }
}
