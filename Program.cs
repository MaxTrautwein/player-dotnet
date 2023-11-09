var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/", (System.Text.Json.JsonElement body) => "{\"bet\": \"" + Strategy.decide(Newtonsoft.Json.JsonConvert.DeserializeObject<Table>(body.ToString())).bet + "\"}");

app.MapGet("/", () => "Player C#/.net");


app.Run();