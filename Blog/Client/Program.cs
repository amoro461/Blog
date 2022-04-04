using Blog.Client;
using Blog.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

var baseAddress = builder.Configuration["BaseAddress"] ?? builder.HostEnvironment.BaseAddress;
builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(baseAddress) });
builder.Services.AddScoped(_ => new UserService ());

await builder.Build().RunAsync();