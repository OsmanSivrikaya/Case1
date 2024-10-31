using Case1.Enums;
using Case1.WebFramework.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace Case1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpPost]
        [RolePermission(Perms.CategoryCreate)]
        public IActionResult Category() => Ok("Category Create Success");
        [HttpPut]
        [RolePermission(Perms.CategoryUpdate)]
        public IActionResult CategoryUpdate() => Ok("Category Update Success");
        [HttpDelete]
        [RolePermission(Perms.CategoryDelete)]
        public IActionResult CategoryDelete() => Ok("Category Delete Success");
    }
}
