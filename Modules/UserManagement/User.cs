namespace Cafeteria.Modules.UserManagement
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }

        public User()
        {
            IsActive = true;
        }

        public User(int id, string name, string email, string role) : this()
        {
            Id = id;
            Name = name;
            Email = email;
            Role = role;
        }
    }
}