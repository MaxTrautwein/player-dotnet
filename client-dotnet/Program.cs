var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/", (System.Text.Json.JsonElement test) =>
{
    return "{\"bet\": \"" + Strategy.decide(Newtonsoft.Json.JsonConvert.DeserializeObject<Table>(test.ToString())).bet + "\"}";
});

app.Run();