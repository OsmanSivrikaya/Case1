using Case1.Dtos;
using Case1.Entity;
using Case1.Enums;

namespace Case1.Data.Repository.Interface
{
    public interface IUserRepository
    {
        bool CheckPermByUser(Guid userId, Perms perm);
        User? CheckPasswordByUser(LoginDto loginDto);
    }
}
