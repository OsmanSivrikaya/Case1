using Case1.Enums;
using Case1.WebFramework.Middlewares;
using Microsoft.AspNetCore.Mvc;

namespace Case1.WebFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class RolePermissionAttribute : TypeFilterAttribute
    {
        public RolePermissionAttribute(Perms requiredPermission)
            : base(typeof(RolePermissionFilter))
        {
            Arguments = new object[] { requiredPermission };
        }
    }
}
