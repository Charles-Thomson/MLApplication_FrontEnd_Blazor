using MachineLearningApplication_Build_2.Components;
using MachineLearningApplication_Build_2.Services;
using Serilog;


var builder = WebApplication.CreateBuilder(args);

// Configure Serilog
Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.BrowserConsole()
                .WriteTo.File(@"C:\logs\log.txt")
                .CreateLogger();

builder.Host.UseSerilog(); // Use Serilog for logging

// Add services to the container
builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["BaseAddress"] ?? "https://localhost") });

builder.Services.AddSingleton<InstanceAttributeStateContainer>();

var app = builder.Build();

Log.Information("**SYSTEM** : Logging Started");

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();
