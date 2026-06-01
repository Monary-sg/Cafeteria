using System;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace Cafeteria.Modules.UserManagement
{
    public class AuthenticationService
    {
        private UserManager userManager;

        public AuthenticationService(UserManager manager)
        {
            userManager = manager;
        }

        public User Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                throw new ArgumentException("Email y contraseña son requeridos");

            var user = userManager.GetAllUsers().FirstOrDefault(u => u.Email == email);
            
            if (user == null)
                return null;

            if (!user.IsActive)
                throw new InvalidOperationException("Usuario inactivo");

            if (!VerifyPassword(password, user.PasswordHash))
                return null;

            return user;
        }

        public void RegisterUser(string name, string email, string password, string role)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                throw new ArgumentException("Los campos requeridos no pueden estar vacíos");

            var existingUser = userManager.GetAllUsers().FirstOrDefault(u => u.Email == email);
            if (existingUser != null)
                throw new InvalidOperationException("El email ya está registrado");

            var newUser = new User
            {
                Id = userManager.GetAllUsers().Count + 1,
                Name = name,
                Email = email,
                PasswordHash = HashPassword(password),
                Role = role,
                IsActive = true
            };

            userManager.AddUser(newUser);
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private bool VerifyPassword(string password, string hash)
        {
            var hashOfInput = HashPassword(password);
            return hashOfInput.Equals(hash);
        }
    }
}