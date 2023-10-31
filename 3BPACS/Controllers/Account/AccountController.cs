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
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            var t = loginViewModel;

            var usuarioAutenticadoDto = _loginAppService.Autenticar(loginViewModel);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        { 
            return View(); 
        }
    }
}
