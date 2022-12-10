using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World 2!");
app.MapPost("/", () => new {name = "Fabio Aiex", Age = 28});
app.MapGet("/AddHeader", (HttpResponse response) => {response.Headers.Add("Teste", "Fabio Aiex Alves");
    return new {name = "Fabio Aiex", Age = 28};
});

app.MapPost("/saveproduct", (Product product) => {
    return product.Code + " - " + product.Name;
});

app.MapGet("/getproduct", ([FromQuery] string dateStart, string dateEnd) => {
    return dateStart + " - " + dateEnd;
});

app.MapGet("/getproduct/{code}", ([FromRoute]string code) => {
    return code;
});

app.MapGet("getproductbyheader", (HttpRequest request) => {
    return request.Headers["product-code"].ToString();
});

app.Run();

public class Product {
    public string Code { get; set; }
    public string Name { get; set; }
}
