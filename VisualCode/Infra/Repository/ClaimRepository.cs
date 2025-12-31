using  Domain.Entities;
using  Domain.Interfaces;
using System.Text.RegularExpressions;

namespace  Infra.Repository
{
    public class ClaimRepository: IClaimRepository
    {
        public Task<int> GetTotalClaims(List<HealthClaim> claims)
        {
            int totalClaims = claims.Count();
            return Task.FromResult(totalClaims);
        }
        public Task<int> GetValidClaims(List<HealthClaim> claims)
        {
            string pattern = @"^[A-Za-z]\d{2,4}$";
            int valid = claims.Count(x => x.Amount > 0 && Regex.IsMatch(x.DiagnosisCode, pattern));
            return Task.FromResult(valid);
        }
        public Task<int> GetInvalidClaims(int total, int valid)
        {
            int invalid = total - valid;
            return Task.FromResult(invalid);
        }
        public Task<decimal> GetAmountClaims(List<HealthClaim> claims)
        {
            string pattern = @"^[A-Za-z]\d{2,4}$";
            decimal sum = claims.Where(x => x.Amount > 0 && Regex.IsMatch(x.DiagnosisCode, pattern)).Sum(d => d.Amount);
            return Task.FromResult(sum);
        }
    }
}
