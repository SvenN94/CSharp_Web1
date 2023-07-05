using Microsoft.AspNetCore.Mvc;
using MVCPartyInvites.Data;
using MVCPartyInvites.Models;

namespace MVCPartyInvites.Controllers
{
    public class GastController : Controller
    {
        public IActionResult Index()
        {
            Gast g = new Gast();
            return View();
        }

        [HttpPost]
        public IActionResult Reservatie(Gast g)
        {
            if (ModelState.IsValid)
            {
                LocalData.GastList.Add(g);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index", g);
            }
        }
    }
}
