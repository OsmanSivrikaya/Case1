using Case1.Data.Repository.Interface;
using Case1.Dtos;
using Case1.Entity;
using Case1.Enums;

namespace Case1.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        #region Fields

        // Bu datalar normal şartlarda veritabanından ilişkili olarak gelmesi gerekir fakat deneme verileri ile yaptığım için veri tekrarı oldu.
        List<User> users = new()
        {
            // ADMİN
            new User {
                Id = Guid.Parse("be0f0c19-3649-4a79-9876-0964c33dc85c"),
                Username = "osman",
                Password = "123",
                Role = new Role {
                    Id = Guid.Parse("eac2af64-26de-4c1c-8e7e-92c7d10ccf94"),
                    RoleName = "Admin",
                    Perms = new List<Perms> { Perms.CategoryCreate, Perms.CategoryDelete, Perms.CategoryUpdate, Perms.UserDelete, Perms.UserCreate, Perms.UserUpdate }
                }
            },

            // MODERATÖR
            new User {
                Id = Guid.Parse("3a187e2c-3aea-4154-8ada-b2361dcdc416"),
                Username = "medine",
                Password = "123",
                Role = new Role {
                    Id = Guid.Parse("a77856e5-dac6-4a70-9b38-0cf7eb8b80d2"),
                    RoleName = "Moderatör",
                    Perms = new List<Perms> { Perms.UserDelete, Perms.UserCreate, Perms.UserUpdate }
                }
            }
        };
        private readonly IRoleRepository _roleRepository;

        #endregion

        #region Ctor

        public UserRepository(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        #endregion

        #region Methods

        public bool CheckPermByUser(Guid userId, Perms perm)
        {

            return users.Any(x => x.Id == userId && x.Role.Perms.Contains(perm));
        }

        public User? CheckPasswordByUser(LoginDto loginDto)
        {
            return users.FirstOrDefault(x => x.Username == loginDto.Username && x.Password == loginDto.Password);
        }

        #endregion
    }
}
