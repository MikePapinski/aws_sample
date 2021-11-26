using FXbox.Cloud.Presentation.Agent.Enums;
using FXbox.Cloud.Presentation.Agent.Interfaces;

namespace FXbox.Cloud.Presentation.Agent.Services
{
    public class UsersService: IUsersService
    {
        public UsersService()
        {
            Status = StreamStatus.Disconnected;
        }

        public StreamStatus Status { get; set; }
    }
}