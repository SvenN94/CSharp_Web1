using Microsoft.AspNetCore.Mvc;
using MVCSportStore.Data;
using MVCSportStore.Models;
using System.Diagnostics;

namespace MVCSportStore.Controllers
{
    public class HomeController : Controller
    {
        private StoreDbContext _context;
        private ProductRepository _repo;
        // _context => Dependency injection
        //_repo => normal class with _context as constructor parameter

        public HomeController(StoreDbContext context)
        {
            _context = context;
            _repo = new ProductRepository(_context);
        }
        public IActionResult Index(int id= 1, string category = null) 
        {
            var productModel = _repo.GetProductModel(id,category);
            return View(productModel);
            //return View(_context.Products);
        }
    }
}