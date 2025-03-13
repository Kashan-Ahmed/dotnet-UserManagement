using UserManagementAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace UserManagementAPI.Repositories
{
    public class UserRepository
    {
        private static List<User> _users = new List<User>();

        public List<User> GetAll() => _users;

        public User GetById(int id) => _users.FirstOrDefault(u => u.Id == id);

        public void Add(User user) => _users.Add(user);

        public void Update(User user)
        {
            var existingUser = GetById(user.Id);
            if (existingUser != null)
            {
                existingUser.FirstName = user.FirstName;
                existingUser.LastName = user.LastName;
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
                existingUser.Phone = user.Phone;
            }
        }

        public void Delete(int id) => _users.RemoveAll(u => u.Id == id);
    }
}
