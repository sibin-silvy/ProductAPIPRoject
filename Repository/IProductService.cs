using ProductAPIPRoject.Models;

namespace ProductAPIPRoject.Repository
{
    public interface IProductService
    {
        public IEnumerable<Product> GetProducts();
        public Product PostProduct(Product product);
    }
}
