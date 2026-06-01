namespace Cafeteria.Modules.Users
{
    public class UsersManagementModule
    {
        private List<User> users = new List<User>();

        public void AddUser(string username, string email, string role)
        {
            users.Add(new User
            {
                Username = username,
                Email = email,
                Role = role,
                CreatedDate = DateTime.Now,
                IsActive = true
            });
        }

        public bool RemoveUser(string username)
        {
            var user = users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                users.Remove(user);
                return true;
            }
            return false;
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserByUsername(string username)
        {
            return users.FirstOrDefault(u => u.Username == username);
        }

        public bool UpdateUser(string username, string email, string role)
        {
            var user = GetUserByUsername(username);
            if (user != null)
            {
                user.Email = email;
                user.Role = role;
                return true;
            }
            return false;
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
