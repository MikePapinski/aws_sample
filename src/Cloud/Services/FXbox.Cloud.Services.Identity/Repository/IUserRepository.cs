using FXbox.Cloud.Services.Identity.Model;

namespace FXbox.Cloud.Services.Identity.Repository
{
    public interface IUserRepository
    {
        User GetUser(string email);
        void InsertUser(User user);
    }
}