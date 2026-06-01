using System;
using System.Collections.Generic;
using System.Linq;

namespace Cafeteria.Modules.UserManagement
{
    public class UserManager
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            users.Add(user);
        }

        public User GetUserById(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public bool UpdateUser(User user)
        {
            var existingUser = GetUserById(user.Id);
            if (existingUser == null)
                return false;

            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            existingUser.Role = user.Role;
            return true;
        }

        public bool DeleteUser(int id)
        {
            var user = GetUserById(id);
            if (user == null)
                return false;

            users.Remove(user);
            return true;
        }
    }
}