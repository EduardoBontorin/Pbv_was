
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using WebAssemby_PickingByVoice;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });





var connString = "localhost,1433; Database = PickingByVoice; User ID = sa; Password = UrbemPassword123@; Trusted_Connection = False; TrustServerCertificate = True";

await builder.Build().RunAsync();
