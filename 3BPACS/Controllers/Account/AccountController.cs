using _3BPACS.Application;
using _3BPACS.Common.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _3BPACS.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly LoginAppService _loginAppService;

        public AccountController(LoginAppService loginAppService)
        {
            _loginAppService = loginAppService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            var t = loginViewModel;

            var usuarioAutenticadoDto = await _loginAppService.Autenticar(loginViewModel);

            // Definir o token como um cookie seguro e HttpOnly
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None, // Ajuste conforme necessário
                Expires = DateTime.UtcNow.AddHours(1) // Defina a duração do cookie conforme necessário
            };
            Response.Cookies.Append("AuthToken", usuarioAutenticadoDto.Token, cookieOptions);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        { 
            return View(); 
        }

        public IActionResult SignOut()
        {
            Response.Cookies.Delete("AuthToken");

            return RedirectToAction("Index", "Home");
        }
    }
}
