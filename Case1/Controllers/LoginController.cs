using Case1.Dtos;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Case1.Data.Repository.Interface;

namespace Case1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController(IUserRepository _userRepository) : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(LoginDto loginDto)
        {
            var user = _userRepository.CheckPasswordByUser(loginDto);
            if (user is not null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()), // kullanıcı ID'si
                };

                var claimsIdentity = new ClaimsIdentity(claims, "login");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

                // normal şartlarda direk repositoryden gelen user datası döndürülmez fakat kodu basit tutmaya çalıştım asıl amacımız fiter olduğu için
                return Ok(user);
            }
            return BadRequest("Kullanıcı bulunamadı");
        }
    }
}
