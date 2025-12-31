using Domain.Entities;

namespace  Domain.Interfaces
{
    public interface IClaimService
    {
        Task<HealthClaimResponse> ProcessClaims(List<HealthClaim> claims);
    }
}
