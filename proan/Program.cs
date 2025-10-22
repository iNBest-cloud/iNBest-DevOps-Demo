var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Demostración de CICD, En una infraestructura IIS");

app.Run();
