using Case1.Data.Repository.Interface;
using Case1.Entity;
using Case1.Enums;

namespace Case1.Data.Repository
{
    public class RoleRepository : IRoleRepository
    {
        List<Role> roles = new()
        {
            new Role {
                Id = Guid.Parse("eac2af64-26de-4c1c-8e7e-92c7d10ccf94"),
                RoleName = "Admin",
                Perms = new List<Perms> { Perms.CategoryCreate, Perms.CategoryDelete, Perms.CategoryUpdate, Perms.UserDelete, Perms.UserCreate, Perms.UserUpdate }
            },
            new Role {
                Id = Guid.Parse("a77856e5-dac6-4a70-9b38-0cf7eb8b80d2"),
                RoleName = "Moderatör",
                Perms = new List<Perms> { Perms.UserDelete, Perms.UserCreate, Perms.UserUpdate }
            }
        };

        public List<Role> GetAllList()
        {
            return roles;
        }
    }
}
