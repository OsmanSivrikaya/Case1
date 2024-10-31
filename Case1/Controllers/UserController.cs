using Case1.Enums;
using Case1.WebFramework.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace Case1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [RolePermission(Perms.UserCreate)]
        public IActionResult User() => Ok("User Create Success");
        [HttpPut]
        [RolePermission(Perms.UserUpdate)]
        public IActionResult UserUpdate() => Ok("User Update Success");
        [HttpDelete]
        [RolePermission(Perms.UserDelete)]
        public IActionResult UserDelete() => Ok("User Delete Success");
    }
}
