using Microsoft.AspNetCore.Mvc;
using MVCSportStore.Data;

namespace MVCSportStore.Components
{
    public class NavigationMenuViewComponent :ViewComponent
    {
        private StoreDbContext _context;
        public NavigationMenuViewComponent(StoreDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["catergory"];
            return View(_context.Products
                .Select(x => x.Catergory)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
