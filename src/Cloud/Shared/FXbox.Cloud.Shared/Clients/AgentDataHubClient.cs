using System;
using System.Threading.Tasks;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace FXbox.Cloud.Shared.Clients
{
    public class AgentDataHubClient : IAsyncDisposable
    {
        public const string HUBURL = "/hub/agent/data";
        
        private readonly string _hubUrl;
        private HubConnection _hubConnection;
        
        public AgentDataHubClient(string siteUrl)
        {
            if (string.IsNullOrWhiteSpace(siteUrl))
                throw new ArgumentNullException(nameof(siteUrl));
            _hubUrl = siteUrl.TrimEnd('/') + HUBURL;
        }
        
        
        private bool _started = false;
        // public async Task StartAsync()
        // {
        //     if (!_started)
        //     {
        //         _hubConnection = new HubConnectionBuilder()
        //             .WithUrl(_hubUrl)
        //             .Build();
        //         _hubConnection.On<AgentWorkerControlRequest>(Messages.RECEIVE, (request) =>
        //         {
        //             HandleReceiveMessage(request);
        //         });
        //         await _hubConnection.StartAsync();
        //         _started = true;
        //     }
        // }
        //
        // public async Task SendAsync(AgentWorkerControlRequest request)
        // {
        //     // check we are connected
        //     if (!_started)
        //         throw new InvalidOperationException("Client not started");
        //     // send the message
        //     await _hubConnection.SendAsync(Messages.AGENT_REQUEST, request);
        // }
        //
        // private void HandleReceiveMessage(AgentWorkerControlRequest log)
        // {
        //     MessageReceived?.Invoke(this, new AgentWorkerControlRequestEventArgs(log));
        // }
        //
        // public event MessageControlRequestReceivedEventHandler MessageReceived;
        
        public async Task StopAsync()
        {
            if (_started)
            {
                await _hubConnection.StopAsync();
                await _hubConnection.DisposeAsync();
                _hubConnection = null;
                _started = false;
            }
        }

        public async ValueTask DisposeAsync()
        {
            await StopAsync();
        }
    }

   // public delegate void MessageControlRequestReceivedEventHandler(object sender, AgentWorkerControlRequestEventArgs e);
    
}