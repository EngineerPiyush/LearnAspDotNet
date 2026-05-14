var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.Use( async (context,next) =>
//{
//    await context.Response.WriteAsync("This is the middleware called use in .net \n");
//    await next(context);
//});
//app.Run(async (context) =>
//{
// await context.Response.WriteAsync("this is the first exitment of .net 10");
//});

//app.MapDefaultControllerRoute();
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=About}/{id?}"
//    );

app.MapControllers();

app.Run();
