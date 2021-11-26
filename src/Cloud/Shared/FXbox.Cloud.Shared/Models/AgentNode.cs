using FXbox.Cloud.Shared.Enums;

namespace FXbox.Cloud.Shared.Models
{
    public class AgentNode
    {
        public string Id { get; set; }
        public string Ip { get; set; }
        public string User { get; set; }
        public NodeConnectionStatus Connection { get; set; }
        public NodeRegisterStatus Registration { get; set; }
    }
}