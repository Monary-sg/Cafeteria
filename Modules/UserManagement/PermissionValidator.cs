using System;
using System.Collections.Generic;
using System.Linq;

namespace Cafeteria.Modules.UserManagement
{
    public enum Permission
    {
        ViewUsers,
        CreateUser,
        EditUser,
        DeleteUser,
        ManagePermissions,
        ViewReports,
        ManageSales
    }

    public class PermissionValidator
    {
        private Dictionary<string, List<Permission>> rolePermissions;

        public PermissionValidator()
        {
            InitializeRolePermissions();
        }

        private void InitializeRolePermissions()
        {
            rolePermissions = new Dictionary<string, List<Permission>>
            {
                { "Admin", new List<Permission> 
                    { 
                        Permission.ViewUsers, Permission.CreateUser, Permission.EditUser, 
                        Permission.DeleteUser, Permission.ManagePermissions, 
                        Permission.ViewReports, Permission.ManageSales 
                    } 
                },
                { "Manager", new List<Permission> 
                    { 
                        Permission.ViewUsers, Permission.CreateUser, Permission.EditUser, 
                        Permission.ViewReports, Permission.ManageSales 
                    } 
                },
                { "Employee", new List<Permission> 
                    { 
                        Permission.ManageSales, Permission.ViewReports 
                    } 
                },
                { "Guest", new List<Permission> 
                    { 
                        Permission.ViewReports 
                    } 
                }
            };
        }

        public bool HasPermission(User user, Permission permission)
        {
            if (user == null || !user.IsActive)
                return false;

            if (!rolePermissions.ContainsKey(user.Role))
                return false;

            return rolePermissions[user.Role].Contains(permission);
        }

        public bool HasAnyPermission(User user, params Permission[] permissions)
        {
            return permissions.Any(p => HasPermission(user, p));
        }

        public bool HasAllPermissions(User user, params Permission[] permissions)
        {
            return permissions.All(p => HasPermission(user, p));
        }

        public List<Permission> GetUserPermissions(User user)
        {
            if (user == null || !rolePermissions.ContainsKey(user.Role))
                return new List<Permission>();

            return rolePermissions[user.Role];
        }
    }
}