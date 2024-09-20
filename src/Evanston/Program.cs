using System.Net.Http.Json;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using System.Text.Json.Serialization;
using Evanston;
using DirectoryDto = Evanston.DirectoryDto;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var http = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
builder.Services.AddScoped(_ => http);

var cacheBypass = $"?v={typeof(Program).Assembly.GetName().Version?.ToString(3)}";
var directory = await http.GetFromJsonAsync<DirectoryDto>($"{http.BaseAddress.AbsoluteUri}/api/v1/directory.json{cacheBypass}", new System.Text.Json.JsonSerializerOptions() { Converters = { new JsonStringEnumConverter() } });
builder.Services
    .AddSingleton(directory ?? new())
    .AddSingleton(new Mappers());

builder.Services.AddMudServices();

builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
