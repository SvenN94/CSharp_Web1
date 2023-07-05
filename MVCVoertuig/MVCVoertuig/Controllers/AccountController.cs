using Microsoft.AspNetCore.Mvc;
using MVCVoertuig.Models.ViewModels;

namespace MVCVoertuig.Controllers
{
    public class AccountController : Controller
    {
        #region login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel user)
        {
            return View(user);
        }
        #endregion
        #region Register

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel user)
        {
            return View();
        }
        #endregion
    }
}
