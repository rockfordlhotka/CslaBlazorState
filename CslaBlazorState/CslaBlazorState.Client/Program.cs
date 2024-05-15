using Csla.Configuration;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddTransient(_ => 
    new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddCsla(o => o
    .AddBlazorWebAssembly(o => o.SyncContextWithServer = true));

await builder.Build().RunAsync();
