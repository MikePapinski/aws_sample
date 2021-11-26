using FXbox.Cloud.Presentation.Agent.Enums;
using FXbox.Cloud.Presentation.Agent.Interfaces;

namespace FXbox.Cloud.Presentation.Agent.Services
{
    public class LogsService: ILogsService
    {
        public LogsService()
        {
            Status = StreamStatus.Disconnected;
        }

        public StreamStatus Status { get; set; }
    }
}