var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World 2!");
app.MapPost("/", () => new {name = "Fabio Aiex", Age = 28});
app.MapGet("/AddHeader", (HttpResponse response) => response.Headers.Add("Teste", "Fabio Aiex Alves"));

app.Run();
