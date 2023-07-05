using Microsoft.AspNetCore.Mvc;

namespace MVCBooking.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
