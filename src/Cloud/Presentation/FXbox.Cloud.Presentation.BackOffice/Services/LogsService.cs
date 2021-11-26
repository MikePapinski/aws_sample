using FXbox.Cloud.Presentation.BackOffice.Enums;
using FXbox.Cloud.Presentation.BackOffice.Interfaces;

namespace FXbox.Cloud.Presentation.BackOffice.Services
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