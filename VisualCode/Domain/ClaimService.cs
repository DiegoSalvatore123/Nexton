using  Domain.Entities;
using  Domain.Interfaces;

namespace Domain
{
    public class ClaimService: IClaimService
    {
        private readonly IClaimRepository _claimRepository;
        public ClaimService(IClaimRepository claimRepository)
        {
            _claimRepository= claimRepository;
        }
        public async Task<HealthClaimResponse> ProcessClaims(List<HealthClaim> claims)
        {
            int totalClaims = await _claimRepository.GetTotalClaims(claims) ;
            int valid = await _claimRepository.GetValidClaims(claims);
            int invalid = await _claimRepository.GetInvalidClaims(totalClaims, valid); 
            decimal sum = await _claimRepository.GetAmountClaims(claims);

            HealthClaimResponse claimsResponse = new()
            {
                totalClaims = totalClaims,
                validClaim = valid,
                invalidClaims = invalid,
                totalApprovedAmount = sum
            };
            return claimsResponse;
        }
    }
}
