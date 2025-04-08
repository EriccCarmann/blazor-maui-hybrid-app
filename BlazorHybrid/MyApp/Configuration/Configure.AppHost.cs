using MyApp.Configuration;

[assembly: HostingStartup(typeof(AppHost))]

namespace MyApp.Configuration;

public class AppHost() : AppHostBase("MyApp"), IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices((context, services) =>
        {
            // Configure ASP.NET Core IOC Dependencies
        });

    // Configure your AppHost with the necessary configuration and dependencies your App needs
    public override void Configure()
    {
        SetConfig(new HostConfig {
        });
    }
}
