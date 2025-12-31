namespace HealthcareClaims.Domain.Entity
{
    public class HealthClaim
    {
        public int Id { get; set; }
        public string Provider { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string DiagnosisCode { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
