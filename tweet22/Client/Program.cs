using Blazored.Toast;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using tweet22.Client;
using tweet22.Client.Services;

namespace tweet22.Client;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        // register banana service, unit service
        builder.Services.AddScoped<IBananaService, BananaService>();
        builder.Services.AddScoped<IUnitService, UnitService>();

        builder.Services.AddBlazoredToast();

        await builder.Build().RunAsync();
    }
}

