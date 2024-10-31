using Case1.Data.Repository.Interface;
using Case1.Enums;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Case1.WebFramework.Middlewares
{
    public class RolePermissionFilter : IAuthorizationFilter
    {
        private readonly Perms _requiredPermission;
        private readonly IUserRepository _userRepository;

        public RolePermissionFilter(Perms requiredPermission, 
                                    IUserRepository userRepository)
        {
            _requiredPermission = requiredPermission;
            _userRepository = userRepository;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // burda normal sistemde token ile yürütülebilir fakat basic yapmak istediğim için anlık olarak böyle bir tasarım yaptım
            var userIdClaim = context.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

            if (userIdClaim == null)
            {
                context.Result = new UnauthorizedObjectResult(new { message = "Kullanıcı kimliği bulunamadı." });
                return;
            }

            var userId = Guid.Parse(userIdClaim.Value);
            var isAuthorization = _userRepository.CheckPermByUser(userId, _requiredPermission);

            if (!isAuthorization)
            {
                context.Result = new UnauthorizedObjectResult(new { message = "Yetkiniz yok." });
            }
        }
    }
}
