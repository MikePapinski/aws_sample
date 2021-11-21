using FXbox.Cloud.Services.Identity.Model;
using MongoDB.Driver;

namespace FXbox.Cloud.Services.Identity.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoDatabase _db;

        public UserRepository(IMongoDatabase db)
        {
            _db = db;
        }

        public User GetUser(string email)
        {
            var col = _db.GetCollection<User>(User.DocumentName);
            var user = col.Find(u => u.Email == email).FirstOrDefault();
            return user;
        }

        public void InsertUser(User user)
        {
            var col = _db.GetCollection<User>(User.DocumentName);
            col.InsertOne(user);
        }
    }
}