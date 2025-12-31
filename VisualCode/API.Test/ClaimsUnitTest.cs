using Microsoft.AspNetCore.Http.HttpResults;
using API;
using Domain.Entities;
using Moq;
using Domain.Interfaces;

namespace API.Test;

public class ClaimsUnitTest
{
    [Fact]
    public void GetSummary()
    {
        // Arrange
        var _claim = new Mock<IClaimService>();
        var expectedResult = new HealthClaimResponse { totalClaims = 2, validClaim = 1, invalidClaims = 1, totalApprovedAmount= 100.5M };
        List<HealthClaim> lst= new List<HealthClaim>();
        HealthClaim healthClaim=new()
        {
            Id = 1,
            Provider = "Clinic A",
            Amount = 100.5M,
            DiagnosisCode = "A123",
            Status="Pending"
        };
        lst.Add(healthClaim);
        HealthClaim healthClaim2 = new()
        {
            Id = 2,
            Provider = "Clinic B",
            Amount = 100,
            DiagnosisCode = "123",
            Status = "Pending"
        };
        lst.Add(healthClaim2);

        // Act
        var result = MinimalEndpoint.GetSummary(lst, _claim.Object);
        // Assert
        var okResult = Assert.IsType<Ok<HealthClaimResponse>>(result);
        Assert.Equal(expectedResult, okResult.Value);
    }
}