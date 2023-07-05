using MVCSportStore.Data;
using MVCSportStore.Models.Data;

namespace MVCSportStore.Models
{
    public class ProductRepository // komt alles samen van de gemaakt product logica
    {
        //geen dependency injection - geen controller class

        StoreDbContext _context; //de database ref
        public ProductRepository(StoreDbContext context) //worden zo gekoppeld
        {
            _context = context;
        }
        private IEnumerable<Product> GetProducts(int productPage,string category) //alle producten van een pagina
        {
            return _context.Products
                .Where(p=> category == null || p.Catergory == category)
                .OrderBy(p => p.ProductId)
                .Skip((productPage - 1) * PagingSettings.ProductPagination)
                .Take(PagingSettings.ProductPagination);
        }
        private PagingInfo GetPagingInfo(int productPage,string category) //info van de paginas
        {
            var pagingInfo = new PagingInfo();
            pagingInfo.CurrentPage = productPage;
            pagingInfo.ItemsPerPage = PagingSettings.ProductPagination;
            pagingInfo.TotalItems = (category == null)
                ? _context.Products.Count()
                : _context.Products.Where(e=> e.Catergory == category).Count();
            return pagingInfo;
        }
        public ProductModel GetProductModel(int productPage, string category) // samenvoegen van vorige methodes om een een pagina met elk product te hebben  
        {
            var productModel = new ProductModel();
            productModel.Products = GetProducts(productPage, category);
            productModel.PagingInfo = GetPagingInfo(productPage,category);
            return productModel;
        }
    }
    
}
