using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FXbox.Cloud.Shared;

namespace FXbox.Cloud.Services.Agents.Hubs
{
    public class AgentControlHub : Hub
    {
        private static readonly Dictionary<string, string> userLookup = new Dictionary<string, string>();

    
        public AgentControlHub()
        {
            
        }
        
        public async Task SendMessage(string username, string message)
        {
            await Clients.All.SendAsync(HubMessages.RECEIVE, username, message);
        }
        
        
        public async Task Register(string username)
        {
            var currentId = Context.ConnectionId;
            if (!userLookup.ContainsKey(currentId))
            {
                // maintain a lookup of connectionId-to-username
                userLookup.Add(currentId, username);
                // re-use existing message for now
                await Clients.AllExcept(currentId).SendAsync(
                    HubMessages.RECEIVE,
                    username, $"{username} joined the chat");
            }
        }
        
        // public async Task AgentRequest(AgentWorkerControlRequest request)
        // {
        //     AgentWorkersTcpServerService.SendToAgent(request.AgentWorkerId, request.Data);
        // }
        
        public override Task OnConnectedAsync()
        {
            Console.WriteLine("Connected");
            return base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception e)
        {
            Console.WriteLine($"Disconnected {e?.Message} {Context.ConnectionId}");
            // try to get connection
            string id = Context.ConnectionId;
            if (!userLookup.TryGetValue(id, out string username))
                username = "[unknown]";

            userLookup.Remove(id);
            await Clients.AllExcept(Context.ConnectionId).SendAsync(
                HubMessages.RECEIVE,
                username, $"{username} has left the chat");
            await base.OnDisconnectedAsync(e);
        }

    }
}