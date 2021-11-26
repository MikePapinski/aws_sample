
using FXbox.Cloud.Presentation.Agent.Enums;
using FXbox.Cloud.Presentation.Agent.Interfaces;
//using FXbox.Cloud.Shared.Models;

namespace FXbox.Cloud.Presentation.Agent.Services
{
    public class AgentsService: IAgentsService
    {
        public AgentsService()
        {
            Status = StreamStatus.Disconnected;
            //AgentNodes = new List<AgentNode>();
        }

        public StreamStatus Status { get; set; }
       // public List<AgentNode> AgentNodes { get; }
    }
}