using FXbox.Cloud.Presentation.Agent.Enums;

namespace FXbox.Cloud.Presentation.Agent.Interfaces
{
    public interface IAgentService
    {
        public StreamStatus Status { get; set; }
    }
}