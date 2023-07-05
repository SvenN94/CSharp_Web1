using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using WebAppMVCClientLocationEFCore.Data;
using WebAppMVCClientLocationEFCore.Models;

namespace WebAppMVCClientLocationEFCore.Controllers
{
    public class ClientController : Controller
    {
        ClientLocationContext _context;
        private IWebHostEnvironment _environment;
        public ClientController(ClientLocationContext context, IWebHostEnvironment environment)
        {
            _environment = environment;
            _context = context;
            context.Database.EnsureCreated();
        }

        public IActionResult Index()
        {
            var client = _context.Clients;
            return View(client);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var client = new Client();
            return View(client);
        }
        [HttpPost]
        public IActionResult Create(Client c)
        {
            if (ModelState.IsValid)
            {
                AddClient(c);
                return RedirectToAction("Index");
            }
            return View();
        }
        private void AddClient(Client c)
        {
            _context.Clients.Add(c);
            _context.SaveChanges();
        }
    }
}
