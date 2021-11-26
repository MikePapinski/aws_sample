using FXbox.Cloud.Presentation.BackOffice.Enums;
using FXbox.Cloud.Presentation.BackOffice.Interfaces;

//using FXbox.Cloud.Shared.Models;

namespace FXbox.Cloud.Presentation.BackOffice.Services
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