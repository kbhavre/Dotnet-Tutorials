using Dotnet_Tutorials.Filters;
using Dotnet_Tutorials.Middlewares;
using Dotnet_Tutorials.Services.ActionFilters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();


builder.Services.AddScoped<ILoggerService, LoggerService>();


// Register Filters
builder.Services.AddScoped<RequestLoggingFilter>();
builder.Services.AddScoped<CustomValidationFilter>();
builder.Services.AddScoped<AuthorizationFilter>();
builder.Services.AddScoped<ExceptionFilter>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Register Custom Middlewares
//app.UseMiddleware<ExecutionTimeMiddleware>();
//app.UseMiddleware<IpAddressMiddleware>();
app.UseMiddleware<RequestLoggingMiddleware>();

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.UseSession();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
