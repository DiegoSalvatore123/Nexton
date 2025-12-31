using HealthcareClaims.Domain.Entity;

namespace HealthcareClaims.Domain.Interfaces
{
    public interface IClaimRepository
    {
        Task<int> GetTotalClaims(List<HealthClaim> claims);
        Task<int> GetValidClaims(List<HealthClaim> claims);
        Task<int> GetInvalidClaims(int total, int valid);
        Task<decimal> GetAmountClaims(List<HealthClaim> claims);
      
    }
}
