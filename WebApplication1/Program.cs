using MySql.Data;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var db = new MySql.Data.MySqlClient.MySqlConnection("host=localhost");
Console.Write(db.Database);
app.MapGet("/", () => "Hello World!");

app.Run();