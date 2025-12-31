using API;
using Infra;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddInfrastructureServices();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//app.MapPost("/claims/validate", async (List<HealthClaim> claims, IClaimService myService) =>
//{
  //  if (claims == null || !claims.Any())
 //       return Results.BadRequest("No Claims provided.");
 //   HealthClaimResponse response=await myService.ProcessClaims(claims);
//    return Results.Ok(response);
//});

app.MapPost("/claims/validate", MinimalEndpoint.GetSummary);

app.Run("http://localhost:5000");
