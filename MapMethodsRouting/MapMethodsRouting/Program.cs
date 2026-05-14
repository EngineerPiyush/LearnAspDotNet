var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.Map("/", () => "Hello World! ALl Http");
//app.MapGet("/",() => "Hello World! GET");
//app.MapPut("/", ()=> "Hello World! PUT");
//app.MapDelete("/", () => "Hellow World! DELETE");
//app.MapPost("/", () => "Hello World! POST");


app.UseRouting();
app.UseEndpoints(endpoints =>{

    endpoints.Map("/", async (context) =>
    {
        await context.Response.WriteAsync("Hello World! ALl Http");
    });
    endpoints.MapGet("/", async (context) =>
    {
        await context.Response.WriteAsync("Hello World! GET");
    });

    endpoints.MapPut("/", async (context) =>
    {
        await context.Response.WriteAsync("Hello World! PUT");
    });

    endpoints.MapDelete("/", async (context) =>
    {
        await context.Response.WriteAsync("Hellow World! DELETE");
    });

    endpoints.MapPost("/", async (context) =>     {
        await context.Response.WriteAsync("Hello World! POST");
    });
});


app.Run( async (HttpContext context) =>
{
    await context.Response.WriteAsync("404 page not found");
});
app.Run();
