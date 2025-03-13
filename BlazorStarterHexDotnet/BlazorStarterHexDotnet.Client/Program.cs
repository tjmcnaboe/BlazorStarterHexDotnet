using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSyncfusionBlazor();

var endpoint = builder.HostEnvironment.BaseAddress + "api/TemplateClass";

builder.Services.AddTemplateClassComponnent(endpoint);
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
await builder.Build().RunAsync();
