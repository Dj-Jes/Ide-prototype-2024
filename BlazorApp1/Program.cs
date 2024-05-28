using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp1;
using BlazorApp1.components;
using BlazorApp1.HttpClient.ItemHttpClient;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(
    sp => 
        new HttpClient { 
            BaseAddress = new Uri("http://localhost:5272/") 
        }
);

builder.Services.AddMudServices();

// adding the HttpClients
builder.Services.AddScoped<IItemHttpClient, ItemHttpClient>();
builder.Services.AddScoped<IFileService, FileService>();

await builder.Build().RunAsync();