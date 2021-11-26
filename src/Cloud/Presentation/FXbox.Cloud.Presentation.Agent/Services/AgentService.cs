using FXbox.Cloud.Presentation.Agent.Enums;
using FXbox.Cloud.Presentation.Agent.Interfaces;

namespace FXbox.Cloud.Presentation.Agent.Services
{
    public class AgentService: IAgentService
    {
        public AgentService()
        {
            Status = StreamStatus.Disconnected;
        }

        public StreamStatus Status { get; set; }
    }
}