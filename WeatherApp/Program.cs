var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddHealthChecks();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Kestrel config for containers
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(8080);
});

var app = builder.Build();

// Middleware
app.UseSwagger();
app.UseSwaggerUI();

// Endpoints
app.MapGet("/", () => new
{
    Message = "Welcome to the Weather App!",
    Version = "1.0.0",
    Timestamp = DateTime.UtcNow
});

app.MapGet("/weather", () =>
{
    var summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool",
        "Mild", "Warm", "Hot", "Scorching"
    };

    return Enumerable.Range(1, 5).Select(i => new
    {
        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(i)),
        TemperatureC = Random.Shared.Next(-20, 40),
        Summary = summaries[Random.Shared.Next(summaries.Length)]
    });
});

// Health endpoint for Kubernetes
app.MapHealthChecks("/health");

app.Run();
