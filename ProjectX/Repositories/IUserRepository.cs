using System.Collections.Generic;
using ProjectX.Models;

namespace ProjectX.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        User GetUserByUsernameAndPassword(string username, string password);
    }
}
