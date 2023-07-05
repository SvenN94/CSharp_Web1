using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMVCClientLocationEFCore.Data;
using WebAppMVCClientLocationEFCore.Models;

namespace WebAppMVCClientLocationEFCore.Controllers
{
    public class ClientLocationController : Controller
    {
        ClientLocationContext _context;
        private IWebHostEnvironment _environment;
        public ClientLocationController(ClientLocationContext context, IWebHostEnvironment environment)
        {
            _environment = environment;
            _context = context;
            //context.Database.EnsureCreated();
        }
        public IActionResult Index()
        {            
            return View();
        }
    }
}
