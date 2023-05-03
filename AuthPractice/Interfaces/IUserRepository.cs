using AuthPractice.Models.Entities;

namespace AuthPractice.Interfaces
{
    public interface IUserRepository
    {
        public bool AddUser(User user);
        public User? FindUser(string userName, string password);
        public User? FindUser(string userName);
    }
}
