using MVCSportStore.Models.Data;

namespace MVCSportStore.Data
{
    public class Seed
    {
        public static void EnsurePopulated(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<StoreDbContext>();
                if (!context.Products.Any())  
                {
                    //foreach product in defaultdata
                    foreach (var productString in DefaultData.Products)
                    {
                        var product = new Product(productString.Split(';'));
                        context.Products.Add(product);
                    }
                    context.SaveChanges();
                }
            }
        } 
    }
}
