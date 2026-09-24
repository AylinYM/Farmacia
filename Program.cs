var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/",()=>
{
    return "API Farmacia funcionando";
});

app.MapGet("/api/farmacia", ()=>
{
    return Results.Ok(new[]
    {
        new{
            id=1,
            codigo="MED001",
            nombre="Paracetamol",
        },
        new{
            id=2,
            codigo="MED002",
            nombre="Ibuprofeno",
        }
    });
});

app.Run();
