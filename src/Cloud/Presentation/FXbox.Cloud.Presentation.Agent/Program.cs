using FXbox.Cloud.Presentation.Agent.Security;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Threading.Tasks;
using FXbox.Cloud.Presentation.Agent.Interfaces;
using FXbox.Cloud.Presentation.Agent.Services;

namespace FXbox.Cloud.Presentation.Agent
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddHttpClient("api")
                .AddHttpMessageHandler(sp =>
                {
                    var handler = sp.GetService<AuthorizationMessageHandler>()
                        .ConfigureHandler(
                            authorizedUrls: new[] { "https://localhost:5002" },
                            scopes: new[] { "weatherapi" });

                    return handler;
                });
            
            builder.Services.AddSingleton<IAgentService, AgentService>();
            builder.Services.AddSingleton<IAgentsService, AgentsService>();
            builder.Services.AddSingleton<IUsersService, UsersService>();
            builder.Services.AddSingleton<ILogsService, LogsService>();

            builder.Services.AddScoped(sp => sp.GetService<IHttpClientFactory>().CreateClient("api"));

            builder.Services
                .AddOidcAuthentication(options =>
                {
                    builder.Configuration.Bind("oidc", options.ProviderOptions);
                    options.UserOptions.RoleClaim = "role";
                })
                .AddAccountClaimsPrincipalFactory<ArrayClaimsPrincipalFactory<RemoteUserAccount>>();

            await builder.Build().RunAsync();
        }
    }
}
