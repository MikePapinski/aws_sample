using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FXbox.Cloud.Presentation.BackOffice.Interfaces;
using FXbox.Cloud.Presentation.BackOffice.Services;

namespace FXbox.Cloud.Presentation.BackOffice
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSingleton<IAgentService, AgentService>();
            builder.Services.AddSingleton<IAgentsService, AgentsService>();
            builder.Services.AddSingleton<IUsersService, UsersService>();
            builder.Services.AddSingleton<ILogsService, LogsService>();
            
            await builder.Build().RunAsync();
        }
    }
}
