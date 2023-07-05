
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCSportStore.Models.Data
{
    public class Product
    {
        public long? ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "decimal(8,2")]
        public decimal? Price { get; set; }
        [Required]
        public string? Catergory { get; set; }
        //Get property
        public decimal ProductPrice => (Price == null) ? 0 : (decimal)Price;

        public Product()
        {

        }
        public Product(string[] data)
        {
            //name;description;catergory;price
            Name = data[0];
            Description = data[1];
            Catergory = data[2];
            Price = decimal.Parse(data[3]);
        }
    }
}
