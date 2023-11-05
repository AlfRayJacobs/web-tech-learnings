using WebApiLearning.Services;

namespace WebApiLearning;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Setup container
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddLogging();
        builder.Logging.ClearProviders();
        builder.Logging.AddConsole();

        var app = builder.Build();
        app.UseSwagger()
        .UseSwaggerUI();

        app.MapGet("/namegenerator", (HttpContext context) =>
        {
            var name = NameGenerator.GetName();
            return name;
        })
        .WithName("NameGenerator")
        .WithSummary("Generates a random name")
        .WithOpenApi();

        app.Run();
    }
}
