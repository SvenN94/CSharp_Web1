using Microsoft.AspNetCore.Mvc;
using WebAppMVCClientLocationEFCore.Data;
using WebAppMVCClientLocationEFCore.Models;

namespace WebAppMVCClientLocationEFCore.Controllers
{
    public class LocationController : Controller
    {
        ClientLocationContext _context;
        private IWebHostEnvironment _environment;
        public LocationController(ClientLocationContext context, IWebHostEnvironment environment)
        {
            _environment = environment;
            _context = context;
            context.Database.EnsureCreated();
        }

        public IActionResult Index()
        {
            var location = _context.Locations;
            return View(location);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var location = new Location();
            return View(location);
        }
        [HttpPost]
        public IActionResult Create(Location l)
        {
            if (ModelState.IsValid)
            {
                AddClient(l);
                return RedirectToAction("Index");
            }
            return View();
        }
        private void AddClient(Location l)
        {
            _context.Locations.Add(l);
            _context.SaveChanges();
        }
    }
}
