using AuthPractice.Interfaces;
using AuthPractice.Models.Entities;

namespace AuthPractice.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> users;
        public UserRepository()
        {
            users = new();
        }
        public bool AddUser(User user)
        {
            try
            {
                users.Add(user);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public User? FindUser(string userName, string password)
        {
            User? user;
            try
            {
                user = users.FirstOrDefault(u => u.UserName.Equals(userName) && u.Password.Equals(password));
            }
            catch(Exception)
            {
                user = null;
            }
            return user;
        }

        public User? FindUser(string userName)
        {
            User? user;
            try
            {
                user = users.FirstOrDefault(u => u.UserName.Equals(userName));
            }
            catch (Exception)
            {
                user = null;
            }
            return user;
        }
    }
}
