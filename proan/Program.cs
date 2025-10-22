var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Validacion de IIS, Reinicio de servicio 22/10/2025");

app.Run();
