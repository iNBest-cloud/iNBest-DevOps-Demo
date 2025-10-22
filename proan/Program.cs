var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Esto es una prueba demo del dia 22/10/2025");

app.Run();
