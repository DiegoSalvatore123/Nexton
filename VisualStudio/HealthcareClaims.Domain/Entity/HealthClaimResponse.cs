 
namespace HealthcareClaims.Domain.Entity
{
    public class HealthClaimResponse
    {
        public int totalClaims { get; set; }
        public int validClaim { get; set; }
        public int invalidClaims { get; set; }
        public decimal totalApprovedAmount { get; set; }
    }
}
