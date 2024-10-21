using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebClient;
using WebClient.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register HttpClient to communicate with the Service API
// Replace the base address with your API's URL: https://localhost:44361
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44361/") });

// Register LoginService to handle login operations
builder.Services.AddScoped<ILoginService, LoginService>();

await builder.Build().RunAsync();
