using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCFifa2022.Data;
using MVCFifa2022.Models;

namespace MVCFifa2022.Controllers
{
    public class PlayerController : Controller
    {
        ApplicationDbContext _context;
        private IWebHostEnvironment _environment;
        public PlayerController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _environment = environment;
            _context = context;
            
        }
        public IActionResult Edit(int id)
        {
            var player = _context.Players.Where(x => x.PlayerId == id).FirstOrDefault();
            return View(player);
        }
        [HttpPost]
        public IActionResult Edit(Player player)
        {
            if (ModelState.IsValid)
            {
                UpdatePlayer(player);
                return RedirectToAction("Index");
            }
            return View(player);
        }
        private void UpdatePlayer(Player player)
        {
            _context.Players.Update(player);
            _context.SaveChanges();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var player = _context.Players.Where(x => x.PlayerId == id).FirstOrDefault();
            return View(player);
        }
        [HttpPost]
        public IActionResult DeletePost(int id)
        {
            var player = _context.Players.Where(x => x.PlayerId == id).FirstOrDefault();
            _context.Players.Remove(player);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var player = _context.Players.Where(x=>x.PlayerId == id).FirstOrDefault();
            var path = _environment.WebRootPath;
            var fileExist = false;
            if (player.ImageLink != null)
            {
                var file = Path.Combine($"{path}\\images",player.ImageLink);
                fileExist = System.IO.File.Exists(file);
            }
            ViewBag.FileExist = fileExist;
            return View(player);
        }

        public IActionResult Index()
        {
            var players = _context.Players;
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var player = new NewPlayer();
            ViewData["TeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName");
            return View(player);
        }
        [HttpPost]
        public IActionResult Create(NewPlayer p)
        {
            if (ModelState.IsValid)
            {
                AddPlayer((Player)p);
                return RedirectToAction("Index");
            }
            return View();
        }
        private void AddPlayer(Player p)
        {
            _context.Players.Add(p);
            _context.SaveChanges();
        }
        private void AddPlayer(NewPlayer player)
        {
            Player p = ((Player)player);
            _context.Players.Add(p);
            _context.SaveChanges();

            var tp = new TeamPlayer();
            tp.PlayerId = (int)p.PlayerId;
            tp.TeamId = player.TeamId;
            tp.StartDate = DateTime.Now;
            _context.TeamPlayers.Add(tp);
            _context.SaveChanges();



        }
        
    }
}
