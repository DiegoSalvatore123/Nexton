using Domain.Entities;
using Domain.Interfaces;

namespace API
{
    public static class MinimalEndpoint
    {
        public static async Task<IResult> GetSummary(List<HealthClaim> claims, IClaimService myService)
        {
            if (claims == null || !claims.Any())
                return Results.BadRequest("No Claims provided.");
            HealthClaimResponse response = await myService.ProcessClaims(claims);
            return Results.Ok(response);
        }
    }
}
