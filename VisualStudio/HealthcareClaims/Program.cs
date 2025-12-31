using HealthcareClaims.API;
using HealthcareClaims.Infra;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddInfrastructureServices();

//builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Define the POST endpoint to receive a list of Claims
//app.MapPost("/claims/validate", async (List<HealthClaim> claims, IClaimService myService) =>
//{
//    if (claims == null || !claims.Any())
//        return Results.BadRequest("No Claims provided.");
//    HealthClaimResponse response = await myService.ProcessClaims(claims);
//    return Results.Ok(response);
//});

// Define the POST endpoint to receive a list of Claims
app.MapPost("/claims/validate", MinimalEndpoint.GetSummary);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();

