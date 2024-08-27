using Blazr.RenderState.Server;
using MachineLearningApplication_Build_2.Components;
using MachineLearningApplication_Build_2.Services;
using Serilog;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using Blazorise.Bootstrap;
using MachineLearningApplication_Build_2.Services.ReinforcementLearningServices;




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

builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrapProviders()
    .AddFontAwesomeIcons();



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["BaseAddress"] ?? "https://localhost") });

builder.Services.AddSingleton<InstanceAttributeStateContainer>();
builder.Services.AddSingleton<NerualNetworkOptions>();


builder.AddBlazrRenderStateServerServices(); // Acess to render services ?


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

app.MapRazorComponents<MachineLearningApplication_Build_2.App>()
   .AddInteractiveServerRenderMode();

app.Run();
